using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CertificationTracker.Application.Dtos.DataItems
{
    [Serializable]
    public class DataItems
    {
        [XmlElement("DataItem")]
        public List<DataItem> DataItem { get; set; }
    }
}
