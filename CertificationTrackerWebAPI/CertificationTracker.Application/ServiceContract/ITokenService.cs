using CertificationTracker.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.ServiceContract
{
    public interface ITokenService
    {
        string GenerateToken(List<Claim> Claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string Token);
    }
}
