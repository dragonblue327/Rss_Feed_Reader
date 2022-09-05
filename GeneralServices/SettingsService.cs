using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace RssView.GeneralServices
{
    public class SettingsService
    {
        public SettingsService()
        {
            Assembly _assembly = Assembly.GetExecutingAssembly();
            string[] names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            using (Stream fileStream = _assembly.GetManifestResourceStream("RssView.SettingsFile.xml"))
            {
                XDocument XmlFile = XDocument.Load(fileStream);
                XElement SettingsFile = XmlFile.Element("SettingsFile");
                if (SettingsFile != null)
                {
                    foreach (XElement url in SettingsFile.Element("Urls").Elements("Url")) 
                        Urls.Add(url.Value);
                    FrequencyRefreshInSeconds = Int32.Parse(SettingsFile.Element(nameof(FrequencyRefreshInSeconds)).Value);
                    
                }
            }
        }

        public List<string> Urls { get; set; } = new();

        public int FrequencyRefreshInSeconds { get; set; }


    }
}
