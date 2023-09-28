using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class POSTAreaListDetail
    {
        public decimal POSTAreaID {  get; set; }
        public string PostAreaName { get; set;} = string.Empty;
    }
}
