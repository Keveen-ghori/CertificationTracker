using Azure;
using Azure.Core;
using CertificationTracker.API.ResponseModel;
using CertificationTracker.Application.Dtos;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.ServiceContract;
using CertificationTracker.Data.Models;
using CertificationTracker.Services.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Reflection;
using System.Security.Claims;


namespace CertificationTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("EnableCORS")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationServices authService;
        private readonly IAuthenticationSchemeProvider schemeProvider;
        private static readonly HashSet<string> BlacklistedTokens = new HashSet<string>();



        public readonly IConfiguration configuration;
        private readonly ITokenService tokenService;


        public AccountController(IAuthenticationServices authService, IConfiguration configuration, ITokenService tokenService, IAuthenticationSchemeProvider schemeProvider)
        {
            this.authService = authService;
            this.configuration = configuration;
            this.tokenService = tokenService;
            this.schemeProvider = schemeProvider;

        }

        #region Project Configuration
        [HttpGet]
        [Route("Configuration")]
        public async Task<ApiResponse<ConfigurationSettings>> Configuration()
        {
            var apiResponse = new ApiResponse<ConfigurationSettings>();
            try
            {
                ConfigurationSettings configurationSettings = new();
                if (this.configuration["Configuration:IsInMaintenanceMode"] != null && this.configuration["Configuration:IsInMaintenanceMode"]?.ToString().ToLower() == "true")
                {
                    configurationSettings.IsInMaintenanceMode = true;
                    return apiResponse.HandleResponse(configurationSettings);
                }
                else
                {
                    string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CertificationTracker.API.dll");


                    Assembly assembly = Assembly.LoadFrom(assemblyPath);

                    configurationSettings = await this.authService.Configuration(assembly);
                    configurationSettings.Title = this.configuration["Configuration:ApplicationTitle"]!.ToString();
                    return apiResponse.HandleResponse(configurationSettings);
                }
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #endregion


        #region Login
        [HttpPost]
        [Route("Login")]
        public async Task<ApiResponse<TokenDto>> AuthorizeUser(LoginDto model)
        {
            var apiResponse = new ApiResponse<TokenDto>();
            try
            {
                if (model.UserName != "" && model.Password != "")
                {
                    UserAuthorization authorization = await this.authService.UserAuthentication(model.UserName, model.Password, HttpContext.Connection.RemoteIpAddress.ToString(), HttpContext.Request.Headers["User-Agent"].ToString(), System.Environment.MachineName.ToString());

                    if (authorization != null && authorization.IsAccessAllow)
                    {
                        if (authorization.AuthorizedUserInfo.PasswordExpiry != null && authorization.AuthorizedUserInfo.PasswordExpiry != DateTime.MinValue && authorization.AuthorizedUserInfo.PasswordExpiry < DateTime.Now)
                        {
                            throw new Exception("Your credential is expired. you need to ask administrator to reset the period.");
                        }
                        else
                        {
                            setTokenCookie(authorization.JwtAccessToken, authorization.RefreshToken, authorization.JWTRefreshTokenExpirationTime);
                            return apiResponse.HandleResponse(new TokenDto
                            {
                                AccessToken = authorization.JwtAccessToken,
                                RefreshToken = authorization.RefreshToken
                            });
                        }

                    }

                    else if (authorization != null && !authorization.IsAccessAllow &&
                        !string.IsNullOrEmpty(authorization.TrainingCertificationUserErrorMessage))
                    {
                        throw new Exception(authorization.TrainingCertificationUserErrorMessage);
                    }
                    else

                        throw new Exception("User name and password didn't match! Please enter valid Credentials.");


                }
                else
                {
                    if (model.UserName == "" && model.Password == "")
                    {
                        throw new Exception("User name and Password could not be null!");
                    }
                    else if (model.UserName == "")
                    {
                        throw new Exception("Username is required!");
                    }
                    else
                        throw new Exception("Password is required!");
                }
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Get Token
        [HttpGet]
        [Route("Token")]
        public async Task<ApiResponse<IEnumerable<string>>> Get()
        {
            var apiResponse = new ApiResponse<IEnumerable<string>>();

            try
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");

                return apiResponse.HandleResponse(new string[] { accessToken! });
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion


        #region Refresh Token
        [HttpPost]
        [Route("RefreshToken")]
        public async Task<ApiResponse<TokenDto>> Refresh(TokenDto tokenApiModel)
        {
            var apiResponse = new ApiResponse<TokenDto>();

            try
            {
                if (tokenApiModel is null)
                    return apiResponse.HandleException("Invalid client request");
                string accessToken = tokenApiModel.AccessToken;
                string refreshToken = tokenApiModel.RefreshToken;
                var principal = this.tokenService.GetPrincipalFromExpiredToken(accessToken);
                var username = principal.Identity.Name;
                var user = await this.authService.UserByUserName(username);
                if (user is null || user.RefreshTokenExpiry <= DateTime.Now)
                    return apiResponse.HandleException("Invalid client request. Token has been expired.");

                User principleUser = new();
                principleUser = await this.authService.GetUser(user.UserId);

                var claims = new List<Claim>
                                            {
                                                new Claim(JwtRegisteredClaimNames.Sub, this.configuration["JWT:Subject"]!),
                                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                                                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                                                new Claim("UserID", user.UserId.ToString()),
                                                new Claim("DepartmentID", principleUser.DepartmentId.ToString()),
                                                new Claim("EmployeeName", principleUser.DepartmentEmployee?.FullName),
                                                new Claim("DepartmentEmployeeID", principleUser.DepartmentEmployeeId.ToString()),
                                                new Claim("DepartmentName", principleUser.Department?.Name.ToString()),
                                                new Claim("AgencyID", principleUser.AgencyId.ToString()),
                                                new Claim(ClaimTypes.Name, principleUser.UserName),
                                                new Claim("UserName", principleUser.UserName)
                                            };

                var newAccessToken = this.tokenService.GenerateToken(claims);
                var newRefreshToken = this.tokenService.GenerateRefreshToken();
                user.RefreshToken = newRefreshToken;

                this.authService.UpdateUserToken(user);

                setTokenCookie(newAccessToken, newRefreshToken, user.RefreshTokenExpiry);
                return apiResponse.HandleResponse(new TokenDto
                {
                    AccessToken = newAccessToken,
                    RefreshToken = newRefreshToken
                });
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }

        }
        #endregion


        [HttpGet]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme, Roles = "Department Administrator, System Administrator")]
        public IActionResult Message()
        {
            return Ok("You have successfully logged in To the System...");
        }

        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Revoke(string userName)
        {
            var user = await this.authService.UserByUserName(userName);

            if (user == null) return BadRequest("Invalid user name");

            var authSchemes = await this.schemeProvider.GetAllSchemesAsync();
            var tokenId = User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti)?.Value;


            if (tokenId != null)
            {
                this.authService.RemoveToken(user.UserId);
                lock (BlacklistedTokens)
                {
                    BlacklistedTokens.Add(tokenId);
                }
            }


            DeleteCookie();
            return NoContent();
        }

        [HttpGet("User")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ApiResponse<TokenDto>> GetCurrentUser()
        {
            var apiResponse = new ApiResponse<TokenDto>();

            try
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                var token = new JwtSecurityToken(jwtEncodedString: accessToken);
                string refreshToken;
                Request.Cookies.TryGetValue("RefreshToken", out refreshToken);
                return apiResponse.HandleResponse(new TokenDto
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken
                });
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #region Set Cookies
        private void setTokenCookie(string token, string refreshToken, DateTime? JWTRefreshTokenExpirationTime)
        {

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddMinutes(20)
            };
            var principal = this.tokenService.GetPrincipalFromExpiredToken(token);
            var roles = principal.Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value)
                    .ToList();

            Response.Cookies.Append("Token", token, new CookieOptions
            {
                HttpOnly = false,
                SameSite = SameSiteMode.None,
                Secure = true,
            });
            Response.Cookies.Append("RefreshToken", refreshToken, new CookieOptions
            {
                HttpOnly = false,
                SameSite = SameSiteMode.None,
                Secure = true,
            });
            Response.Cookies.Append("RefreshTokenExpirationTime", JWTRefreshTokenExpirationTime.ToString(), new CookieOptions
            {
                HttpOnly = false,
                SameSite = SameSiteMode.None,
                Secure = true,
            });
            for (int i = 0; i < roles.Count; i++)
            {
                Response.Cookies.Append($"Role{i}", roles[i], new CookieOptions
                {
                    HttpOnly = false,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                });
            }

        }
        #endregion

        #region Remove From cookie
        private void DeleteCookie()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
        }
        #endregion


        #region Department Logo
        [HttpGet]
        [Route("DepartmentLogo")]
        [OutputCache(Duration = 21600, VaryByQueryKeys = new[] { "DepartmentID" })]
        public async Task<ApiResponse<string>> DepartmentLogo(string DepartmentID)
        {
            string tokenValue = "";
            Request.Cookies.TryGetValue("Token", out tokenValue);

            var apiResponse = new ApiResponse<string>();

            try
            {
                string Path = await this.authService.DepartmentLogo(DepartmentID, tokenValue);
                return apiResponse.HandleResponse(Path);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion


        private bool IsTokenBlacklisted(string tokenId)
        {
            lock (BlacklistedTokens)
            {
                return BlacklistedTokens.Contains(tokenId);
            }
        }
    }
}
