using CertificationTracker.Application.Common;
using CertificationTracker.Data.Models;
using CertificationTracker.Data.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Infrastructure.Repositories.Common
{
    public class CommonDetailsRepository : ICommonDetailsRepository
    {
        private readonly CertificationTrackerContext context;

        public CommonDetailsRepository(CertificationTrackerContext context)
        {
            this.context = context;
        }

        public async Task<List<SystemConfiguration>> Configuration(Expression<Func<SystemConfiguration, bool>> expression)
        {
            List<SystemConfiguration> systemConfigurations = await this.context.SystemConfigurations.Where(expression).ToListAsync();
            return systemConfigurations;
        }
    }
}
