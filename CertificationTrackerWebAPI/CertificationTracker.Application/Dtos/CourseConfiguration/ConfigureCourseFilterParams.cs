using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class ConfigureCourseFilterParams
    {
        public bool includeArchived { get; set; } = false;
        public int pageNumber { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public string ShortOrder { get; set; } = "ASC";
        public string ShortColumn { get; set; } = "CourseTitle";
        public string Keyword { get; set;} = string.Empty;
    }
}
