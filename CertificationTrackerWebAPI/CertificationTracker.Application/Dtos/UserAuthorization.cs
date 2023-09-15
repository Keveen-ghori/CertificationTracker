using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos
{
    public class UserAuthorization
    {
        public UserAuthorization() { }

        public RmsuserAccessTrace AlreadyLoggedInAccessTrace { get; set; }
        public bool IsAlreadyLoggedIn { get; set; }
        public bool IsRepInProgressShowAll { get; set; }
        public List<UserInterfaceDefinitionItem> LSTUserInterfaceDefinitionItem { get; set; }
        public decimal AuthorizedAccessID { get; set; }
        public Department Department { get; set; }
        public DepartmentEmployee EmployeeInfo { get; set; }
        public List<SecurityRoleToUser> AuthorizedSecurityRoles { get; set; }
        public bool IsManagedOtherEmployees { get; set; }
        public User AuthorizedUserInfo { get; set; }
        public bool IsAccessAllow { get; set; }
        public string AgencyName { get; set; }
        public string TrainingCertificationUserErrorMessage { get; set; }
        public string JwtAccessToken { get; set; }
        public DateTime JWTRefreshTokenExpirationTime { get; set; }
        public string RefreshToken { get; set; }
        public bool IsTrainingCertificationMode { get; set; }

        public List<string> Role { get; set; } = new List<string>();


    }
}
