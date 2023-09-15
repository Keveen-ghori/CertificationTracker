using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.ConfigurePOSTAreas
{
    public class AreaRequirements
    {
        public List<PostcurriculumArea> POSTCurriculumAreaList { get; set; } = new List<PostcurriculumArea>();

        //POST Sub Area List
        public List<POSTAreaDetail> subAreaList { get; set; } = new List<POSTAreaDetail>();
        public int subAreaCount { get; set; }
        public string POSTCurriculumAreaName { get; set; } = string.Empty;
        public string TotalMandatedHours { get; set; } = string.Empty;
        public string TotalMaximumHours { get; set; } = string.Empty;

        public bool IsGeneralAreaList { get; set; }
    }
}
