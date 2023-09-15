using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.ConfigurePOSTAreas
{
    public class POSTCoursesDetail
    {
        public decimal POSTCourseID { get; set; }
        public decimal POSTCourseAreaID { get; set; }
        public decimal CourseHours { get; set; }
        public string CourseTitle { get; set; } = string.Empty;
        public bool IsTrainingRecordAvailable { get; set; }
        public DateTime CourseStartDate { get; set; }
        public string POSTCourseAreas { get; set; } = string.Empty;
        public string InsideInstructors { get; set; } = string.Empty;
        public string OutSideInstructorDetail { get; set; } = string.Empty;
        public string Employees { get; set; } = string.Empty;
        public string Instructors { get; set; } = string.Empty;
        public bool IsCompletedCourse { get; set; }
        public long TotalRecordsCount { get; set; }
    }
}
