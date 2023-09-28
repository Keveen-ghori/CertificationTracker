using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CertificationTracker.Core.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace CertificationTracker.Core
{
    public class TokenManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IConfiguration configuration;


        public TokenManager(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            this.configuration = configuration;
        }

        public string GetValue(string cookieName)
        {
            var value = _httpContextAccessor.HttpContext.Request.Cookies[cookieName];
            return value;
        }

        public TokenValueFromCookie TokenValue()
        {
            TokenValueFromCookie tokenValueFromCookie = new();
            var token = _httpContextAccessor.HttpContext.Request.Cookies["Token"];

            if (token != null)
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JWT:Secret"]!));
                var tokenHandler = new JwtSecurityTokenHandler();

                try
                {
                    var claimsPrincipal = tokenHandler.ValidateToken(token,
                        new TokenValidationParameters
                        {
                            IssuerSigningKey = key,
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidAudience = this.configuration["JWT:ValidAudience"],
                            ValidIssuer = this.configuration["JWT:ValidIssuer"],
                        }, out var securityToken);

                    if (securityToken is JwtSecurityToken jwtSecurityToken)
                    {
                        tokenValueFromCookie.UserID = Convert.ToInt64(jwtSecurityToken.Payload["UserID"]);
                        tokenValueFromCookie.DepartmentID = Convert.ToInt32(jwtSecurityToken.Payload["DepartmentID"]);
                        tokenValueFromCookie.EmployeeName = jwtSecurityToken.Payload["EmployeeName"].ToString();
                        tokenValueFromCookie.DepartmentEmployeeID = Convert.ToInt64(jwtSecurityToken.Payload["DepartmentEmployeeID"]);
                        tokenValueFromCookie.DepartmentName = jwtSecurityToken.Payload["DepartmentName"].ToString();
                        tokenValueFromCookie.AgencyID = Convert.ToInt64(jwtSecurityToken.Payload["AgencyID"]);
                        tokenValueFromCookie.UserName = jwtSecurityToken.Payload["UserName"].ToString();
                    }

                    return tokenValueFromCookie;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return tokenValueFromCookie;
        }


    }
}
