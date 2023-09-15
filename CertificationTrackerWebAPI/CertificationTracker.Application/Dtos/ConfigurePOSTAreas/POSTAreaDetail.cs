using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.ConfigurePOSTAreas
{
    public class POSTAreaDetail
    {
        public decimal POSTEmployeeCourseAreaID { get; set; }
        public decimal AttendanceHours { get; set; }
        public bool IsPassed { get; set; }
        public string ArchivedLabel { get; set; } = string.Empty;
        public string RequiredLabel { get; set; } = string.Empty;
        public bool IsRequired { get; set; }
        public int MaximumHours { get; set; }
        public int MandatedHours { get; set; }
        public bool IsActive { get; set; }
        public string POSTAreaDescription { get; set; } = string.Empty;
        public string POSTCurriculumAreaDescription { get; set; } = string.Empty;
        public string POSTAreaName { get; set; } = string.Empty;
        public string POSTCurriculumAreaName { get; set; } = string.Empty;
        public decimal POSTAreaID { get; set; }
        public decimal POSTCurriculumAreaID { get; set; }
        public decimal POSTEmployeeCourseID { get; set; }
        public decimal CreditsEarnedByEmployee { get; set; }
        public int TotalRecords { get; set; } = 0;
    }
}
