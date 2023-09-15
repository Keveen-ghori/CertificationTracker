using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CertificationTracker.Services.Common
{
    public class setCookie
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public setCookie(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetCookies(string Name, string value)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };

            _httpContextAccessor.HttpContext.Response.Cookies.Append(Name, value, cookieOptions);
        }
    }
}
