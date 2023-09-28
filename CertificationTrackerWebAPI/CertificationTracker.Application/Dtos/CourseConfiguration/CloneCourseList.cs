using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class CloneCourseList
    {
        public string CourseTitle { get; set; } = string.Empty;
        public decimal PostCourseId { get; set; }
    }
}
