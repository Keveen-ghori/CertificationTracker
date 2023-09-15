using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos
{
    public class UserInterfaceDefinitionItem
    {
        public string DisplayName { get; set; }
        public decimal SYSRMSApplicationTypeID { get; set; }
        public string UICategory { get; set; }
        public string CodeID { get; set; }
        public string Description { get; set; }
        public decimal ApplicationStatusID { get; set; }
        public decimal ReportStatusID { get; set; }
        public bool? MustBeAuthor { get; set; }
        public decimal SysRMSUserInterfaceDefinationID { get; set; }
        public string MappingUI { get; set; }
        public bool IsNeedtoCheckatRuntimeforContextMenu { get; set; }
    }
}
