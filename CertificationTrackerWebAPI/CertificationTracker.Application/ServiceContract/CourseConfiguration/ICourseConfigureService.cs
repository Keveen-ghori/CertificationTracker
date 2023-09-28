using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.Dtos.CourseConfiguration;
using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.ServiceContract.CourseConfiguration
{
    public interface ICourseConfigureService
    {
        Task<List<POSTCoursesDetail>> CourseList(ConfigureCourseFilterParams configureCourseFilterParams);
        Task<List<CloneCourseList>> GetCourseCloneLists();
        Task<CourseForEditingDetails> courseForEditingDetails(decimal POSTCourseID);
        Task<CourseConfigurations> courseConfiguration(decimal POSTCourseID, decimal ClonePOSTCourseID);
        Task<CourseConfigurations> ViewCourseDetails(decimal POSTCourseID);
        Task<List<POSTApplicableAreaDetail>> GetApplicableAreaRecord(decimal  POSTCourseID);
        Task<bool> IsEmployeesDeleted(decimal POSTCourseID);
        Task<CheckCourseIsAlreadyExistResponse> checkCourseIsAlreadyExist(string courseTitle, string courseStartDate, string courseEndDate, decimal postCourseID);
        Task<bool> SaveCourseWithEmployeeDetail(CourseTrainingDetail courseTrainingDetail);

        void AddDefaultInstructorTughtHour(decimal POSTCourseID);

        Task<string> SaveCourseDetails(CourseConfigurations configurations);
        Task<ApplicableAreas> POSTApplicableAreas(decimal POSTCourseAreaID, decimal POSTCourseID, decimal POSTAreaID = 0);
        Task<bool> CheckTrainingRecordAvailForEmployee(decimal POSTCourseID);
        Task<string> ValidateCourseAtServer(decimal POSTCourseID);
    }
}
