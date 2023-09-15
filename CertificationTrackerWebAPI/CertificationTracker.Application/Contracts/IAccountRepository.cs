using CertificationTracker.Application.Dtos;
using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Contracts
{
    public interface IAccountRepository
    {
        Task<List<User>> Login(string UserName, string Password);

        Task<List<DepOrgEmployee>> UserOrg(int? DepartmentEmployeeID);

        Task<List<SecurityRoleToUser>> UserSecurityRoles(int? UserID);

        Task<List<SecurityRole>> UserRoles();

        Task<List<UserInterfaceDefinitionItem>> GetUserInterfaceDefinitionItems(int UserID);

        Task<decimal> CreateTrace();

        Task<User> GetUser(Expression<Func<User, bool>> expression);
        Task<List<User>> GetUserLists();
        Task<User> GetUserForRefreshToken(Expression<Func<User, bool>> expression);
        Task<UserToken> GetUserToken(Expression<Func<UserToken, bool>> expression);
        Task<List<SysImage>> GetImageLists(decimal DepartmentID);
        Task<List<SystemConfiguration>> systemConfigurations();

        Task<List<UserToken>> GetUserToken(string RefreshToken);
        void SaveTokenValue(UserToken userToken);
        void UpdateTokenValue(UserToken userToken);
        Task<List<UserToken>> userTokens(int UserID);
        void RemoveUserToken(int UserID);
    }
}
