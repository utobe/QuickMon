﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Properties.Settings.Default.NewVersion)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.NewVersion = false;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.RecentQMConfigFiles == null)
                Properties.Settings.Default.RecentQMConfigFiles = new System.Collections.Specialized.StringCollection();
            if (Properties.Settings.Default.KnownRemoteHosts == null)
            {
                Properties.Settings.Default.KnownRemoteHosts = new System.Collections.Specialized.StringCollection();
            }

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && System.IO.File.Exists(args[0]) && (args[0].ToLower().EndsWith(".qmconfig") || args[0].ToLower().EndsWith(".qmp")))
                Properties.Settings.Default.LastMonitorPack = args[0];
            
            if (!System.IO.File.Exists(MonitorPack.GetQuickMonUserDataTemplatesFile()))
            {
                try
                {
                    QuickMonTemplate.ResetTemplates();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(ex.ToString());
                }
            }
            Application.Run(new MainForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (MessageBox.Show("An unhandled application error occured!\r\nDo you want to close the application?\r\n" + e.Exception.ToString(), "Application error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
