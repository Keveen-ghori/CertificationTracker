using AutoMapper;
using CertificationTracker.Application.BusinessEntity;
using CertificationTracker.Application.Common;
using CertificationTracker.Application.Dtos;
using CertificationTracker.Application.ServiceContract;
using CertificationTracker.Core.Enums;
using CertificationTracker.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using CertificationTracker.Services.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using Newtonsoft.Json.Linq;
using System.Web;

namespace CertificationTracker.Services.Account
{
    public class AuthenticationService : IAuthenticationServices
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;
        public IConfiguration configuration;
        private readonly ITokenService tokenService;
        private readonly IHttpContextAccessor httpContextAccessor;


        public AuthenticationService(IUnitOfWorks unitOfWorks, IMapper mapper, IConfiguration configuration, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWorks = unitOfWorks;
            this.mapper = mapper;
            this.configuration = configuration;
            this.tokenService = tokenService;
            this.httpContextAccessor = httpContextAccessor;
        }

        #region Configuration
        public async Task<ConfigurationSettings> Configuration(Assembly assembly)
        {
            ConfigurationSettings configuration = new();
            Version ver = assembly.GetName().Version!;

            configuration.Version = string.Format("{0}.{1}.{2}", ver.Major, ver.Minor, ver.Build);
            configuration.PublishedDate = File.GetLastWriteTime(assembly.Location).ToShortDateString();

            AssemblyCopyrightAttribute copyRight = (AssemblyCopyrightAttribute)assembly.GetCustomAttribute(typeof(AssemblyCopyrightAttribute))!;
            configuration.CopyRight = copyRight.Copyright + " Version Published on " + System.IO.File.GetLastWriteTime(assembly.Location).ToString("MM/dd/yyyy");

            List<SystemConfiguration> systemConfiguration = await this.unitOfWorks.CommonDetails.Configuration(item => item.ConfigurationName == "KTISAnnouncement");

            if (systemConfiguration != null && systemConfiguration.Any())
            {
                SystemConfiguration? announcement = systemConfiguration.FirstOrDefault();
                configuration.AnnouncementText = announcement.ConfigurationValue;
            }

            return configuration;
        }
        #endregion


