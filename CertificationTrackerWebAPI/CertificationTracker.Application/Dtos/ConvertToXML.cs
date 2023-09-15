using CertificationTracker.Application.Dtos.DataItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CertificationTracker.Core.Constants
{
    public class ConvertToXML
    {
        public string ConvertedXML(DataItems dataItems)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataItems));

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, dataItems);
                return writer.ToString();
            }
        }
    }
}
