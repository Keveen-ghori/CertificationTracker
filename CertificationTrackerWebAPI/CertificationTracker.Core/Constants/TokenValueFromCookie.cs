using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Core.Constants
{
    public class TokenValueFromCookie
    {
        public long UserID { get; set; }
        public int DepartmentID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public long DepartmentEmployeeID { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public long AgencyID { get; set; }
        public string UserName { get; set; } = string.Empty;
        //public string[]? role { get; set; }
    }
}
