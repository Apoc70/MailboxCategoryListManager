// CategoryManager
//
// Authors: Torsten Schlopsnies, Thomas Stensitzki
//
// Published under MIT license
//
// Read more in the following blog post: 
//
// Find more Exchange community scripts at: http://scripts.granikos.eu
// Please report issues or feature request here: 
//
// Version 1.0.0.0 | Published xxxx-xx-xx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Runtime.InteropServices;
using Microsoft.Exchange.WebServices.Data;
using System.Security;

namespace CategoryManager
{
    static class Program
    {
        private static readonly LogHelper log = new LogHelper();
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            log.WriteDebugLog("Main() started");
            var arguments = new UtilityArguments(args);
            string Mailbox, User, URL, Key;
            SecureString Password;
            bool UseDefaultCredentials, IgnoreCertificateErrors, AllowRedirection;
            ExchangeHelper EWSHelper = new ExchangeHelper();
            ExchangeService EWSService = new ExchangeService();

            if (args.Length > 0)
            {
                log.WriteDebugLog("Arguments passed to executable");

                if (arguments.Help)
                {
                    DisplayHelp();
                    Environment.Exit(0);
                }

                // If using settings than load all settings
                if (arguments.UseSettings)
                {
                    MySettings Settings = new MySettings();

                    Key = Settings.Key;
                    if (Settings.User.Length > 0)
                    {
                        User = Settings.User;
                    }
                    else
                    {
                        User = "";
                    }

                    if (Settings.Password.Length > 0)
                    {
                        Password = SecureStringHelper.StringToSecureString(EncryptionHelper.DecryptString(Settings.Password, EncryptionHelper.Base64Decode(Key), 8));
                    }
                    else
                    {
                        Password = null;
                    }
                    if ((Settings.URL.StartsWith("http://")) || (Settings.URL.StartsWith("https://")))
                    {
                        URL = Settings.URL;
                    }
                    else
                    {
                        URL = "";
                    }
                    UseDefaultCredentials = Settings.UseDefaultCredentials;
                    IgnoreCertificateErrors = Settings.IgnoreCertificateErrors;
                    AllowRedirection = Settings.AllowRedirection;
                    Console.WriteLine("Settings loaded from settings file");
                    log.WriteDebugLog("Settings loaded from settings file");
                }
                else
                {
                    if (arguments.User.Length == 0 || arguments.Password.Length == 0)
                    {
                        UseDefaultCredentials = true;
                        log.WriteDebugLog("No user or passsword given. Using default credentials.");
                        User = "";
                        Password = null;
                    }
                    else
                    {
                        UseDefaultCredentials = false;
                        User = arguments.User;
                        Password = Password = SecureStringHelper.StringToSecureString(arguments.Password);
                        log.WriteDebugLog(string.Format("-user: {0}", arguments.User));
                        log.WriteDebugLog("-password: set");
                    }
                    IgnoreCertificateErrors = arguments.IgnoreCertificate;

                }

                Mailbox = arguments.Mailbox;
                AllowRedirection = arguments.AllowRedirection;

                if (arguments.URL.Length > 0)
                {
                    URL = arguments.URL;
                }
                else
                {
                    URL = "";
                }

                if (arguments.ImportFile.Length == 0)
                {
                    log.WriteErrorLog("No import file was given.");
                    DisplayHelp();
                    Environment.Exit(1);
                }

                if (arguments.URL.Length == 0)
                {
                    // Autodiscover
                    if (UseDefaultCredentials)
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, "", null, Mailbox, AllowRedirection, arguments.Impersonate, IgnoreCertificateErrors);
                    }
                    else
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, User, Password, Mailbox, AllowRedirection, arguments.Impersonate, IgnoreCertificateErrors);
                    }

                }
                else
                {
                    // URL
                    if (UseDefaultCredentials)
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, "", null, Mailbox, URL, arguments.Impersonate, IgnoreCertificateErrors);
                    }
                    else
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, User, Password, Mailbox, URL, arguments.Impersonate, IgnoreCertificateErrors);
                    }
                }

                if (EWSService != null)
                {
                    int imported = CategoryHelper.Import(EWSService, arguments.ImportFile, arguments.ClearOnImport);
                    Console.WriteLine(string.Format("{0} categories imported", imported));
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Error on creating the service. Check permissions and if the server is avaiable.");
                    log.WriteErrorLog("Error on creating the service. Check permissions and if the server is avaiable.");
                    Environment.Exit(2);
                }
            }
            else
            {
                log.WriteDebugLog("Main() ended");
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);
                StartForm();
            }
        }

        static void DisplayHelp()
        {
            Console.WriteLine("ManageCategoriesCmd - Usage:");
            Console.WriteLine("ManageCategoriesCmd.exe -mailbox \"user@example.com\" -import \"C:\\categories.xml\" [-ignorecertificate] [-url \"https://server/EWS/Exchange.asmx\"] [-allowredirection] [-user user@example.com] [-password Pa$$w0rd] [-impersonate] [-clearonimport] [-usesettings]");
            Console.WriteLine("If no user or password is given the application uses the user credentials");
        }

        static void StartForm()
        {
            log.WriteDebugLog("StartForm() started");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
            log.WriteDebugLog("StartForm() ended");
        }
    }
}