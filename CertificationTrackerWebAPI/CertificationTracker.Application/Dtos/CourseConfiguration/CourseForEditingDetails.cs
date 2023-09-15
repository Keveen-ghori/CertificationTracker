using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class CourseForEditingDetails
    {
        public List<string> lstStudentName { get; set; } = new List<string>();
        public string CourseName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public bool? IsValidForEditing { get; set; }
        public bool? IsAllFullEarnedCredits { get; set; }
        public bool? IsErrorOccurred { get; set; }
        public int? POSTCourseID { get; set; }
    }
}
