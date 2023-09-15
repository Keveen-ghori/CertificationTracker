using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace CertificationTracker.Application.BusinessEntity
{
    public partial class Attributes
    {
        public Attributes LoadFromXMLString(string XMLString)
        {
            if (string.IsNullOrEmpty(XMLString)) return null;
            XmlSerializer serializer = new XmlSerializer(typeof(Attributes));
            Attributes dataObj = null;
            try
            {
                using (XmlReader reader = XmlReader.Create(new StringReader(XMLString)))
                {
                    dataObj = (Attributes)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return dataObj;
        }

        public String ConvertToXML()
        {
            string xmlStr = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Attributes));
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, this);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                xmlStr = xmlDoc.InnerXml;
            }
            return xmlStr;
        }

    }
}
