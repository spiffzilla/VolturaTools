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
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DiskSpace.Properties {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("DiskSpace.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Form always on top.
        /// </summary>
        internal static string AlwaysOnTop {
            get {
                return ResourceManager.GetString("AlwaysOnTop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap banner {
            get {
                object obj = ResourceManager.GetObject("banner", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \nUsage:\n{0} autorun=[1] notifications=[1] minimized=[1] start=[1]\n\nautorun=1\t\tStart with Windows\nnotifications=1\tShow notifications when disk space changes\nminimized=1\t\tStart in Taskbar only, do not show form when launching\nstart=1\t\t\tStart application after configuration\n\nExamples:\nConfigure not to start with Windows, display notifications, not minimized at startup and launch after configuration:\n{0} autorun= notifications=1 minimized= start=1\n\nConfigure to start with Windows, minimized [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CommandLineTip {
            get {
                return ResourceManager.GetString("CommandLineTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disk clean-up.
        /// </summary>
        internal static string Diskcleanup {
            get {
                return ResourceManager.GetString("Diskcleanup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disk Management.
        /// </summary>
        internal static string DiskManagement {
            get {
                return ResourceManager.GetString("DiskManagement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disk Space.
        /// </summary>
        internal static string DiskSpace {
            get {
                return ResourceManager.GetString("DiskSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to : .
        /// </summary>
        internal static string DriveSeparator {
            get {
                return ResourceManager.GetString("DriveSeparator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drive to monitor.
        /// </summary>
        internal static string DriveToMonitor {
            get {
                return ResourceManager.GetString("DriveToMonitor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  free space.
        /// </summary>
        internal static string FreeSpace {
            get {
                return ResourceManager.GetString("FreeSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GB.
        /// </summary>
        internal static string GB {
            get {
                return ResourceManager.GetString("GB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hide.
        /// </summary>
        internal static string Hide {
            get {
                return ResourceManager.GetString("Hide", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  - .
        /// </summary>
        internal static string MinusSign {
            get {
                return ResourceManager.GetString("MinusSign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notification limit.
        /// </summary>
        internal static string NotificationLimit {
            get {
                return ResourceManager.GetString("NotificationLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max free space for notifications.
        /// </summary>
        internal static string NotificationLimitText {
            get {
                return ResourceManager.GetString("NotificationLimitText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quit.
        /// </summary>
        internal static string Quit {
            get {
                return ResourceManager.GetString("Quit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static Icon samsung_m2_ssd {
            get {
                object obj = ResourceManager.GetObject("samsung_m2_ssd", resourceCulture);
                return ((Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close.
        /// </summary>
        internal static string SaveButtonTitle {
            get {
                return ResourceManager.GetString("SaveButtonTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        internal static string Settings {
            get {
                return ResourceManager.GetString("Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show.
        /// </summary>
        internal static string Show {
            get {
                return ResourceManager.GetString("Show", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Free space notifications.
        /// </summary>
        internal static string ShowNotifications {
            get {
                return ResourceManager.GetString("ShowNotifications", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap simple_gears {
            get {
                object obj = ResourceManager.GetObject("simple_gears", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap simple_gears_grey {
            get {
                object obj = ResourceManager.GetObject("simple_gears_grey", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  .
        /// </summary>
        internal static string Space {
            get {
                return ResourceManager.GetString("Space", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap ssd {
            get {
                object obj = ResourceManager.GetObject("ssd", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start minimized.
        /// </summary>
        internal static string StartMinimized {
            get {
                return ResourceManager.GetString("StartMinimized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto start.
        /// </summary>
        internal static string StartWithWindowsText {
            get {
                return ResourceManager.GetString("StartWithWindowsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TB.
        /// </summary>
        internal static string TB {
            get {
                return ResourceManager.GetString("TB", resourceCulture);
            }
        }
    }
}
