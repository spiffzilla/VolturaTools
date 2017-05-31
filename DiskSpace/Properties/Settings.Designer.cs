﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DiskSpace.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));

        //public event System.EventHandler DriveChanged;
        //private static readonly object Locker = new object();

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        ///// <summary>
        ///// Drive to report free space on
        ///// </summary>
        //[global::System.Configuration.UserScopedSettingAttribute()]
        //[global::System.Configuration.SettingsDescriptionAttribute("Drive to report free space on")]
        //[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        //[global::System.Configuration.DefaultSettingValueAttribute("C")]
        //public string driveLetter {
        //    get {
        //        return ((string)(this["driveLetter"]));
        //    }
        //    set {
        //        lock (Locker)
        //        {
        //            if (this["driveLetter"].ToString() != value)
        //            {
        //                this["driveLetter"] = value;
        //                DriveChanged?.Invoke(this, System.EventArgs.Empty);
        //            }
        //        }
        //    }
        //}
        
        /// <summary>
        /// Show application form topmost
        /// </summary>
        [UserScopedSetting()]
        [SettingsDescription("Show application form topmost")]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool alwaysOnTop {
            get {
                return ((bool)(this["alwaysOnTop"]));
            }
            set {
                this["alwaysOnTop"] = value;
            }
        }
        
        /// <summary>
        /// Start application without displaying form
        /// </summary>
        [UserScopedSetting()]
        [SettingsDescription("Start application without displaying form")]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool startMinimized {
            get {
                return ((bool)(this["startMinimized"]));
            }
            set {
                this["startMinimized"] = value;
            }
        }
        
        /// <summary>
        /// Start application automatically with Windows
        /// </summary>
        [UserScopedSetting()]
        [SettingsDescription("Start application automatically with Windows")]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool startWithWindows {
            get {
                return ((bool)(this["startWithWindows"]));
            }
            set {
                this["startWithWindows"] = value;
            }
        }
        
        /// <summary>
        /// Display Balloon notification when free disk space changes
        /// </summary>
        [UserScopedSetting()]
        [SettingsDescription("Display Balloon notification when free disk space changes")]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool notifyWhenSpaceChange {
            get {
                return ((bool)(this["notifyWhenSpaceChange"]));
            }
            set {
                this["notifyWhenSpaceChange"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("700")]
        public uint NotificationLimitGB {
            get {
                return ((uint)(this["NotificationLimitGB"]));
            }
            set {
                this["NotificationLimitGB"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool NotificationLimitActive {
            get {
                return ((bool)(this["NotificationLimitActive"]));
            }
            set {
                this["NotificationLimitActive"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("700")]
        public uint NotificatonAmountLimit {
            get {
                return ((uint)(this["NotificatonAmountLimit"]));
            }
            set {
                this["NotificatonAmountLimit"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("40, 40")]
        public Point mainFormLocation {
            get {
                return ((Point)(this["mainFormLocation"]));
            }
            set {
                this["mainFormLocation"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("10")]
        public int logFileSizeMB {
            get {
                return ((int)(this["logFileSizeMB"]));
            }
            set {
                this["logFileSizeMB"] = value;
            }
        }
    }
}
