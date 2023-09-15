using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Core.Enums;
using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Contracts
{
    public interface IConfigurePOSTAreasRepository
    {
        Task<List<POSTAreaDetail>> GetPOSTAreaDetail(bool IncludeArchived,int currentpage, int pagesize, string SortColumn, string SearchString, string ShortOrder);
        Task<List<PostcurriculumArea>> GetAllPostCurriculumArea();
        Task<List<POSTCoursesDetail>> GetPOSTCoursesDetails(int IncludeArchived, int currentpage, int pagesize, string SortColumn, string SearchString);
        Task<Postarea> GetPostAreas(decimal POSTAreaID);

        Task<string> ValidateDuplicateValue(string FieldValue, DuplicateValueEntity FieldName, decimal FieldID = 0, decimal AnotherFieldID = 0, string AnotherField = "");

        Task<decimal> SavePOSTAreaDetails(AreaDetails model);
        Task<List<AreaDetails>> GetPOSTAreas();

        Task<int> InstructorCertifiedAreaCount(decimal POSTAreaID);
        Task<int> InstructorCourseAreaCount(decimal POSTAreaID);
        Task<bool> DeletePOSTArea(decimal POSTAreaID);
    }
}