        #region UserAuthentication
        /// <summary>
        /// UserAuthentication
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns>UserAuthorization</returns>
        public async Task<UserAuthorization> UserAuthentication(string UserName, string Password, string? IP, string Browser, string MachineInformation)
        {
            UserAuthorization returnObj = new();

            DateTime StartTime = DateTime.Now;
            TimeSpan Timediff;

            returnObj.IsAccessAllow = false;
            returnObj.TrainingCertificationUserErrorMessage = string.Empty;
            string employeeName = string.Empty;

            try
            {
                List<User> users = await this.unitOfWorks.User.Login(UserName, Password);

                if (users == null || !users.Any())
                {
                    throw new Exception("User Not Found!");
                }
                else
                {
                    User? user = users.FirstOrDefault();
                    if (CertificationTracker.Services.Common.PasswordHash.ValidatePassword(Password, user?.SecurePassword!))
                    {
                        returnObj.AuthorizedUserInfo = user!;
                        returnObj.AgencyName = ((user?.Agency != null) ? user.Agency.Name : string.Empty)!;
                        returnObj.Department = user?.Department!;
                        returnObj.EmployeeInfo = user?.DepartmentEmployee!;

                        XmlDocument xmldoc = new XmlDocument();

                        xmldoc.LoadXml(user.Department.DepartmentAttributesXml);

                        XmlNode nodeObj = xmldoc.SelectSingleNode("/Attributes/Attribute[Name='IsRepInProgressShowAll']");

                        returnObj.IsRepInProgressShowAll = Convert.ToBoolean(nodeObj.SelectSingleNode("Value").InnerText);

                        List<DepOrgEmployee> tempUserOrg = await this.unitOfWorks.User.UserOrg(user.DepartmentEmployeeId);
                        if (tempUserOrg != null && tempUserOrg.Count > 0)
                        {
                            returnObj.IsManagedOtherEmployees = true;
                        }
                        else
                        {
                            returnObj.IsManagedOtherEmployees = false;
                        }

                        #region Get User Security Role
                        List<SecurityRoleToUser> UserRoleObj = await this.unitOfWorks.User.UserSecurityRoles(user.UserId);
                        List<SecurityRole> UserSecurityRoleObj = await this.unitOfWorks.User.UserRoles();

                        UserRoleObj = UserRoleObj ?? new List<SecurityRoleToUser>();

                        foreach (var obj in UserRoleObj)
                        {
                            var matchingSecurityRole = UserSecurityRoleObj.FirstOrDefault(x => x.SecurityRoleId == obj.SecurityRoleId);
                            if (matchingSecurityRole != null)
                            {
                                obj.SecurityRole.RoleName = matchingSecurityRole.RoleName;
                                obj.SecurityRole.IsSupportWidgetAccessible = Convert.ToBoolean(matchingSecurityRole.IsSupportWidgetAccessible);
                            }
                        }

                        returnObj.AuthorizedSecurityRoles = UserRoleObj;
                        #endregion



                        //#region Get User Interface Definition Items
                        //List<UserInterfaceDefinitionItem> lstUserInterfaceDefinitionItem = await this.unitOfWorks.User.GetUserInterfaceDefinitionItems(user.UserId);
                        //returnObj.LSTUserInterfaceDefinitionItem = lstUserInterfaceDefinitionItem;
                        //#endregion

                        #region Create User Access Trace Information

                        #region JWT Token

                        string allSecurityRoles = string.Join(",", UserRoleObj.Select(role => role.SecurityRole.RoleName));


                        var claims = new List<Claim>
                                            {
                                                new Claim(JwtRegisteredClaimNames.Sub, this.configuration["JWT:Subject"]!),
                                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                                                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                                                new Claim("UserID", user.UserId.ToString()),
                                                new Claim("DepartmentID", user.DepartmentId.ToString()),
                                                new Claim("EmployeeName", user.DepartmentEmployee?.FullName),
                                                new Claim("DepartmentEmployeeID", user.DepartmentEmployeeId.ToString()),
                                                new Claim("DepartmentName", user.Department?.Name.ToString()),
                                                new Claim("AgencyID", user.AgencyId.ToString()),
                                                new Claim(ClaimTypes.Name, user.UserName),
                                                new Claim("UserName", user.UserName)
                                            };

                        foreach (var item in UserRoleObj)
                        {
                            returnObj.Role.Add(item.SecurityRole.RoleName);
                            claims.Add(new Claim(ClaimTypes.Role, item.SecurityRole.RoleName));
                        }

                        var token = this.tokenService.GenerateToken(claims);

                        var refreshToken = this.tokenService.GenerateRefreshToken();

                        TokenDto applicationUserTokenDto = new();
                        applicationUserTokenDto.RefreshToken =refreshToken;
                        applicationUserTokenDto.AccessToken = token;

                        #endregion

                        returnObj.JwtAccessToken = token;
                        returnObj.RefreshToken = refreshToken;
                        returnObj.JWTRefreshTokenExpirationTime = DateTime.Now.AddDays(20);

                        UserToken userToken = new();
                        userToken.UserId = user.UserId;
                        userToken.AddedOn = DateTime.Now;
                        userToken.Token = Guid.NewGuid();
                        userToken.RefreshToken = refreshToken;
                        userToken.Expired = false;
                        userToken.RefreshTokenExpiry = DateTime.Now.AddDays(1);

                        List<UserToken> GetUserToken = await this.unitOfWorks.User.userTokens(user.UserId);
                        if (!GetUserToken.Any())
                        {
                            this.unitOfWorks.User.SaveTokenValue(userToken);
                        }
                        else
                        {
                            this.unitOfWorks.User.UpdateTokenValue(userToken);
                        }

                        returnObj.IsAccessAllow = true;
                        #endregion

                        #region Set IsTrainingCertificationMode
                        List<SystemConfiguration> lstSystemConfiguration = await this.unitOfWorks.CommonDetails.Configuration(item => item.ConfigurationName == "IsTrainingCertificationMode" && item.Category == "DepartmentAccess");
                        if (lstSystemConfiguration != null && lstSystemConfiguration.Any())
                        {
                            returnObj.IsTrainingCertificationMode = Convert.ToBoolean(lstSystemConfiguration.FirstOrDefault().ConfigurationValue);
                            if (returnObj.IsTrainingCertificationMode)
                            {
                                if (UserRoleObj == null || (UserRoleObj != null && !UserRoleObj.Any(x => x.SecurityRoleId == (int)SecurityRolesForUser.DepartmentAdministrator ||
                                x.SecurityRoleId == (int)SecurityRolesForUser.SystemAdministrator || x.SecurityRoleId == (int)SecurityRolesForUser.Training ||
                                x.SecurityRoleId == (int)SecurityRolesForUser.TrainingConfiguration || x.SecurityRoleId == (int)SecurityRolesForUser.TrainingManagement)))
                                {
                                    returnObj.IsAccessAllow = false;
                                    returnObj.TrainingCertificationUserErrorMessage = "Sorry, you can't access. You need to ask administrator to get permission.";
                                }
                            }
                        }
                        #endregion
                        Timediff = DateTime.Now.Subtract(StartTime);
                    }
                    else
                    {
                        throw new Exception("Data not found");
                    }
                }
            }
            catch (Exception ex)
            {
                returnObj.IsAccessAllow = false;
                throw new Exception(ex.Message);
            }

            return returnObj;
        }

