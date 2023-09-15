using CertificationTracker.Application.Common;
using CertificationTracker.Application.Contracts;
using CertificationTracker.Application.ServiceContract;
using CertificationTracker.Data.Settings;
using CertificationTracker.Infrastructure.Repositories.Account;
using CertificationTracker.Infrastructure.Repositories.ConfigurePOSTArea;
using CertificationTracker.Infrastructure.Repositories.CourseConfiguration;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Infrastructure.Repositories.Common
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly CertificationTrackerContext context;
        private bool _disposed;
        private IHttpContextAccessor httpContextAccessor;
        private ITokenService tokenService;

        public UnitOfWorks(CertificationTrackerContext context, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.tokenService = tokenService;
            User = new AccountRepository(this.context);
            CommonDetails = new CommonDetailsRepository(this.context);
            ConfigurePOSTAreas = new ConfigurePOSTAreasRepository(this.context, this.tokenService, this.httpContextAccessor);
            CourseConfigurationRepository = new CourseConfigurationRepository(this.context, this.tokenService, this.httpContextAccessor);
        }


        public IConfigurePOSTAreasRepository ConfigurePOSTAreas { get; set; }
        public async void Commit()
        {
            await this.context.SaveChangesAsync();
        }

        public IAccountRepository User
        {
            get; set;
        }
        public ICommonDetailsRepository CommonDetails { get; set; }

        public ICourseConfigurationRepository CourseConfigurationRepository { get; set; }

        public void Rollback()
        {
            foreach (var entry in this.context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        public IGenericRepositoryBase<T> GenericRepositoryBase<T>() where T : class
        {
            return new GenericRepositoryBase<T>(this.context);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();

                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
