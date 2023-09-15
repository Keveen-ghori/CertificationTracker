using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class POSTApplicableAreaDetail
    {
        public decimal POSTCourseAreaRecordID { get; set; }
        public decimal POSTCourseRecordID { get; set; }
        public int DepartmentEmployeeID { get; set; }
        public decimal POSTAreaID { get; set; }
        public decimal POSTCourseAreaID { get; set; }
        public string Instructors { get; set; } = string.Empty;
        public string OutSideInstructors { get; set; } = string.Empty;
        public string ApplicableAreas { get; set; } = string.Empty;
        public decimal Credits { get; set; }
        public string ApplicableGeneralAreas { get; set; } = string.Empty;
        public string ApplicableGeneralAreasWithDescription { get; set; } = string.Empty;
    }
}
