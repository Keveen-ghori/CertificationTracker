using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.CourseConfiguration
{
    public class ApplicableAreas
    {
        //Add Applicable Area
        public decimal POSTAreaID { get; set; }
        public decimal POSTCourseID { get; set; }
        public decimal POSTCourseAreaID { get; set; }
        public int AreaNameID { get; set; }

        public List<Postarea> lstArea { get; set; } = new List<Postarea>();
        public decimal Credit { get; set; }

        public string InsideInstructorsDetail { get; set; } = string.Empty;
        public List<Postinstructor> lstInsideInstructors { get; set; } = new List<Postinstructor>();

        public List<Postinstructor> lstAreaInsideInstructors { get; set; } = new List<Postinstructor>();
        public List<Postinstructor> lstAllInsideInstructors { get; set; } = new List<Postinstructor>();

        public string OutSideInstructorsDetail { get; set; } = string.Empty;
        public List<PostoutSideInstructor> lstOutSideInstructors { get; set; } = new List<PostoutSideInstructor>();
        public bool IncludeAllInstructors { get; set; }

        public bool AreaFromEdit { get; set; }
    }
}
