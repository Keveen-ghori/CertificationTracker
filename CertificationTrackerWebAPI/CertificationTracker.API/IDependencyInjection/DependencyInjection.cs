using CertificationTracker.Application.Common;
using CertificationTracker.Application.ServiceContract;
using CertificationTracker.Application.ServiceContract.ConfigurePOSTAreas;
using CertificationTracker.Application.ServiceContract.CourseConfiguration;
using CertificationTracker.Core;
using CertificationTracker.Core.Constants;
using CertificationTracker.Data.Settings;
using CertificationTracker.Infrastructure.Repositories.Common;
using CertificationTracker.Services.Account;
using CertificationTracker.Services.Common;
using CertificationTracker.Services.ConfigurePOSTArea;
using CertificationTracker.Services.CourseConfiguration;
using CertificationTracker.Services.ProfileMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Threading.RateLimiting;

namespace CertificationTracker.API.IDependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {

            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();

            services.AddTransient<IUnitOfWorks, UnitOfWorks>();

            services.AddScoped<IAuthenticationServices, AuthenticationService>();
            services.AddScoped<IConfigurePOSTAreasService, ConfigurePOSTAreasService>();
            services.AddScoped<ICourseConfigureService, CourseConfigureService>();
            services.AddScoped<setCookie>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<TokenManager>();
            services.AddScoped<ConvertToXML>();

            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });
                options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme {
                    Reference = new Microsoft.OpenApi.Models.OpenApiReference {
                        Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                            Id = "Bearer"
                    }
                },
                new string[] {}
        }
    });
            });

            services.AddHttpContextAccessor();

            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {

                    builder.WithOrigins("http://localhost:4200")
                       .AllowAnyHeader()
                       .AllowAnyMethod()
                       .AllowCredentials();

                });
            });
            //builder.AllowAnyOrigin()
            //.AllowAnyHeader()
            //.AllowAnyMethod();


            services.AddAutoMapper(typeof(MappingProfile));

            services.AddApiVersioning(x =>
            {
                x.DefaultApiVersion = new ApiVersion(1, 0);
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
            });

            //services.AddRateLimiter(options =>
            //{
            //    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
            //    {
            //        return RateLimitPartition.GetFixedWindowLimiter(partitionKey: httpContext.Request.Headers.Host.ToString(), partition =>
            //            new FixedWindowRateLimiterOptions
            //            {
            //                PermitLimit = 30,
            //                AutoReplenishment = true,
            //                Window = TimeSpan.FromSeconds(10)
            //            });
            //    });

            //    options.OnRejected = async (context, token) =>
            //    {
            //        context.HttpContext.Response.StatusCode = 429;
            //        await context.HttpContext.Response.WriteAsync("Too many requests. Please try later again... ", cancellationToken: token);
            //    };
            //});

            services.AddAuthorization();

            return services;
        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<CertificationTrackerContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureAppMiddleware(this IApplicationBuilder app)
        {
            app.UseCors("EnableCORS");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseRateLimiter();
        }

    }
}
