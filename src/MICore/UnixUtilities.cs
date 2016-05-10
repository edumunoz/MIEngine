// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Text;

namespace MICore
{
    public static class UnixUtilities
    {
        internal const string ExitString = "exit";
        internal const string FifoPrefix = "Microsoft-MIEngine-fifo-";
        internal const string SudoPath = "/usr/bin/sudo";
        // Mono seems to hang when the is a large response unless we specify a larger buffer
        internal const int StreamBufferSize = 1024 * 4;
        private const string PKExecPath = "/usr/bin/pkexec";

        // Linux specific
        private const string PtraceScopePath = "/proc/sys/kernel/yama/ptrace_scope";

        /// <summary>
        /// Launch a new terminal, spin up a new bash shell, cd to the working dir, execute a tty command to get the shell tty and store it.
        /// Start the debugger in mi mode setting the tty to the terminal defined earlier and redirect stdin/stdout
        /// to the correct pipes. After the debugger exits, cleanup the FIFOs. This is done using the trap command to add a
        /// signal handler for SIGHUP on the console (executing the two rm commands)
        /// </summary>
        /// <param name="debuggeeDir">Path to the debuggee directory</param>
        /// <param name="exitFifo">File where the exit event is written to</param>
        /// <param name="dbgStdInName">File where the stdin for the debugger process is redirected to</param>
        /// <param name="dbgStdOutName">File where the stdout for the debugger process is redirected to</param>
        /// <param name="pidFifo">File where the debugger pid is written to</param>
        /// <param name="debuggerCmd">Command to the debugger</param>
        /// <returns></returns>
        internal static string LaunchLocalDebuggerCommand(
            string debuggeeDir,
            string exitFifo,
            string dbgStdInName,
            string dbgStdOutName,
            string pidFifo,
            string debuggerCmd)
        {
            return string.Format(CultureInfo.InvariantCulture,
               "cd {0}; " +
               "DbgTerm=`tty`; " +
               "trap 'echo {1} > {2}; rm {2} {3} {4} {5}' EXIT; " +
               "{6} --interpreter=mi --tty=$DbgTerm < {3} > {4} & " +
               // Clear the output of executing a process in the background: [job number] pid
               "clear; " +
               "pid=$! ; " +
               "echo $pid > {5}; " +
               "fg > /dev/null; ",
               debuggeeDir,
               ExitString,
               exitFifo,
               dbgStdInName,
               dbgStdOutName,
               pidFifo,
               debuggerCmd
               );
        }

        internal static string GetDebuggerCommand(LocalLaunchOptions localOptions)
        {
            string debuggerPathCorrectElevation = localOptions.MIDebuggerPath;

            // Run the debugger as root if it's needed for attach
            if (localOptions.ProcessId != 0 && UnixUtilities.GetRequiresRootAttach(localOptions.DebuggerMIMode, localOptions.ProcessId))
            {
                debuggerPathCorrectElevation = string.Concat(GetRootCommandPrefix(), " ", debuggerPathCorrectElevation);
            }

            return debuggerPathCorrectElevation;
        }

        internal static string MakeFifo(Logger logger = null)
        {
            string path = Path.Combine(Path.GetTempPath(), FifoPrefix + Path.GetRandomFileName());

            // Mod is normally in octal, but C# has no octal values. This is 384 (rw owner, no rights anyone else)
            const int rw_owner = 384;
            byte[] pathAsBytes = new byte[Encoding.UTF8.GetByteCount(path) + 1];
            Encoding.UTF8.GetBytes(path, 0, path.Length, pathAsBytes, 0);
            int result = UnixNativeMethods.MkFifo(pathAsBytes, rw_owner);

            if (result != 0)
            {
                // Failed to create the fifo. Bail.
                logger?.WriteLine("Failed to create fifo");
                throw new ArgumentException("MakeFifo failed to create fifo at path {0}", path);
            }

            return path;
        }

        private static bool GetRequiresRootAttach(MIMode mode, int debuggeePid)
        {
            if (mode != MIMode.Clrdbg)
            {
                if (PlatformUtilities.IsLinux())
                {
                    // If "ptrace_scope" is a value other than 0, only root can attach to arbitrary processes
                    if (GetPtraceScope() != 0)
                    {
                        return true; // Attaching to any non-child process requires root
                    }
                }
                else if (PlatformUtilities.IsOSX())
                {
                    // If kill can send a signal to the pid, it means the current process has permission
                    // to attach, although OS X might show a dialog to authenticate as admin.
                    return UnixNativeMethods.Kill(debuggeePid, 0) != 0;
                }
            }

            return false;
        }

        /// <summary>
        /// If the system doesn't allow a non-root process to attach to another process, try to run the debugger as root.
        /// See: https://www.kernel.org/doc/Documentation/security/Yama.txt
        /// </summary>
        /// <returns></returns>
        private static int GetPtraceScope()
        {
            if (!File.Exists(UnixUtilities.PtraceScopePath))
            {
                // If the scope file doesn't exist, security is disabled
                return 0;
            }

            try
            {
                string scope = File.ReadAllText(UnixUtilities.PtraceScopePath);
                return Int32.Parse(scope, CultureInfo.CurrentCulture);
            }
            catch
            {
                // If we were unable to determine the current scope setting, assume we need root
                return -1;
            }
        }

        private static string GetRootCommandPrefix()
        {
            if (PlatformUtilities.IsLinux())
            {
                // Prefer pkexec for a nice graphical prompt, but fall back to sudo if it's not available
                if (File.Exists(UnixUtilities.PKExecPath))
                {
                    return UnixUtilities.PKExecPath;
                }
                else if (File.Exists(UnixUtilities.SudoPath))
                {
                    return UnixUtilities.SudoPath;
                }
            }
            else if (PlatformUtilities.IsOSX())
            {
                if (File.Exists(UnixUtilities.SudoPath))
                {
                    return UnixUtilities.SudoPath;
                }
            }

            Debug.Fail("Root required to attach, but no means of elevating available!");
            return string.Empty;
        }
    }
}
