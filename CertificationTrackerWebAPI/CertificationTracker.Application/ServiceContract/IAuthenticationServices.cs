using CertificationTracker.Application.Dtos;
using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.ServiceContract
{
    public interface IAuthenticationServices
    {
        Task<ConfigurationSettings> Configuration(Assembly assembly);

        Task<UserAuthorization> UserAuthentication(string UserName, string Password, string IP, string Browser, string MachineInformation);
        Task<UserToken> UserByUserName(string UserName);
        Task<List<User>> UserLists();
        Task<string> DepartmentLogo(string Department, string tokenValue);
        void UpdateUserToken(UserToken userToken);
        Task<User> GetUser(int UserID);
        void RemoveToken(int UserID);
    }
}
