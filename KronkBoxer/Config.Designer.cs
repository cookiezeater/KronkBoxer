﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KronkBoxer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Config : global::System.Configuration.ApplicationSettingsBase {
        
        private static Config defaultInstance = ((Config)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Config())));
        
        public static Config Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int numClients {
            get {
                return ((int)(this["numClients"]));
            }
            set {
                this["numClients"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Choose client path...")]
        public string clientPath {
            get {
                return ((string)(this["clientPath"]));
            }
            set {
                this["clientPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PlayerName")]
        public string mainPlayer {
            get {
                return ((string)(this["mainPlayer"]));
            }
            set {
                this["mainPlayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("W,A,S,D,Q,E,R")]
        public string keysToSend {
            get {
                return ((string)(this["keysToSend"]));
            }
            set {
                this["keysToSend"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OemMinus")]
        public string macroTPKey {
            get {
                return ((string)(this["macroTPKey"]));
            }
            set {
                this["macroTPKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16.6")]
        public float refreshRate {
            get {
                return ((float)(this["refreshRate"]));
            }
            set {
                this["refreshRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.85")]
        public double controlPadOpacity {
            get {
                return ((double)(this["controlPadOpacity"]));
            }
            set {
                this["controlPadOpacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool setShowAll {
            get {
                return ((bool)(this["setShowAll"]));
            }
            set {
                this["setShowAll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public int sizeWidth {
            get {
                return ((int)(this["sizeWidth"]));
            }
            set {
                this["sizeWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int sizeHeight {
            get {
                return ((int)(this["sizeHeight"]));
            }
            set {
                this["sizeHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int posX {
            get {
                return ((int)(this["posX"]));
            }
            set {
                this["posX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int posY {
            get {
                return ((int)(this["posY"]));
            }
            set {
                this["posY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("390")]
        public int splitTopPoint {
            get {
                return ((int)(this["splitTopPoint"]));
            }
            set {
                this["splitTopPoint"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("390")]
        public int splitBottomPoint {
            get {
                return ((int)(this["splitBottomPoint"]));
            }
            set {
                this["splitBottomPoint"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("247")]
        public int splitMainPoint {
            get {
                return ((int)(this["splitMainPoint"]));
            }
            set {
                this["splitMainPoint"] = value;
            }
        }
    }
}
