using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class POSTInstructorsDto
    {
        public DepartmentEmployee DepartmentEmployeeIDObj { get; set; }
        public string EditedName { get; set; }
        public DateTime EditedOn { get; set; }
        public string AddedName { get; set; }
        public DateTime AddedOn { get; set; }
        public bool? IsActive { get; set; }
        public int CertificationType { get; set; }
        public DateTime CertifiedExpDate { get; set; }
        public int? InstructorIDNumber { get; set; }
        public int DepartmentEmployeeID { get; set; }
        public decimal POSTInstructorID { get; set; }
        public decimal RecordIdentifyValue { get; set; }
        public bool IsRecordDelete { get; set; }
        public bool IsRecordUpdate { get; set; }
        public string InstructorName { get; set; }
        public RefMiscReferenceDatum CertificationTypeObj { get; set; }
        public string CertificationTypeSTR { get; set; }
    }
}
