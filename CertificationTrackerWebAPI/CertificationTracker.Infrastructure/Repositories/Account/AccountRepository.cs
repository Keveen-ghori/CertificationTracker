using CertificationTracker.Application.Contracts;
using CertificationTracker.Application.Dtos;
using CertificationTracker.Data.Models;
using CertificationTracker.Data.Settings;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Infrastructure.Repositories.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly CertificationTrackerContext context;
        private readonly string connectionString = @"server = PCI101\SQL2019;Database=CertificationTracker;User Id = sa; Password=Tatva@123;Trusted_connection=False;Encrypt=False;TrustServerCertificate=True";

        public AccountRepository(CertificationTrackerContext context)
        {
            this.context = context;
        }

        public Task<decimal> CreateTrace()
        {
            throw new NotImplementedException();
        }

        #region User Interface Definition
        public async Task<List<UserInterfaceDefinitionItem>> GetUserInterfaceDefinitionItems(int UserID)
        {
            List<UserInterfaceDefinitionItem> lstUserInterfaceDefinitionItem = new List<UserInterfaceDefinitionItem>();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (SqlCommand cmdRating = new("sp_Employee_GetUserInterfaceDefinitionItems", connection))
                {
                    cmdRating.CommandType = CommandType.StoredProcedure;
                    cmdRating.CommandTimeout = 120;

                    using (SqlDataAdapter adapter = new(cmdRating))
                    {
                        cmdRating.Parameters.AddWithValue("@UserID", UserID);

                        try
                        {
                            DataSet ds = new();
                            adapter.Fill(ds);
                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow row in ds.Tables[0].Rows)
                                {
                                    UserInterfaceDefinitionItem definitionItem = new();

                                    definitionItem.DisplayName = (string)row["DisplayName"];
                                    definitionItem.SYSRMSApplicationTypeID = (decimal)row["SYSRMSApplicationTypeID"];
                                    definitionItem.UICategory = (string)row["UICategory"];
                                    definitionItem.CodeID = (string)row["CodeID"];
                                    definitionItem.Description = (string)row["Description"];
                                    definitionItem.ApplicationStatusID = (decimal)row["ApplicationStatusID"];
                                    definitionItem.ReportStatusID = (decimal)row["ReportStatusID"];
                                    definitionItem.MustBeAuthor = (bool?)row["MustBeAuthor"];
                                    definitionItem.SysRMSUserInterfaceDefinationID = (decimal)row["SysRMSUserInterfaceDefinationID"];
                                    definitionItem.MappingUI = (string)row["MappingUI"];
                                    definitionItem.IsNeedtoCheckatRuntimeforContextMenu = (bool)row["IsNeedtoCheckatRuntimeforContextMenu"];

                                    lstUserInterfaceDefinitionItem.Add(definitionItem);
                                }

                            }
                            cmdRating.ExecuteNonQuery();
                            connection.Close();
                            return lstUserInterfaceDefinitionItem;

                        }
                        catch (Exception)
                        {
                            connection.Close();
                            throw new Exception("Can't able to retrieve data.");
                        }
                    }
                }
            }
        }

        #endregion
        public async Task<List<User>> Login(string UserName, string Password)
        {
            List<User> user = new();

            user = await this.context.Users.Include(item => item.Agency).Include(item => item.Department).Include(item => item.DepartmentEmployee).Where(item => item.UserName == UserName).ToListAsync();

            return user;
        }

        public async Task<List<DepOrgEmployee>> UserOrg(int? DepartmentEmployeeID)
        {
            List<DepOrgEmployee> employee = await this.context.DepOrgEmployees.Where(item => item.IsOrgSupervisor == true && item.DepartmentEmployeeId == DepartmentEmployeeID).ToListAsync();
            return employee;
        }

        public async Task<List<SecurityRole>> UserRoles()
        {
            List<SecurityRole> roles = await this.context.SecurityRoles.ToListAsync();
            return roles;
        }

        public async Task<List<SecurityRoleToUser>> UserSecurityRoles(int? UserID)
        {
            List<SecurityRoleToUser> roleToUser = await this.context.SecurityRoleToUsers.Where(item => item.UserId == UserID).ToListAsync();
            return roleToUser;
        }

        public async Task<User> GetUser(Expression<Func<User, bool>> expression)
        {
            return await this.context.Users.FirstOrDefaultAsync(expression);
        }

        public async Task<User> GetUserForRefreshToken(Expression<Func<User, bool>> expression)
        {
            User user = new();
            user = await this.context.Users.Include(item => item.Agency).Include(item => item.Department).Include(item => item.DepartmentEmployee).Where(expression).FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<User>> GetUserLists()
        {
            return await this.context.Users.ToListAsync();
        }

        public async Task<List<SysImage>> GetImageLists(decimal DepartmentID)
        {
            List<SysImage> sysImages = new();
            sysImages = await this.context.SysImages.Where(item => item.DepartmentId == DepartmentID).ToListAsync();
            return sysImages;
        }

        public async Task<List<SystemConfiguration>> systemConfigurations()
        {
            return this.context.SystemConfigurations.Where(item => item.ConfigurationName == "DefaultApplicationImage").ToList();
        }

        public async Task<List<UserToken>> GetUserToken(string RefreshToken)
        {
            List<UserToken> userToken = await this.context.UserTokens.ToListAsync();
            return userToken;
        }

        public void SaveTokenValue(UserToken userToken)
        {
            this.context.UserTokens.Add(userToken);
            this.context.SaveChanges();
        }

        public void UpdateTokenValue(UserToken userToken)
        {
            var existingToken = this.context.UserTokens.Where(token => token.UserId == userToken.UserId).FirstOrDefault();
            if (existingToken != null)
            {
                existingToken.Token = userToken.Token;
                existingToken.Expired = false;
                existingToken.AddedOn = DateTime.Now;
                existingToken.AddedName = userToken.AddedName;
                existingToken.RefreshToken = userToken.RefreshToken;
                existingToken.RefreshTokenExpiry = userToken.RefreshTokenExpiry;

                this.context.SaveChanges();
            }
        }

        public async Task<UserToken> GetUserToken(Expression<Func<UserToken, bool>> expression)
        {
            return await this.context.UserTokens.FirstOrDefaultAsync(expression);
        }

        public async Task<List<UserToken>> userTokens(int UserID)
        {
            return await this.context.UserTokens.Where(u => u.UserId == UserID).ToListAsync();
        }

        public void RemoveUserToken(int UserID)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (SqlCommand cmdRating = new("DeleteRecords", connection))
                {
                    cmdRating.CommandType = CommandType.StoredProcedure;
                    cmdRating.CommandTimeout = 120;

                    using (SqlDataAdapter adapter = new(cmdRating))
                    {
                        cmdRating.Parameters.AddWithValue("@Id ", Convert.ToInt64(UserID));
                        cmdRating.Parameters.AddWithValue("@Table ", "UserToken");
                        cmdRating.Parameters.AddWithValue("@Column ", "UserID");

                        try
                        {
                            DataSet ds = new();
                            adapter.Fill(ds);

                            cmdRating.ExecuteNonQuery();
                            connection.Close();

                        }
                        catch (Exception ex)
                        {
                            connection.Close();
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
