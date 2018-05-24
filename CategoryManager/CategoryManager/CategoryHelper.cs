using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CategoryManager
{
    class CategoryHelper
    {
        private static readonly LogHelper log = new LogHelper();

        public static int Import(ExchangeService Service, string FileName, bool ClearOnImport)
        {
            var CategoryList = new MasterCategoryList();
            log.WriteInfoLog(string.Format("Loading XML file: {0}", FileName));

            try
            {
                TextReader reader = new StreamReader(FileName);
                XmlSerializer newSerializer = new XmlSerializer(typeof(MasterCategoryList));

                CategoryList = (MasterCategoryList)newSerializer.Deserialize(reader);
            }
            catch
            {
                log.WriteErrorLog("Error on reading file.");
            }

            try
            {
                log.WriteInfoLog("Importing categories to mailbox");

                var targetCategoryList = MasterCategoryList.Bind(Service);
                if (ClearOnImport)
                {
                    if (targetCategoryList.Categories.Count > 0)
                    {
                        for (int i = targetCategoryList.Categories.Count - 1; i >= 0; i--)
                        {
                            targetCategoryList.Categories.RemoveAt(i);
                        }

                        // update cleared category targetCategoryList
                        targetCategoryList.Update();
                    }
                }

                // if there is nothing no need to compare
                if (targetCategoryList.Categories.Count == 0)
                {
                    targetCategoryList.Categories = CategoryList.Categories;
                    targetCategoryList.Update();
                    log.WriteInfoLog("categories successfully imported");
                    return CategoryList.Categories.Count;
                }
                else
                {
                    // Get all names from the target categories
                    List<string> targetNames = new List<string>();
                    foreach (Category tempCategory in targetCategoryList.Categories)
                    {
                        targetNames.Add(tempCategory.Name);
                    }

                    int importedCategories = 0;
                    for (int i = 0; i < CategoryList.Categories.Count; i++)
                    {
                        if (!(targetNames.Contains(CategoryList.Categories[i].Name)))
                        {
                            targetCategoryList.Categories.Add(CategoryList.Categories[i]);
                            importedCategories++;
                        }
                    }
                    targetCategoryList.Update();
                    log.WriteInfoLog("categories successfully imported");
                    return importedCategories;
                }
            }
            catch
            {
                log.WriteErrorLog("Error on importing categories. Check XML file and permissions to the mailbox.");
                return 0;
            }
        }

        public static int Export(ExchangeService Service, string FileName)
        {
            try
            {
                var CategoryList = MasterCategoryList.Bind(Service);
                // Note: if you connect to a mailbox without an CategoryList you will not get an exception for the first time, after EWS throws an System.ArgumentNullException

                if (CategoryList != null)
                {
                    if (CategoryList.Categories.Count > 0)
                    {
                        try
                        {
                            if (FileName != "")
                            {

                                log.WriteInfoLog(string.Format("Saving categories to file: {0}", FileName));

                                FileStream file = System.IO.File.Create(FileName);
                                XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(MasterCategoryList));

                                writer.Serialize(file, CategoryList);
                                file.Close();
                                log.WriteInfoLog(string.Format("Categories successfully saved to file: {0}", FileName));
                                return CategoryList.Categories.Count;
                            }
                        }
                        catch
                        {
                            log.WriteErrorLog("Error on saving file. Check permissions.");
                            return 0;
                        }
                    }
                    else
                    {
                        log.WriteInfoLog("No categories in mailbox to export.");
                        return 0;
                    }
                }
                else
                {
                    log.WriteErrorLog("Export failed.");
                    return 0;
                }
                return 0;
            }
            catch (System.ArgumentNullException)
            {
                log.WriteErrorLog("No categories in mailbox to export.");
                throw new System.ArgumentNullException();
            }
            catch (Exception ex)
            {
                log.WriteErrorLog(ex.ToString());
                log.WriteErrorLog(ex.Message);
                return 0;
            }
        }

        public static int CopyCategories(ExchangeService SourceService, ExchangeService TargetService, bool ClearOnImport)
        {
            if (SourceService != null && TargetService != null)
            {
                log.WriteInfoLog("Loading source and target categories.");
                // Loading source and target
                var sourceCategoryList = MasterCategoryList.Bind(SourceService);
                var targetCategoryList = MasterCategoryList.Bind(TargetService);

                if (ClearOnImport)
                {
                    if (targetCategoryList.Categories.Count > 0)
                    {
                        for (int i = targetCategoryList.Categories.Count - 1; i >= 0; i--)
                        {
                            targetCategoryList.Categories.RemoveAt(i);
                        }

                        // update cleared category targetCategoryList
                        targetCategoryList.Update();
                    }
                }
                try
                {
                    // Get all names from the target categories
                    List<string> targetNames = new List<string>();
                    foreach (Category tempCategory in targetCategoryList.Categories)
                    {
                        targetNames.Add(tempCategory.Name);
                    }

                    int importedCategories = 0;
                    for (int i = 0; i < sourceCategoryList.Categories.Count; i++)
                    {
                        if (!(targetNames.Contains(sourceCategoryList.Categories[i].Name)))
                        {
                            targetCategoryList.Categories.Add(sourceCategoryList.Categories[i]);
                            importedCategories++;
                        }
                    }

                    targetCategoryList.Update();
                    return importedCategories;
                }
                catch
                {
                    log.WriteErrorLog("Error on copying the categories.");
                    return 0;
                }
            }
            return 0;
        }
    }
}