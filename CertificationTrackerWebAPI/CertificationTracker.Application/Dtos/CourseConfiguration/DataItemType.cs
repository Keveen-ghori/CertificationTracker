using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class DataItemType
    {
        public int PKID { get; set; }
        public string Table { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string DisplayString { get; set; }= string.Empty;
    }
}
