// CategoryManagerCmd
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
using System.Text;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;
using CategoryManager;
using System.Net;
using System.Security;
using System.IO;
using System.Xml.Serialization;

namespace ManageCategoriesCmd
{
    class Program
    {
        private static readonly LogHelper log = new LogHelper();

        static void Main(string[] args)
        {
            log.WriteDebugLog("Main()");

            if (args.Length > 0)
            {
                // getting all arguments from the command line
                var arguments = new UtilityArguments(args);
                string Mailbox = arguments.Mailbox;
                string ImportFile = arguments.Import;
                string ExportFile = arguments.Export;
                string Action = "none";
                string User = arguments.User;
                bool UseDefaultCredentials = false;
                ExchangeHelper EWSHelper = new ExchangeHelper();
                ExchangeService EWSService = new ExchangeService();

                if (arguments.Help)
                {
                    DisplayHelp();
                    Environment.Exit(0);
                }



                if (Mailbox == null || Mailbox.Length == 0)
                {
                    Console.WriteLine("No mailbox given.");
                    log.WriteErrorLog("No mailbox given. Aborting");
                    DisplayHelp();
                    Environment.Exit(1);
                }

                if (ImportFile.Length > 0 && ExportFile.Length > 0)
                {
                    Console.WriteLine("Only import or export is allowed");
                    log.WriteErrorLog("-import and -export given at the same time. Aborting");
                    DisplayHelp();
                    Environment.Exit(1);
                }

                if (ImportFile.Length > 0)
                {
                    Action = "import";
                }
                else if (ExportFile.Length > 0)
                {
                    Action = "export";
                }
                else
                {
                    Console.WriteLine("At least one action have to be given. -import or -export.");
                    log.WriteErrorLog("At least one action have to be given. -import or -export. Aborting");
                    DisplayHelp();
                    Environment.Exit(1);
                }

                // Log the arguments
                log.WriteDebugLog("Parsing arguments:");
                log.WriteDebugLog(string.Format("-mailbox {0}", Mailbox));
                if (arguments.Import.Length > 0)
                {
                    log.WriteDebugLog(string.Format("import file: {0}", arguments.Import));
                }
                if (ExportFile.Length > 0)
                {
                    log.WriteDebugLog(string.Format("import file: {0}", arguments.Export));
                }
                if (arguments.User.Length == 0 || arguments.Password.Length == 0)
                {
                    UseDefaultCredentials = true;
                    log.WriteDebugLog("No user or passsword given. Using default credentials.");
                }
                else
                {
                    log.WriteDebugLog(string.Format("-user: {0}", arguments.User));
                    log.WriteDebugLog("-password: set");

                }

                if (arguments.IgnoreCertificate)
                {
                    log.WriteDebugLog("Ignoring SSL error because option -ignorecertificate is set");
                }

                if (arguments.URL.Length == 0)
                {
                    log.WriteDebugLog("-url: not given, using autodiscover");
                }
                else
                {
                    log.WriteDebugLog(string.Format("-url: {0}", arguments.URL));
                }
                log.WriteDebugLog(string.Format("-impersonate: {0}", arguments.Impersonate));


                if (arguments.URL.Length == 0)
                {
                    // Autodiscover
                    if (UseDefaultCredentials)
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, "", null, Mailbox, arguments.AllowRedirection, arguments.Impersonate, arguments.IgnoreCertificate);
                    }
                    else
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, User, SecureStringHelper.StringToSecureString(arguments.Password), Mailbox, arguments.AllowRedirection, arguments.Impersonate, arguments.IgnoreCertificate);
                    }

                }
                else
                {
                    // URL
                    if (UseDefaultCredentials)
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, "", null, Mailbox, arguments.URL, arguments.Impersonate, arguments.IgnoreCertificate);
                    }
                    else
                    {
                        EWSService = EWSHelper.Service(UseDefaultCredentials, User, SecureStringHelper.StringToSecureString(arguments.Password), Mailbox, arguments.URL, arguments.Impersonate, arguments.IgnoreCertificate);
                    }
                }

                if (EWSService != null)
                {
                    switch (Action)
                    {
                        case "import":
                            Import(EWSService, arguments.Import, arguments.ClearOnImport);
                            Environment.Exit(0);
                            break;
                        case "export":
                            Export(EWSService, arguments.Export);
                            Environment.Exit(0);
                            break;
                        default:
                            Environment.Exit(1);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error on creating the service. Check permissions and if the server is avaiable.");
                    log.WriteErrorLog("Error on creating the service. Check permissions and if the server is avaiable.");
                    Environment.Exit(2);
                }

            }

            void Import(ExchangeService Service, string FileName, bool ClearonImport)
            {
                if (File.Exists(FileName))
                {
                    var CategoryList = new MasterCategoryList();

                    try
                    {
                        TextReader reader = new StreamReader(FileName);
                        XmlSerializer newSerializer = new XmlSerializer(typeof(MasterCategoryList));

                        CategoryList = (MasterCategoryList)newSerializer.Deserialize(reader);
                    }
                    catch
                    {
                        Console.WriteLine("Error on reading import file. Check permissions and content.");
                        log.WriteErrorLog("Error on reading import file. Check permissions and content.");
                        Environment.Exit(3);
                    }

                    try
                    {
                        log.WriteInfoLog("Importing categories to mailbox");

                        var targetCategoryList = MasterCategoryList.Bind(Service);
                        if (ClearonImport)
                        {
                            log.WriteInfoLog("Clearing categories on import...");
                            if (targetCategoryList.Categories.Count > 0)
                            {
                                for (int i = 0; i <= targetCategoryList.Categories.Count - 1; i++)
                                {
                                    targetCategoryList.Categories.RemoveAt(i);
                                }
                                // update cleared category targetCategoryList
                                targetCategoryList.Update();
                            }
                        }
                        targetCategoryList.Categories = CategoryList.Categories;
                        targetCategoryList.Update();
                        Console.WriteLine("Categories successfully imported");
                        log.WriteInfoLog("Categories successfully imported");
                    }
                    catch
                    {
                        log.WriteErrorLog("Error on importing categories. Check XML file and permissions to the mailbox.");
                    }
                }
                else
                {
                    Console.WriteLine("File to import doesn't exist.");
                    log.WriteErrorLog("File to import doesn't exist.");
                    Environment.Exit(1);
                }
            }

            void Export(ExchangeService Service, string FileName)
            {
                var CategoryList = MasterCategoryList.Bind(Service);

                if (CategoryList != null)
                {
                    try
                    {
                        log.WriteInfoLog(string.Format("Saving categories to file: {0}", FileName));
                        FileStream file = System.IO.File.Create(FileName);
                        XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(MasterCategoryList));
                        writer.Serialize(file, CategoryList);
                        file.Close();
                        log.WriteInfoLog(string.Format("Categories successfully saved to file: {0}", FileName));
                    }
                    catch
                    {
                        log.WriteErrorLog(string.Format("Error on write the file {0}. Check permissions.", FileName));
                    }
                }
            }

            void DisplayHelp()
            {
                Console.WriteLine("ManageCategoriesCmd - Usage for import:");
                Console.WriteLine("ManageCategoriesCmd.exe -mailbox \"user@example.com\" -import \"C:\\categories.xml\" [-ignorecertificate] [-url \"https://server/EWS/Exchange.asmx\"] [-allowredirection] [-user user@example.com] [-password Pa$$w0rd] [-impersonate] [-clearonimport]");
                Console.WriteLine("Usage for export:");
                Console.WriteLine("ManageCategoriesCmd.exe -mailbox \"user@example.com\" -export \"C:\\categories.xml\" [-ignorecertificate] [-url \"https://server/EWS/Exchange.asmx\"] [-allowredirection] [-user user@example.com] [-password Pa$$w0rd] [-impersonate] [-clearonimport]");
                Console.WriteLine("If no user or password is given the application uses the user credentials");
            }
        }
    }
}
