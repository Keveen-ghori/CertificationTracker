using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class CourseConfigurations
    {
        public decimal POSTCourseID { get; set; }

        public string CourseTitle { get; set; } = string.Empty;
        public string Sponsor { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        public string CourseStartDateLabel { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public string CourseEndDateLabel { get; set; } = string.Empty;
        public decimal? CourseFee { get; set; }
        public string CourseFeeLabel { get; set; } = string.Empty;
        public bool? InSideLocation { get; set; }
        public decimal? CourseHours { get; set; }
        public decimal? AttendanceHours { get; set; }
        public string AddressName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;     
        public string LocationString { get; set; } = string.Empty;
        public bool ArchivedCourses { get; set; }
        [DataType(DataType.Date)]
        public DateTime? InstructorCertificationExpiresDate { get; set; }
        public string Comment { get; set; } = string.Empty;
        public string EmployeeDetail { get; set; } = string.Empty;
        public List<Postemployee> _ListPOSTEmployee { get; set; } = new List<Postemployee>();
        public int[] ListEmployee { get; set; } = new int[0];
        public string[] ListSelectedEmployee { get; set; } = new string[0];
        public List<DataItemType> lstEmployees { get; set; } = new List<DataItemType>(); 

        //Configure POST Courses
        [Display(Name = "Include Archived")]
        public bool ArchivedArea { get; set; }

        public List<POSTAreaDetail> AreaDetailList { get; set; } = new List<POSTAreaDetail>();

        public List<POSTCoursesDetail> POSTCoursesList { get; set; } = new List<POSTCoursesDetail>();

        public List<POSTApplicableAreaDetail> POSTApplicableAreaDetails { get; set; } = new List<POSTApplicableAreaDetail>();

        //Choose Course
        public bool ChooseCourse { get; set; }
        public int CloneCourseID { get; set; }
        public List<Postcourse> lstCloneCourse { get; set; } = new List<Postcourse>();

        public int IncludeArchived { get; set; }
        public int MainCourseIDOfClone { get; set; }

    }
}
