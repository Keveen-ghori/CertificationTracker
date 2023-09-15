using AutoMapper;
using CertificationTracker.Application.Common;
using CertificationTracker.Application.Dtos;
using CertificationTracker.Application.ServiceContract;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CertificationTracker.Data.Settings;

namespace CertificationTracker.Services.Common
{
    public class TokenService : ITokenService
    {

        public IConfiguration configuration;
        private readonly CertificationTrackerContext context;


        public TokenService(IConfiguration configuration, CertificationTrackerContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }
        #region Token
        public string GenerateRefreshToken()
        {

            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var RefreshToken = Convert.ToBase64String(tokenBytes);

            var tokenInUser = this.context.UserTokens.Any(a => a.RefreshToken == RefreshToken);

            if (tokenInUser)
            {
                return GenerateRefreshToken();
            }

            return RefreshToken;

        }

        public string GenerateToken(List<Claim> Claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JWT:Secret"]!));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    this.configuration["JWT:ValidIssuer"],
                    this.configuration["JWT:ValidAudience"],
                    Claims,
                    expires: DateTime.UtcNow.AddMinutes(5),
            signingCredentials: signIn);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string Token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JWT:Secret"])),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(Token, tokenValidationParameters, out securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }
        #endregion
    }
}
