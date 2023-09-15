using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Common
{
    public interface ICommonDetailsRepository
    {
        Task<List<SystemConfiguration>> Configuration(Expression<Func<SystemConfiguration, bool>> expression);
    }
}
