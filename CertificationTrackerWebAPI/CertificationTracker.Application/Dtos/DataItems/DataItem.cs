using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CertificationTracker.Application.Dtos.DataItems
{
    [Serializable]
    public class DataItem
    {
        [XmlElement("PKID")]
        public string PKID { get; set; }

        [XmlElement("Value")]
        public string Value { get; set; }
        [XmlElement("Table")]
        public string Table { get; set; }
        [XmlElement("DisplayString")]
        public string DisplayString { get; set; }
    }
}
