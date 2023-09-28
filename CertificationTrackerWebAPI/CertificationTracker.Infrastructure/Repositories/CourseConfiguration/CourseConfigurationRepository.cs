using CertificationTracker.Application.Contracts;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.Dtos.CourseConfiguration;
using CertificationTracker.Application.Dtos.DataItems;
using CertificationTracker.Application.ServiceContract;
using CertificationTracker.Data.Models;
using CertificationTracker.Data.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CertificationTracker.Infrastructure.Repositories.CourseConfiguration
{
    public class CourseConfigurationRepository : ICourseConfigurationRepository
    {
        private readonly CertificationTrackerContext context;
        private readonly string connectionString = @"server = PCI101\SQL2019;Database=CertificationTracker;User Id = sa; Password=Tatva@123;Trusted_connection=False;Encrypt=False;TrustServerCertificate=True";
        private readonly ITokenService tokenService;
        private readonly IHttpContextAccessor httpContextAccessor;


        public CourseConfigurationRepository(CertificationTrackerContext context, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.tokenService = tokenService;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<Postemployee>> allEmployeeDetail()
        {
            List<Postemployee> employees = new List<Postemployee>();
            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            if (cookieValueFromContext != null)
            {
                var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
                int DepartmentID = Convert.ToInt32(principal.Claims
                        .Where(c => c.Type == "DepartmentID")
                        .Select(c => c.Value)
                        .FirstOrDefault());
                employees = await this.context.Postemployees.Include(emp => emp.DepartmentEmployee)
                                    .Where(emp => emp.DepartmentEmployee.DepartmentId == DepartmentID && emp.DepartmentEmployee.IsActive == true)
                                    .OrderBy(emp => emp.DepartmentEmployee.LastName)
                                    .ToListAsync();
                return employees;
            }
            return employees;
        }

        public void DeletePostEmployeeCourse(decimal EmployeeID)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (SqlCommand cmdRating = new("DeleteRecords", connection))
                {
                    cmdRating.CommandType = CommandType.StoredProcedure;
                    cmdRating.CommandTimeout = 120;

                    using (SqlDataAdapter adapter = new(cmdRating))
                    {
                        cmdRating.Parameters.AddWithValue("@Id ", Convert.ToInt64(EmployeeID));
                        cmdRating.Parameters.AddWithValue("@Table ", "POSTEmployeeCourse");
                        cmdRating.Parameters.AddWithValue("@Column ", "POSTEmployeeCourseAreaId");

                        try
                        {
                            DataSet ds = new();
                            adapter.Fill(ds);

                            cmdRating.ExecuteNonQuery();
                            connection.Close();

                        }
                        catch (Exception ex)
                        {
                            connection.Close();
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }
        }

        public async Task<List<CloneCourseList>> GetCloneCourseList()
        {
            List<CloneCourseList> courseList = new();
            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            if (cookieValueFromContext != null)
            {
                var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
                int DepartmentID = Convert.ToInt32(principal.Claims
                        .Where(c => c.Type == "DepartmentID")
                        .Select(c => c.Value)
                        .FirstOrDefault());
                courseList = await this.context.Postcourses.Where(course => course.DepartmentId == DepartmentID && course.IsActive == true)
                                .OrderBy(course => course.CourseTitle)
                                .Select(course => new CloneCourseList
                                {
                                    CourseTitle = course.CourseTitle + (course.CourseStartDate != null ? " (" + course.CourseStartDate.Value.ToString("MM/dd/yyyy") + ")" : ""),
                                    PostCourseId = course.PostcourseId
                                })
                                .ToListAsync();

            }
            return courseList;
        }

        public async Task<Postcourse> GetCourseDetails(decimal POSTCourseID)
        {
            Postcourse postcourse = new Postcourse();
            postcourse = await this.context.Postcourses.Where(course => course.PostcourseId == POSTCourseID).FirstOrDefaultAsync();
            return postcourse;
        }

        public async Task<CourseForEditingDetails> GetEditingDetails(decimal POSTCourseID)
        {
            CourseForEditingDetails courseForEditingDetails = new CourseForEditingDetails();
            List<string> lstStudents = new List<string>();
            string errorMessage = string.Empty;
            bool isErrorOccurred = false;

            if (POSTCourseID > 0)
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmdRating = new("IsValidCourseForEditing", connection))
                    {
                        cmdRating.CommandType = CommandType.StoredProcedure;
                        cmdRating.CommandTimeout = 120;

                        using (SqlDataAdapter adapter = new(cmdRating))
                        {
                            cmdRating.Parameters.AddWithValue("@POSTCourseID", POSTCourseID);

                            try
                            {
                                DataSet ds = new();
                                adapter.Fill(ds);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {
                                        courseForEditingDetails.POSTCourseID = (int)row["POSTCourseID"];
                                        courseForEditingDetails.CourseName = row["CourseName"] == DBNull.Value ? "" : (string)row["CourseName"];
                                        courseForEditingDetails.Message = row["Message"] == DBNull.Value ? "" : (string)row["Message"];
                                        courseForEditingDetails.IsValidForEditing = row["IsValidForEditing"] == DBNull.Value ? false : (bool)row["IsValidForEditing"];
                                        courseForEditingDetails.IsAllFullEarnedCredits = row["IsAllFullEarnedCredits"] == DBNull.Value ? false : (bool)row["IsAllFullEarnedCredits"];
                                        string studentDetail = row["StudentDetail"] == DBNull.Value ? "" : (string)row["StudentDetail"];
                                        lstStudents.Add(studentDetail);
                                        courseForEditingDetails.IsErrorOccurred = row["IsErrorOccurred"] == DBNull.Value ? false : (bool)row["IsErrorOccurred"];
                                        isErrorOccurred = row["IsErrorOccurred"] == DBNull.Value ? false : (bool)row["IsErrorOccurred"];
                                        errorMessage = isErrorOccurred ? (row["Message"] == DBNull.Value ? "" : (string)row["Message"]) : "";
                                    }
                                    courseForEditingDetails.lstStudentName = lstStudents;

                                }
                                cmdRating.ExecuteNonQuery();
                                connection.Close();
                                return courseForEditingDetails;

                            }
                            catch (Exception ex)
                            {
                                connection.Close();
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                }
            }
            return courseForEditingDetails;
        }

        public async Task<List<Postcourse>> GetExistingCourses(string courseTitle, string courseStartDate, string courseEndDate, decimal postCourseID)
        {
            List<Postcourse> postcourses = new();
            postcourses = await this.context.Postcourses.Where(course => course.CourseTitle == courseTitle && course.CourseStartDate == Convert.ToDateTime(courseStartDate) && course.CourseEndDate == Convert.ToDateTime(courseEndDate) && course.PostcourseId != postCourseID && course.IsActive == true).ToListAsync();

            return postcourses;
        }

        public async Task<List<POSTApplicableAreaDetail>> GETPOSTApplicableAreaList(decimal POSTCourseID)
        {
            List<POSTApplicableAreaDetail> postApplicableAreaDetails = new();

            if (POSTCourseID > 0)
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmdRating = new("POSTApplicableAreaList", connection))
                    {
                        cmdRating.CommandType = CommandType.StoredProcedure;
                        cmdRating.CommandTimeout = 120;

                        using (SqlDataAdapter adapter = new(cmdRating))
                        {
                            cmdRating.Parameters.AddWithValue("@POSTCourseID", POSTCourseID);

                            try
                            {
                                DataSet ds = new();
                                adapter.Fill(ds);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {

                                        POSTApplicableAreaDetail applicableAreas = new POSTApplicableAreaDetail();

                                        applicableAreas.POSTAreaID = (decimal)row["POSTAreaID"];
                                        applicableAreas.POSTCourseAreaID = (decimal)row["POSTCourseAreaID"];
                                        applicableAreas.Instructors = row["Instructors"] == DBNull.Value ? "" : (string)row["Instructors"];
                                        applicableAreas.OutSideInstructors = row["OutSideInstructors"] == DBNull.Value ? "" : (string)row["OutSideInstructors"];

                                        if (!string.IsNullOrEmpty(applicableAreas.Instructors))
                                        {
                                            DataItems dataItems;
                                            XmlSerializer serializer = new XmlSerializer(typeof(DataItems));

                                            if (applicableAreas.Instructors != null)
                                            {
                                                using (StringReader reader = new StringReader(applicableAreas.Instructors!))
                                                {
                                                    dataItems = (DataItems)serializer.Deserialize(reader)!;
                                                }
                                                if (dataItems != null && dataItems.DataItem != null && dataItems.DataItem.Count > 0)
                                                    applicableAreas.Instructors = string.Join(", ", dataItems.DataItem.ToList().ConvertAll<string>(x => x.DisplayString).ToArray());

                                            }
                                        }

                                        applicableAreas.OutSideInstructors = row["OutSideInstructors"] == DBNull.Value ? "" : (string)row["OutSideInstructors"];

                                        if (!string.IsNullOrEmpty(applicableAreas.OutSideInstructors))
                                        {
                                            DataItems dataItems;
                                            XmlSerializer serializer = new XmlSerializer(typeof(DataItems));
                                            if (applicableAreas.OutSideInstructors != null)
                                            {
                                                using (StringReader reader = new StringReader(applicableAreas.OutSideInstructors!))
                                                {
                                                    dataItems = (DataItems)serializer.Deserialize(reader)!;
                                                }

                                                if (dataItems != null && dataItems.DataItem != null && dataItems.DataItem.Count > 0)
                                                    applicableAreas.OutSideInstructors = string.Join(", ", dataItems.DataItem.ToList().ConvertAll<string>(x => x.DisplayString).ToArray());
                                            }
                                        }

                                        applicableAreas.ApplicableAreas = row["ApplicableAreas"] == DBNull.Value ? "" : (string)row["ApplicableAreas"];
                                        applicableAreas.ApplicableGeneralAreas = row["ApplicableGeneralAreas"] == DBNull.Value ? "" : (string)row["ApplicableGeneralAreas"];
                                        applicableAreas.ApplicableGeneralAreasWithDescription = !string.IsNullOrWhiteSpace(row["ApplicableGeneralAreasWithDescription"] == DBNull.Value ? "" : (string)row["ApplicableGeneralAreasWithDescription"])
                                                       ? row["ApplicableGeneralAreasWithDescription"] == DBNull.Value ? "" : (string)row["ApplicableGeneralAreasWithDescription"]
                                                       : "No Curriculum Area";
                                        applicableAreas.Credits = row["Credits"] == DBNull.Value ? 0 : (decimal)row["Credits"];
                                        postApplicableAreaDetails.Add(applicableAreas);
                                    }

                                }
                                cmdRating.ExecuteNonQuery();
                                connection.Close();
                                return postApplicableAreaDetails;

                            }
                            catch (Exception ex)
                            {
                                connection.Close();
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                }
            }
            return postApplicableAreaDetails;
        }

        public async Task<List<POSTCoursesDetail>> GetPOSTCoursesDetails(ConfigureCourseFilterParams configureCourseFilterParams)
        {
            List<POSTCoursesDetail> postCoursesDetails = new();

            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            if (cookieValueFromContext != null)
            {
                var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
                int DepartmentID = Convert.ToInt32(principal.Claims
                        .Where(c => c.Type == "DepartmentID")
                        .Select(c => c.Value)
                        .FirstOrDefault());
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmdRating = new("POSTCourseDetailListsModifies", connection))
                    {
                        cmdRating.CommandType = CommandType.StoredProcedure;
                        cmdRating.CommandTimeout = 120;

                        using (SqlDataAdapter adapter = new(cmdRating))
                        {
                            cmdRating.Parameters.AddWithValue("@IncludeArchived", configureCourseFilterParams.includeArchived);
                            cmdRating.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                            cmdRating.Parameters.AddWithValue("@pageNumber", configureCourseFilterParams.pageNumber);
                            cmdRating.Parameters.AddWithValue("@PageSize", configureCourseFilterParams.pageSize);
                            cmdRating.Parameters.AddWithValue("@SortColumn", configureCourseFilterParams.ShortColumn);
                            cmdRating.Parameters.AddWithValue("@Keyword", configureCourseFilterParams.Keyword);
                            cmdRating.Parameters.AddWithValue("@ShortOrder", configureCourseFilterParams.ShortOrder);

                            try
                            {
                                DataSet ds = new();
                                adapter.Fill(ds);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {

                                        POSTCoursesDetail postCourseDetail = new();

                                        postCourseDetail.POSTCourseID = (decimal)row["POSTCourseID"];
                                        postCourseDetail.CourseTitle = row["CourseTitle"] == DBNull.Value ? "" : (string)row["CourseTitle"];
                                        postCourseDetail.CourseHours = row["CourseHours"] == DBNull.Value ? 0 : (decimal)row["CourseHours"];
                                        postCourseDetail.CourseStartDate = (DateTime)row["CourseStartDate"];
                                        postCourseDetail.Employees = row["Employees"] == DBNull.Value ? "" : (string)row["Employees"];
                                        postCourseDetail.IsCompletedCourse = row["IsCompletedCourse"] == DBNull.Value ? false : (bool)row["IsCompletedCourse"];
                                        postCourseDetail.InsideInstructors = row["InsideInstructors"] == DBNull.Value ? "" : (string)row["InsideInstructors"];
                                        postCourseDetail.OutSideInstructorDetail = row["OutSideInstructorDetail"] == DBNull.Value ? "" : (string)row["OutSideInstructorDetail"];
                                        postCourseDetail.POSTCourseAreas = row["POSTCourseAreas"] == DBNull.Value ? "" : (string)row["POSTCourseAreas"];
                                        postCourseDetail.Instructors = row["Instructors"] == DBNull.Value ? "" : (string)row["Instructors"];
                                        postCourseDetail.IsTrainingRecordAvailable = row["IsTrainingRecordAvailable"] == DBNull.Value
                                        ? false
                                        : (int)row["IsTrainingRecordAvailable"] == 1
                                            ? true
                                            : false;
                                        postCourseDetail.TotalRecordsCount = row["TotalRecords"] == DBNull.Value ? 0 : Convert.ToInt64(row["TotalRecords"]);


                                        postCoursesDetails.Add(postCourseDetail);
                                    }

                                }
                                cmdRating.ExecuteNonQuery();
                                connection.Close();
                                return postCoursesDetails;

                            }
                            catch (Exception ex)
                            {
                                connection.Close();
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                }
            }
            return postCoursesDetails;
        }

        public async Task<List<PostemployeeCourse>> GetPostemployeeCourse(string EmployeeID, decimal POSTCourseID)
        {
            List<PostemployeeCourse> postemployees = new();

            string[] employeeIdArray = EmployeeID.Split(',');

            int?[] departmentEmployeeIds = employeeIdArray.Select(int.Parse).Cast<int?>().ToArray();

            postemployees = await this.context.PostemployeeCourses.Where(course => !departmentEmployeeIds.Contains(course.DepartmentEmployeeId) && course.PostcourseId == POSTCourseID).ToListAsync();

            return postemployees;
        }

        public async Task<List<PostemployeeCourse>> GetPostEmployeeCourses(decimal POSTCourseID)
        {
            List<PostemployeeCourse> postEmployeeCourse = new();

            postEmployeeCourse = await this.context.PostemployeeCourses.Where(coursemp => coursemp.PostcourseId == POSTCourseID).ToListAsync();

            return postEmployeeCourse;
        }

        public async Task<List<PostemployeeCourse>> GetpostemployeeCoursesByDepartment(string DepartmentEmployeeID, decimal POSTCourseID)
        {
            List<PostemployeeCourse> postEmployeeCourse = new();
            postEmployeeCourse = await this.context.PostemployeeCourses.Where(course => course.DepartmentEmployeeId == Convert.ToInt32(DepartmentEmployeeID) && course.PostcourseId == POSTCourseID).ToListAsync();
            return postEmployeeCourse;

        }

        public async Task<List<PostcourseArea>> postcourseAreas(decimal postCourseID)
        {
            List<PostcourseArea> postcourseAreas = await this.context.PostcourseAreas.Where(course => course.PostcourseId == postCourseID).ToListAsync();

            return postcourseAreas;


        }

        public async Task<List<PostemployeeCourseArea>> PostemployeeCourseAreas(string postEmployeeCourseIDs)
        {
            List<PostemployeeCourseArea> postemployeeCourseAreas = new();

            string[] employeeIdArray = postEmployeeCourseIDs.Split(',');

            decimal?[] departmentEmployeeIds = employeeIdArray.Select(decimal.Parse).Cast<decimal?>().ToArray();

            postemployeeCourseAreas = await this.context.PostemployeeCourseAreas.Where(course => !departmentEmployeeIds.Contains(course.PostemployeeCourseId)).ToListAsync();

            return postemployeeCourseAreas;

        }

        public void SaveEmployeeAttendance(Postcourse course)
        {
            this.context.Postcourses.Update(course);
            this.context.SaveChanges();
        }

        public async Task<Postcourse> CreateCourse(Postcourse course)
        {
            EntityEntry<Postcourse> postcourse = await this.context.Postcourses.AddAsync(course);
            this.context.SaveChanges();

            return postcourse.Entity;

        }
        public void SaveEmployeeCourseArea(PostemployeeCourseArea postemployeeCourse)
        {
            this.context.PostemployeeCourseAreas.Add(postemployeeCourse);
            this.context.SaveChanges();
        }

        public async Task<PostemployeeCourse> SaveEmployeeCourseDetail(PostemployeeCourse employeeCourseDetail)
        {
            EntityEntry<PostemployeeCourse> postemployeeEntry = await this.context.AddAsync(employeeCourseDetail);
            await this.context.SaveChangesAsync();

            return postemployeeEntry.Entity;
        }

        public void CreateCourseArea(PostcourseArea postcourseArea)
        {
            this.context.PostcourseAreas.Add(postcourseArea);
            this.context.SaveChanges(true);
        }

        #region Post Inside Instructor
        public async Task<List<POSTInstructorsDto>> GetPostinstructors()
        {

            List<POSTInstructorsDto> postinstructors = await this.context.Postinstructors
                                    .Include(i => i.DepartmentEmployee)
                                    .OrderBy(i => i.DepartmentEmployee.FullName)
                                    .Select(i => new POSTInstructorsDto
                                    {
                                        POSTInstructorID = i.PostinstructorId,
                                        InstructorName = i.DepartmentEmployee.FullName + " (" + (i.InstructorIdnumber ?? 0).ToString() + ")",
                                        InstructorIDNumber = i.InstructorIdnumber
                                    })
                                    .ToListAsync();

            return postinstructors;
        }

        public async Task<List<POSTAreaListDetail>> GetPostAreas(int DepartmentID)
        {
            List<POSTAreaListDetail> postAreas = await this.context.Postareas
                .Where(area => area.IsActive == true && (area.DepartmentId == null || area.DepartmentId == DepartmentID))
                .OrderBy(area => area.Area)
                .Select(area => new POSTAreaListDetail
                {
                    POSTAreaID = area.PostareaId,
                    PostAreaName = area.Area != null ? area.Area + "-" + area.AreaDescription ?? "" : area.AreaDescription ?? ""
                })
                .ToListAsync();

            return postAreas;
        }

        public async Task<PostcourseArea> PostCourseArea(decimal POSTCourseAreaID)
        {
            PostcourseArea postCourseArea = await this.context.PostcourseAreas.Where(area => area.PostcourseAreaId == POSTCourseAreaID).FirstOrDefaultAsync();

            return postCourseArea;
        }

        public async Task<List<POSTInstructorsDto>> GetListOfPostinstructor(decimal? POSTAreaId, decimal POSTCourseID)
        {
            List<POSTInstructorsDto> postInstructors = await this.context.Postinstructors
                .Include(i => i.DepartmentEmployee)
                .Include(i => i.PostinstructorCertifiedAreas)
                .Where(i => i.PostinstructorCertifiedAreas
                            .Any(p => p.PostareaId == POSTAreaId) &&
                            i.IsActive == true &&
                            i.PostinstructorCertifiedAreas.All(p => p.IsActive == true) &&
                            i.CertifiedExpDate >= this.context.Postcourses
                                .Where(c => c.PostcourseId == POSTCourseID)
                                .Select(c => c.CourseEndDate)
                                .FirstOrDefault())
                .OrderBy(i => i.DepartmentEmployee.FullName)
                .Select(i => new POSTInstructorsDto
                {
                    POSTInstructorID = i.PostinstructorId,
                    InstructorName = i.DepartmentEmployee.FullName + " (" + (i.InstructorIdnumber ?? 0) + ")",
                    InstructorIDNumber = i.InstructorIdnumber
                })
                .ToListAsync();

            return postInstructors;
        }


        #endregion
    }
}
