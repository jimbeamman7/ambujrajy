﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KcptunGUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte setKcptunConfig_SystemBit {
            get {
                return ((byte)(this["setKcptunConfig_SystemBit"]));
            }
            set {
                this["setKcptunConfig_SystemBit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool setKcptunConfig_Compress {
            get {
                return ((bool)(this["setKcptunConfig_Compress"]));
            }
            set {
                this["setKcptunConfig_Compress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server.kcptun.com:29900")]
        public string setKcptunConfig_Server {
            get {
                return ((string)(this["setKcptunConfig_Server"]));
            }
            set {
                this["setKcptunConfig_Server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12948")]
        public uint setKcptunConfig_LocalPort {
            get {
                return ((uint)(this["setKcptunConfig_LocalPort"]));
            }
            set {
                this["setKcptunConfig_LocalPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public byte setKcptunConfig_Mode {
            get {
                return ((byte)(this["setKcptunConfig_Mode"]));
            }
            set {
                this["setKcptunConfig_Mode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte setKcptunConfig_Connects {
            get {
                return ((byte)(this["setKcptunConfig_Connects"]));
            }
            set {
                this["setKcptunConfig_Connects"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string setKcptunConfig_DSCP {
            get {
                return ((string)(this["setKcptunConfig_DSCP"]));
            }
            set {
                this["setKcptunConfig_DSCP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.ragnaroks.org")]
        public string setKcptunConfig_Key {
            get {
                return ((string)(this["setKcptunConfig_Key"]));
            }
            set {
                this["setKcptunConfig_Key"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public byte setKcptunConfig_Crypt {
            get {
                return ((byte)(this["setKcptunConfig_Crypt"]));
            }
            set {
                this["setKcptunConfig_Crypt"] = value;
            }
        }
    }
}
