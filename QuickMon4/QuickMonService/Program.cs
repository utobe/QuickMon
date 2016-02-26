﻿using HenIT.Services;
using System;
using System.Collections;
using System.Configuration.Install;
using System.ServiceProcess;

namespace QuickMon
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (Properties.Settings.Default.NewVersion)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.NewVersion = false;
                Properties.Settings.Default.Save();
            }

            if (args.Length > 0)
            {
                string serviceParameters = "";
                string serviceName = "QuickMon 4 Service";
                string displayName = "QuickMon 4 Service";
                string instanceName = "";

                if (args[0].ToUpper() == "-INSTALL")
                {
                    
                    string description = "QuickMon 4 Service for unattended monitoring and Remote hosting.";
                    if (args.Length > 1)
                    {
                        instanceName = args[1];
                        serviceName = "QuickMon 4 Service - " + instanceName;
                        displayName = "QuickMon 4 Service - " + instanceName;
                        serviceParameters = "\"-Instance:" + instanceName + "\"";
                    }
                    if (args.Length > 2)
                        displayName = args[2];
                    if (args.Length > 3)
                        description = args[3];

                    ServiceRegister.InstallService(
                        System.Reflection.Assembly.GetExecutingAssembly().Location,
                        serviceName,
                        displayName,
                        description,
                        serviceParameters);

                    //InstallService();
                    return;
                }
                else if (args[0].ToUpper() == "-UNINSTALL")
                {
                    if (args.Length > 1)
                    {
                        instanceName = args[1];
                        serviceName = "QuickMon 4 Service - " + instanceName;
                    }
                    ServiceRegister.UnInstallService(
                       System.Reflection.Assembly.GetExecutingAssembly().Location,
                       serviceName);

                    //UnInstallService();
                    return;
                }
            }
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new QuickMonService() 
			};
            ServiceBase.Run(ServicesToRun);
        }

        //private static bool InstallService()
        //{
        //    bool success = false;
        //    try
        //    {
        //        string exeFullPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //        string workingPath = System.IO.Path.GetDirectoryName(exeFullPath);
        //        string logPath = System.IO.Path.Combine(workingPath, "Install.log");
        //        ServiceStartMode startmode = ServiceStartMode.Automatic;
        //        ServiceAccount account = ServiceAccount.LocalService;
        //        bool DelayedAutoStart = false;
        //        string username = "";
        //        string password = "";

        //        InstallerForm installerForm = new InstallerForm();
        //        installerForm.StartType = ServiceStartMode.Automatic;
        //        installerForm.AccountType = ServiceAccount.User;
        //        installerForm.BringToFront();
        //        installerForm.TopMost = true;
        //        if (installerForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            startmode = installerForm.StartType;
        //            account = installerForm.AccountType;
        //            if (installerForm.AccountType == ServiceAccount.User)
        //            {
        //                username = installerForm.UserName;
        //                password = installerForm.Password;
        //            }
        //            DelayedAutoStart = installerForm.DelayedStart;
        //        }

        //        Hashtable savedState = new Hashtable();
        //        ProjectInstaller myProjectInstaller = new ProjectInstaller(true);
        //        InstallContext myInstallContext = new InstallContext(logPath, new string[] { });
        //        myProjectInstaller.Context = myInstallContext;
        //        myProjectInstaller.ServiceName = Globals.ServiceEventSourceName;
        //        myProjectInstaller.DisplayName = Globals.ServiceEventSourceName;
        //        myProjectInstaller.Description = Globals.ServiceDescription;
        //        myProjectInstaller.StartType = startmode;
        //        myProjectInstaller.DelayedAutoStart = DelayedAutoStart;
        //        myProjectInstaller.Account = account;
        //        if (account == ServiceAccount.User)
        //        {
        //            myProjectInstaller.ServiceUsername = username;
        //            myProjectInstaller.ServicePassword = password;
        //        }
        //        myProjectInstaller.Context.Parameters["AssemblyPath"] = exeFullPath;

        //        myProjectInstaller.Install(savedState);
        //        success = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message, "Install service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        //    }
        //    return success;
        //}

        //private static bool UnInstallService()
        //{
        //    bool success = false;
        //    try
        //    {
        //        ServiceController sc = new ServiceController("QuickMon 4 Service");
        //        if (sc == null)
        //        {
        //            System.Windows.Forms.MessageBox.Show("Service not installed or accessible!", "Uninstall service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        //            return true;
        //        }
        //        if (sc.Status == ServiceControllerStatus.Running || sc.Status == ServiceControllerStatus.Paused)
        //        {
        //            sc.Stop();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        if (!ex.Message.Contains("was not found on computer"))
        //        {
        //            System.Windows.Forms.MessageBox.Show(ex.Message, "Uninstall service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        //        }
        //        else
        //            return true;
        //    }
        //    try
        //    {
        //        string exeFullPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //        string workingPath = System.IO.Path.GetDirectoryName(exeFullPath);
        //        string logPath = System.IO.Path.Combine(workingPath, "Install.log");

        //        ServiceInstaller myServiceInstaller = new ServiceInstaller();
        //        InstallContext Context = new InstallContext(logPath, null);
        //        myServiceInstaller.Context = Context;
        //        myServiceInstaller.ServiceName = "QuickMon 4 Service";
        //        myServiceInstaller.Uninstall(null);
        //        success = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message, "Uninstall service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        //    }
        //    return success;
        //}
    }
}
