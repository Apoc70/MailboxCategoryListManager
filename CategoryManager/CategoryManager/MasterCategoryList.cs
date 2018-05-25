using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using CategoryManager;
using Microsoft.Exchange.WebServices.Data;

namespace CategoryManager
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "CategoryList.xsd")]
    [XmlRoot(ElementName = "categories", Namespace = "CategoryList.xsd", IsNullable = false)]

	public class MasterCategoryList
	{
		private UserConfiguration _UserConfigurationItem;
        private static readonly LogHelper log = new LogHelper();

        /// <remarks/>
        [XmlElement("category")]
		public List<Category> Categories { get; set; }

		/// <remarks/>
		[XmlIgnore]
		public Guid? DefaultCategory { get; set; }

		[XmlAttribute("default")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string DefaultCategoryText
		{
			get { return DefaultCategory != null ? DefaultCategory.ToString() : string.Empty; }
			set
			{
				Guid result;
				DefaultCategory = (Guid.TryParse(value, out result)) ? result : (Guid?) null;
			}
		}
		

		/// <remarks/>
		[XmlAttribute("lastSavedSession")]
		public byte LastSavedSession { get; set; }

		/// <remarks/>
		[XmlAttribute("lastSavedTime")]
		public DateTime LastSavedTime { get; set; }

		public static MasterCategoryList Bind(ExchangeService service)
		{
            try
            {
                var item = UserConfiguration.Bind(service, "CategoryList", WellKnownFolderName.Calendar,
                                               UserConfigurationProperties.XmlData);

                var reader = new StreamReader(new MemoryStream(item.XmlData), Encoding.UTF8, true);
                var serializer = new XmlSerializer(typeof(MasterCategoryList));
                var result = (MasterCategoryList)serializer.Deserialize(reader);
                result._UserConfigurationItem = item;
                return result;
            }
            catch(System.ArgumentNullException)
            {
                // There is a folder but it didn't have any categories
                // Create an empty list and return it
                var item = UserConfiguration.Bind(service, "CategoryList", WellKnownFolderName.Calendar,
                                               UserConfigurationProperties.XmlData);
                var result = new MasterCategoryList();
                result.Categories = new List<Category>();
                result._UserConfigurationItem = item;
                return result;
            }
            catch(Exception ex)
            {
                // Seems there is no MasterCategoryList, we will try to create a new one
                log.WriteErrorLog(ex.ToString());
                log.WriteErrorLog(ex.Message);
                return CreateNewMasterCartegories(service);
            }
        }

        public static MasterCategoryList CreateNewMasterCartegories(ExchangeService service)
        {
            try
            {
                log.WriteDebugLog("No Master category list found. Try to create a new one.");
                var result = new MasterCategoryList();
                result.Categories = new List<Category>();
                result._UserConfigurationItem = new UserConfiguration(service);
                result._UserConfigurationItem.Save("CategoryList", WellKnownFolderName.Calendar);
                log.WriteDebugLog("Master category list created successfully.");
                return result;
            }
            catch (Exception ex)
            {
                log.WriteErrorLog("No Master category list found. Creation failed. It's not possible to Ex- or Import categories for this mailbox");
                log.WriteErrorLog(ex.ToString());
                log.WriteErrorLog(ex.Message);
                return null;
            }
        }

        public void Update()
		{
            try
            {
                log.WriteDebugLog("Updating categories");
                var stream = new MemoryStream();
                var writer = XmlWriter.Create(stream, new XmlWriterSettings { Encoding = Encoding.UTF8 });
                var serializer = new XmlSerializer(typeof(MasterCategoryList));

                serializer.Serialize(writer, this);
                writer.Flush();
                _UserConfigurationItem.XmlData = stream.ToArray();
                _UserConfigurationItem.Update();
            }
            catch
            {
                log.WriteErrorLog("Updating categories failed.");
            }
		} 
	}
}