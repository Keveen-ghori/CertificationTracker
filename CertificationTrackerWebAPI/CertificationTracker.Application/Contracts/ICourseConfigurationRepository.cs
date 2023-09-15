using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.Dtos.CourseConfiguration;
using CertificationTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Contracts
{
    public interface ICourseConfigurationRepository
    {
        Task<List<POSTCoursesDetail>> GetPOSTCoursesDetails(ConfigureCourseFilterParams configureCourseFilterParams);
        Task<List<CloneCourseList>> GetCloneCourseList();
        Task<CourseForEditingDetails> GetEditingDetails(decimal POSTCourseID);
        Task<Postcourse> GetCourseDetails(decimal POSTCourseID);

        Task<List<POSTApplicableAreaDetail>> GETPOSTApplicableAreaList(decimal POSTCourseID);
        Task<List<Postemployee>> allEmployeeDetail();
        Task<List<PostemployeeCourse>> GetPostEmployeeCourses(decimal POSTCourseID);
        Task<List<Postcourse>> GetExistingCourses(string courseTitle, string courseStartDate, string courseEndDate, decimal postCourseID);
        void SaveEmployeeAttendance(Postcourse course);

        Task<List<PostemployeeCourse>> GetPostemployeeCourse(string EmployeeID, decimal POSTCourseID);

        Task<List<PostemployeeCourseArea>> PostemployeeCourseAreas(string postEmployeeCourseIDs);

        Task<List<PostemployeeCourse>> GetpostemployeeCoursesByDepartment(string DepartmentEmployeeID, decimal POSTCourseID);

        Task<PostemployeeCourse> SaveEmployeeCourseDetail(PostemployeeCourse employeeCourseDetail);

        Task<List<PostcourseArea>> postcourseAreas(decimal postCourseID);
        void SaveEmployeeCourseArea(PostemployeeCourseArea postemployeeCourse);
        void DeletePostEmployeeCourse(decimal EmployeeID);

        Task<Postcourse> CreateCourse(Postcourse course);
        void CreateCourseArea(PostcourseArea postcourseArea);
    } 
}
