using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.ConfigurePOSTAreas
{
    public class AreaDetails
    {
        public decimal POSTAreaID { get; set; }
        //public decimal POSTCurriculumAreaID { get; set; }
        //Actual Area Detail
        [Display(Name = "Area")]
        public string Area { get; set; } = string.Empty;

        [Display(Name = "Area Description")]
        public string AreaDescription { get; set; } = string.Empty;
    }
}
