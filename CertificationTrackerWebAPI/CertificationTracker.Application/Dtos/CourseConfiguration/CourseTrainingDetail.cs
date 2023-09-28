using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class CourseTrainingDetail
    {
        public decimal POSTCourseID { get; set; }
        //public string ControlType { get; set; } = string.Empty;
        //public int IsFromCourseDetail { get; set; }
        //public bool ShowPastCourses { get; set; }
        //public bool IsCompletedCourse { get; set; }
        //public int CourseTitleID { get; set; }
        //public List<Postcourse> lstCourse { get; set; } = new List<Postcourse>();

        //[Display(Name = "Select Past Course")]
        //public int PastCourseTitleID { get; set; }
        //public List<Postcourse> lstPastCourse { get; set; } = new List<Postcourse>();

        [Display(Name = "Student(s)")]
        public string Employees { get; set; } = string.Empty;
        //public int[]? ListEmployee { get; set; }
        //public string[]? ListSelectedEmployee { get; set; }
        //public List<DataItemType> lstEmployees { get; set; } = new List<DataItemType>();

        public decimal AttendanceHours { get; set; }

        //public List<POSTApplicableAreaDetail> lstPOSTApplicableAreaDetail { get; set; } = new List<POSTApplicableAreaDetail>();
        //public int postApplicableAreaDetailCount { get; set; }

        //public bool isFromEdit { get; set; }

        //public bool IsCourseEndDateInFuture { get; set; }
    }
}
