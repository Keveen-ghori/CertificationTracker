using CertificationTracker.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Common
{
    public interface IUnitOfWorks : IDisposable
    {
        void Commit();
        void Rollback();
        IGenericRepositoryBase<T> GenericRepositoryBase<T>() where T : class;
        IAccountRepository User { get; set; }
        ICommonDetailsRepository CommonDetails { get; set; }
        IConfigurePOSTAreasRepository ConfigurePOSTAreas { get; set; }
        ICourseConfigurationRepository CourseConfigurationRepository { get; set; }



    }
}
