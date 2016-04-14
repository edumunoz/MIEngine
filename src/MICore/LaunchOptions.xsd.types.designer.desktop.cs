﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace MICore.Xml.LaunchOptions {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class AndroidLaunchOptions {
        
        private string packageField;
        
        private string launchActivityField;
        
        private string sDKRootField;
        
        private string nDKRootField;
        
        private string intermediateDirectoryField;
        
        private string deviceIdField;
        
        private string logcatServiceIdField;
        
        private bool attachField;
        
        private string sourceRootsField;
        
        private int jVMPortField;
        
        private string jVMHostField;
        
        private TargetArchitecture targetArchitectureField;
        
        private string additionalSOLibSearchPathField;
        
        private MIMode mIModeField;
        
        private bool mIModeFieldSpecified;
        
        private bool waitDynamicLibLoadField;
        
        public AndroidLaunchOptions() {
            this.attachField = false;
            this.sourceRootsField = "";
            this.jVMPortField = 65534;
            this.jVMHostField = "localhost";
            this.waitDynamicLibLoadField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Package {
            get {
                return this.packageField;
            }
            set {
                this.packageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LaunchActivity {
            get {
                return this.launchActivityField;
            }
            set {
                this.launchActivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SDKRoot {
            get {
                return this.sDKRootField;
            }
            set {
                this.sDKRootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NDKRoot {
            get {
                return this.nDKRootField;
            }
            set {
                this.nDKRootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IntermediateDirectory {
            get {
                return this.intermediateDirectoryField;
            }
            set {
                this.intermediateDirectoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceId {
            get {
                return this.deviceIdField;
            }
            set {
                this.deviceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LogcatServiceId {
            get {
                return this.logcatServiceIdField;
            }
            set {
                this.logcatServiceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Attach {
            get {
                return this.attachField;
            }
            set {
                this.attachField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SourceRoots {
            get {
                return this.sourceRootsField;
            }
            set {
                this.sourceRootsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(65534)]
        public int JVMPort {
            get {
                return this.jVMPortField;
            }
            set {
                this.jVMPortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("localhost")]
        public string JVMHost {
            get {
                return this.jVMHostField;
            }
            set {
                this.jVMHostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture {
            get {
                return this.targetArchitectureField;
            }
            set {
                this.targetArchitectureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath {
            get {
                return this.additionalSOLibSearchPathField;
            }
            set {
                this.additionalSOLibSearchPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode {
            get {
                return this.mIModeField;
            }
            set {
                this.mIModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified {
            get {
                return this.mIModeFieldSpecified;
            }
            set {
                this.mIModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitDynamicLibLoad {
            get {
                return this.waitDynamicLibLoadField;
            }
            set {
                this.waitDynamicLibLoadField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum TargetArchitecture {
        
        /// <remarks/>
        x86,
        
        /// <remarks/>
        arm,
        
        /// <remarks/>
        arm64,
        
        /// <remarks/>
        mips,
        
        /// <remarks/>
        x64,
        
        /// <remarks/>
        amd64,
        
        /// <remarks/>
        x86_64,
        
        /// <remarks/>
        X86,
        
        /// <remarks/>
        ARM,
        
        /// <remarks/>
        ARM64,
        
        /// <remarks/>
        MIPS,
        
        /// <remarks/>
        X64,
        
        /// <remarks/>
        AMD64,
        
        /// <remarks/>
        X86_64,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum MIMode {
        
        /// <remarks/>
        gdb,
        
        /// <remarks/>
        lldb,
        
        /// <remarks/>
        clrdbg,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class EnvironmentEntry {
        
        private string nameField;
        
        private string valueField;
        
        private string value1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value1 {
            get {
                return this.value1Field;
            }
            set {
                this.value1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class Command {
        
        private bool ignoreFailuresField;
        
        private bool ignoreFailuresFieldSpecified;
        
        private string descriptionField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IgnoreFailures {
            get {
                return this.ignoreFailuresField;
            }
            set {
                this.ignoreFailuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IgnoreFailuresSpecified {
            get {
                return this.ignoreFailuresFieldSpecified;
            }
            set {
                this.ignoreFailuresFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class BaseLaunchOptions {
        
        private Command[] setupCommandsField;
        
        private Command[] customLaunchSetupCommandsField;
        
        private BaseLaunchOptionsLaunchCompleteCommand launchCompleteCommandField;
        
        private bool launchCompleteCommandFieldSpecified;
        
        private string exePathField;
        
        private string exeArgumentsField;
        
        private string workingDirectoryField;
        
        private string visualizerFileField;
        
        private bool showDisplayStringField;
        
        private bool showDisplayStringFieldSpecified;
        
        private TargetArchitecture targetArchitectureField;
        
        private string additionalSOLibSearchPathField;
        
        private MIMode mIModeField;
        
        private bool mIModeFieldSpecified;
        
        private bool waitDynamicLibLoadField;
        
        public BaseLaunchOptions() {
            this.waitDynamicLibLoadField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Command[] SetupCommands {
            get {
                return this.setupCommandsField;
            }
            set {
                this.setupCommandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Command[] CustomLaunchSetupCommands {
            get {
                return this.customLaunchSetupCommandsField;
            }
            set {
                this.customLaunchSetupCommandsField = value;
            }
        }
        
        /// <remarks/>
        public BaseLaunchOptionsLaunchCompleteCommand LaunchCompleteCommand {
            get {
                return this.launchCompleteCommandField;
            }
            set {
                this.launchCompleteCommandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaunchCompleteCommandSpecified {
            get {
                return this.launchCompleteCommandFieldSpecified;
            }
            set {
                this.launchCompleteCommandFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExePath {
            get {
                return this.exePathField;
            }
            set {
                this.exePathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExeArguments {
            get {
                return this.exeArgumentsField;
            }
            set {
                this.exeArgumentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WorkingDirectory {
            get {
                return this.workingDirectoryField;
            }
            set {
                this.workingDirectoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VisualizerFile {
            get {
                return this.visualizerFileField;
            }
            set {
                this.visualizerFileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ShowDisplayString {
            get {
                return this.showDisplayStringField;
            }
            set {
                this.showDisplayStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowDisplayStringSpecified {
            get {
                return this.showDisplayStringFieldSpecified;
            }
            set {
                this.showDisplayStringFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture {
            get {
                return this.targetArchitectureField;
            }
            set {
                this.targetArchitectureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath {
            get {
                return this.additionalSOLibSearchPathField;
            }
            set {
                this.additionalSOLibSearchPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode {
            get {
                return this.mIModeField;
            }
            set {
                this.mIModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified {
            get {
                return this.mIModeFieldSpecified;
            }
            set {
                this.mIModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitDynamicLibLoad {
            get {
                return this.waitDynamicLibLoadField;
            }
            set {
                this.waitDynamicLibLoadField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum BaseLaunchOptionsLaunchCompleteCommand {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exec-run")]
        execrun,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exec-continue")]
        execcontinue,
        
        /// <remarks/>
        None,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class IOSLaunchOptions {
        
        private string remoteMachineNameField;
        
        private string packageIdField;
        
        private int vcremotePortField;
        
        private IOSLaunchOptionsIOSDebugTarget iOSDebugTargetField;
        
        private string deviceUdidField;
        
        private IOSLaunchOptionsSecure secureField;
        
        private TargetArchitecture targetArchitectureField;
        
        private string additionalSOLibSearchPathField;
        
        private MIMode mIModeField;
        
        private bool mIModeFieldSpecified;
        
        private bool waitDynamicLibLoadField;
        
        public IOSLaunchOptions() {
            this.waitDynamicLibLoadField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemoteMachineName {
            get {
                return this.remoteMachineNameField;
            }
            set {
                this.remoteMachineNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageId {
            get {
                return this.packageIdField;
            }
            set {
                this.packageIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int vcremotePort {
            get {
                return this.vcremotePortField;
            }
            set {
                this.vcremotePortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IOSLaunchOptionsIOSDebugTarget IOSDebugTarget {
            get {
                return this.iOSDebugTargetField;
            }
            set {
                this.iOSDebugTargetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceUdid {
            get {
                return this.deviceUdidField;
            }
            set {
                this.deviceUdidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IOSLaunchOptionsSecure Secure {
            get {
                return this.secureField;
            }
            set {
                this.secureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture {
            get {
                return this.targetArchitectureField;
            }
            set {
                this.targetArchitectureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath {
            get {
                return this.additionalSOLibSearchPathField;
            }
            set {
                this.additionalSOLibSearchPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode {
            get {
                return this.mIModeField;
            }
            set {
                this.mIModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified {
            get {
                return this.mIModeFieldSpecified;
            }
            set {
                this.mIModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitDynamicLibLoad {
            get {
                return this.waitDynamicLibLoadField;
            }
            set {
                this.waitDynamicLibLoadField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum IOSLaunchOptionsIOSDebugTarget {
        
        /// <remarks/>
        Device,
        
        /// <remarks/>
        Simulator,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum IOSLaunchOptionsSecure {
        
        /// <remarks/>
        True,
        
        /// <remarks/>
        False,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class LocalLaunchOptions : BaseLaunchOptions {
        
        private EnvironmentEntry[] environmentField;
        
        private string mIDebuggerPathField;
        
        private string mIDebuggerServerAddressField;
        
        private int processIdField;
        
        private bool processIdFieldSpecified;
        
        private string debugServerField;
        
        private string debugServerArgsField;
        
        private string serverStartedField;
        
        private bool filterStdoutField;
        
        private bool filterStdoutFieldSpecified;
        
        private bool filterStderrField;
        
        private bool filterStderrFieldSpecified;
        
        private int serverLaunchTimeoutField;
        
        private bool serverLaunchTimeoutFieldSpecified;
        
        private string coreDumpPathField;
        
        private bool externalConsoleField;
        
        private bool externalConsoleFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public EnvironmentEntry[] Environment {
            get {
                return this.environmentField;
            }
            set {
                this.environmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIDebuggerPath {
            get {
                return this.mIDebuggerPathField;
            }
            set {
                this.mIDebuggerPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIDebuggerServerAddress {
            get {
                return this.mIDebuggerServerAddressField;
            }
            set {
                this.mIDebuggerServerAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ProcessId {
            get {
                return this.processIdField;
            }
            set {
                this.processIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProcessIdSpecified {
            get {
                return this.processIdFieldSpecified;
            }
            set {
                this.processIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DebugServer {
            get {
                return this.debugServerField;
            }
            set {
                this.debugServerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DebugServerArgs {
            get {
                return this.debugServerArgsField;
            }
            set {
                this.debugServerArgsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServerStarted {
            get {
                return this.serverStartedField;
            }
            set {
                this.serverStartedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FilterStdout {
            get {
                return this.filterStdoutField;
            }
            set {
                this.filterStdoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterStdoutSpecified {
            get {
                return this.filterStdoutFieldSpecified;
            }
            set {
                this.filterStdoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FilterStderr {
            get {
                return this.filterStderrField;
            }
            set {
                this.filterStderrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterStderrSpecified {
            get {
                return this.filterStderrFieldSpecified;
            }
            set {
                this.filterStderrFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ServerLaunchTimeout {
            get {
                return this.serverLaunchTimeoutField;
            }
            set {
                this.serverLaunchTimeoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServerLaunchTimeoutSpecified {
            get {
                return this.serverLaunchTimeoutFieldSpecified;
            }
            set {
                this.serverLaunchTimeoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CoreDumpPath {
            get {
                return this.coreDumpPathField;
            }
            set {
                this.coreDumpPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExternalConsole {
            get {
                return this.externalConsoleField;
            }
            set {
                this.externalConsoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalConsoleSpecified {
            get {
                return this.externalConsoleFieldSpecified;
            }
            set {
                this.externalConsoleFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class PipeLaunchOptions : BaseLaunchOptions {
        
        private string pipePathField;
        
        private string pipeArgumentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipePath {
            get {
                return this.pipePathField;
            }
            set {
                this.pipePathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipeArguments {
            get {
                return this.pipeArgumentsField;
            }
            set {
                this.pipeArgumentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class TcpLaunchOptions : BaseLaunchOptions {
        
        private string hostnameField;
        
        private int portField;
        
        private bool secureField;
        
        private bool secureFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Hostname {
            get {
                return this.hostnameField;
            }
            set {
                this.hostnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Port {
            get {
                return this.portField;
            }
            set {
                this.portField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Secure {
            get {
                return this.secureField;
            }
            set {
                this.secureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecureSpecified {
            get {
                return this.secureFieldSpecified;
            }
            set {
                this.secureFieldSpecified = value;
            }
        }
    }
}
