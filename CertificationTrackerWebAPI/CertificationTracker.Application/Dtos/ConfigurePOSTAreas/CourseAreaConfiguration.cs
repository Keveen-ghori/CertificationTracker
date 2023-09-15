using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.ConfigurePOSTAreas
{
    public class CourseAreaConfiguration
    {
        //Configure Courses
        public List<POSTAreaDetail> AreaDetailList { get; set; } = new List<POSTAreaDetail>();
        public List<POSTCoursesDetail> CoursesDetailList { get; set; } = new List<POSTCoursesDetail>();
        public long TotalRecordsCount { get; set; } = 0;

    }
}
