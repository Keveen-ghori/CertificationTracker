using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.ServiceContract.ConfigurePOSTAreas
{
    public interface IConfigurePOSTAreasService
    {
        Task<CourseAreaConfiguration> GetCourseAreaConfiguration(bool IncludeArchived, int currentpage, int pagesize, string SortColumn, string SearchString, string ShortOrder);
        Task<AreaRequirements> GetCurriculumArea(string ControlType);
        Task<AreaDetails> AreaDetail(decimal POSTAreaID);
        Task<SavePostAreaDetailsResponse> PostAreaSave(AreaDetails AreaDetail);
        Task<bool> CheckApplicableAndCertifiedArea(decimal POSTAreaID);
        Task<bool> IsAreaDeleted(decimal POSTAreaID);
    }
}
