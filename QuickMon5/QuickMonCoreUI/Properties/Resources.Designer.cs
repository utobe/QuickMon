﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickMon.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuickMon.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap add {
            get {
                object obj = ResourceManager.GetObject("add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string BlankTemplateCollectorAgent {
            get {
                return ResourceManager.GetString("BlankTemplateCollectorAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string BlankTemplateCollectorHost {
            get {
                return ResourceManager.GetString("BlankTemplateCollectorHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string BlankTemplateMonitorPack {
            get {
                return ResourceManager.GetString("BlankTemplateMonitorPack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string BlankTemplateNotifierHost {
            get {
                return ResourceManager.GetString("BlankTemplateNotifierHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USE [QuickMon5]
        ///GO
        ///CREATE TABLE [dbo].[States](
        ///	[StateId] [tinyint] NOT NULL,
        ///	[Description] [nvarchar](50) NOT NULL,
        /// CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
        ///(
        ///	[StateId] ASC
        ///)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
        ///) ON [PRIMARY]
        ///GO
        ///CREATE TABLE [dbo].[AlertLevels](
        ///	[AlertLevel] [tinyint] NOT NULL,
        ///	[Description] [nvarchar](50) NOT NULL,
        /// CONSTRAINT [PK_AlertLevels] PRIMARY KEY CLUSTERED  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleSqlDatabaseCreateScript {
            get {
                return ResourceManager.GetString("ExampleSqlDatabaseCreateScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap OUTLLIBR_9825 {
            get {
                object obj = ResourceManager.GetObject("OUTLLIBR_9825", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap OUTLLIBR_98251 {
            get {
                object obj = ResourceManager.GetObject("OUTLLIBR_98251", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap refresh24x24 {
            get {
                object obj = ResourceManager.GetObject("refresh24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap settings_16 {
            get {
                object obj = ResourceManager.GetObject("settings_16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap smlrightTriangle {
            get {
                object obj = ResourceManager.GetObject("smlrightTriangle", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT top(@top) 
        ///	[InsertDate],
        ///	[AlertLevel],
        ///	[Category],
        ///	[PreviousState],
        ///	[CurrentState],
        ///	[Details]
        ///FROM
        ///	[AlertMessages]
        ///WHERE 
        ///	[InsertDate] between @FromDate and @ToDate and
        ///	(@AlertLevel is null or [AlertLevel] &gt;= @AlertLevel) and
        ///	(@Category is null or [Category] like @Category) and
        ///	(@CurrentState is null or [CurrentState] = @CurrentState) and
        ///	(@Details is null or [Details] like @Details)
        ///ORDER BY
        ///	[InsertDate] desc.
        /// </summary>
        internal static string SqlDatabaseQueryTemplate {
            get {
                return ResourceManager.GetString("SqlDatabaseQueryTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap stop {
            get {
                object obj = ResourceManager.GetObject("stop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap TriangleRight {
            get {
                object obj = ResourceManager.GetObject("TriangleRight", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}