        #endregion

        public async Task<UserToken> UserByUserName(string UserName)
        {
            User user = await this.unitOfWorks.User.GetUser(u => u.UserName == UserName);
            UserToken userToken = new();
            if (user != null)
            {
                userToken = await this.unitOfWorks.User.GetUserToken(u => u.UserId == user.UserId);
            }
            return userToken;
        }

        public async Task<List<User>> UserLists()
        {
            return await this.unitOfWorks.User.GetUserLists();
        }

        public async Task<string> DepartmentLogo(string Department, string tokenValue)
        {
            if (tokenValue != null)
            {
                var token = new JwtSecurityToken(jwtEncodedString: tokenValue);
                List<SysImage> lstSysImages = await this.unitOfWorks.User.GetImageLists(Convert.ToDecimal(Department));

                if (lstSysImages != null && lstSysImages.Count > 0 && lstSysImages[0].ImageData != null)
                {
                    if (lstSysImages[0].ImageData != null)
                    {
                        return lstSysImages[0].ImageData.ToString();
                    }
                    else
                        return Convert.ToString("NoImageSelected.jpg");
                }
                else
                    return Convert.ToString("~/images/NoImageSelected.jpg");
            }
            else
            {
                string fullName = "";
                decimal authorizedAccessId = 0;
                if (tokenValue != null)
                {
                    var token = new JwtSecurityToken(jwtEncodedString: tokenValue);
                    fullName = token.Claims.First(c => c.Type == "EmployeeName").Value;
                }

                List<SystemConfiguration> lstSysConfig = await this.unitOfWorks.User.systemConfigurations();

                if (lstSysConfig != null && lstSysConfig.Count > 0 && !string.IsNullOrEmpty(lstSysConfig[0].ConfigurationValue))
                    return lstSysConfig[0].ConfigurationValue;
                else
                    return "~/images/NoImageSelected.jpg";
            }
        }

        public void UpdateUserToken(UserToken userToken)
        {
            this.unitOfWorks.User.UpdateTokenValue(userToken);
        }

        public async Task<User> GetUser(int UserID)
        {
            return await this.unitOfWorks.User.GetUserForRefreshToken(u => u.UserId == UserID);
        }

        public void RemoveToken(int UserID)
        {
            this.unitOfWorks.User.RemoveUserToken(UserID);
        }

    }

}

