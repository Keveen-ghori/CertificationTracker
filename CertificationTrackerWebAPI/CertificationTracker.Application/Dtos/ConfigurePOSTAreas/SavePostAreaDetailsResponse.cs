using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos.ConfigurePOSTAreas
{
    public class SavePostAreaDetailsResponse
    {
        public List<AreaDetails> PostArea { get; set; } = new List<AreaDetails>();
        public string validationMessage { get; set; } = string.Empty;
        public decimal SelectedArea { get; set; } = 0;

    }
}
