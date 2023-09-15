using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class CheckCourseIsAlreadyExistResponse
    {
        public bool courseIsAlreadyExist { get; set; } = false;
        public string errorMessage { get; set; } = string.Empty;
    }
}
