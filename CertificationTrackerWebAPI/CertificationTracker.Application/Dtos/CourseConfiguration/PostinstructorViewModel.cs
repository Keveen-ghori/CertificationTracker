using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class PostInstructorViewModel
    {
        public decimal PostInstructorId { get; set; }
        public string InstructorName { get; set; } = string.Empty;
        public int? InstructorIdNumber { get; set; }
    }

}
