// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading;

namespace MICore
{
    public class ProcessMonitor: IDisposable
    {
        private int _processId;
        private Timer _monitorTimer;

        public ProcessMonitor(int processId)
        {
            if (!PlatformUtilities.IsLinux() && !PlatformUtilities.IsOSX())
            {
                throw new NotImplementedException();
            }

            _processId = processId;
        }

        public void Start()
        {
            _monitorTimer = new Timer(MonitorForExit, null, TimeSpan.FromMilliseconds(0), TimeSpan.FromMilliseconds(100));
        }

        public event EventHandler ProcessExited;

        private bool HasExited()
        {
            return !UnixUtilities.IsProcessRunning(_processId);
        }

        private void MonitorForExit(object o)
        {
            if (HasExited() && ProcessExited != null)
            {
                _monitorTimer.Change(Timeout.Infinite, Timeout.Infinite);
                ProcessExited(this, null);
            }
        }

        public void Dispose()
        {
            _monitorTimer.Dispose();
        }
    }
}
