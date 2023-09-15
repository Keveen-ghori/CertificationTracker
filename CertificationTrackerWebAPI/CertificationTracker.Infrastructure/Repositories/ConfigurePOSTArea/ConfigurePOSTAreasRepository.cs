using Azure.Core;
using CertificationTracker.Application.Contracts;
using CertificationTracker.Application.Dtos;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.ServiceContract;
using CertificationTracker.Core.Enums;
using CertificationTracker.Data.Models;
using CertificationTracker.Data.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Infrastructure.Repositories.ConfigurePOSTArea
{
    public class ConfigurePOSTAreasRepository : IConfigurePOSTAreasRepository
    {
        private readonly CertificationTrackerContext context;
        private readonly string connectionString = @"server = PCI101\SQL2019;Database=CertificationTracker;User Id = sa; Password=Tatva@123;Trusted_connection=False;Encrypt=False;TrustServerCertificate=True";
        private readonly ITokenService tokenService;
        private readonly IHttpContextAccessor httpContextAccessor;


        public ConfigurePOSTAreasRepository(CertificationTrackerContext context, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.tokenService = tokenService;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<POSTAreaDetail>> GetPOSTAreaDetail(bool IncludeArchived, int currentpage, int pagesize, string SortColumn, string SearchString, string ShortOrder)
        {
            List<POSTAreaDetail> postAreaDetailList = new();
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

                    using (SqlCommand cmdRating = new("GetPOSTAreaLists", connection))
                    {
                        cmdRating.CommandType = CommandType.StoredProcedure;
                        cmdRating.CommandTimeout = 120;

                        using (SqlDataAdapter adapter = new(cmdRating))
                        {
                            cmdRating.Parameters.AddWithValue("@IncludeArchived", IncludeArchived);
                            cmdRating.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                            cmdRating.Parameters.AddWithValue("@pageNumber", currentpage);
                            cmdRating.Parameters.AddWithValue("@pageSize", pagesize);
                            cmdRating.Parameters.AddWithValue("@SortColumn", SortColumn);
                            cmdRating.Parameters.AddWithValue("@Keyword", SearchString);
                            cmdRating.Parameters.AddWithValue("@ShortOrder", ShortOrder);

                            try
                            {
                                DataSet ds = new();
                                adapter.Fill(ds);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {
                                        POSTAreaDetail pOSTAreaDetail = new();

                                        pOSTAreaDetail.ArchivedLabel = row["ArchivedLabel"] == DBNull.Value ? "" : (string)row["ArchivedLabel"];
                                        pOSTAreaDetail.RequiredLabel = row["RequiredLabel"] == DBNull.Value ? "" : (string)row["RequiredLabel"];
                                        pOSTAreaDetail.IsRequired = row["IsRequired"] == DBNull.Value ? false : (bool)row["IsRequired"];
                                        pOSTAreaDetail.IsActive = row["IsActive"] == DBNull.Value ? false : (bool)row["IsActive"];
                                        pOSTAreaDetail.POSTAreaDescription = row["POSTAreaDescription"] == DBNull.Value ? "" : (string)row["POSTAreaDescription"];
                                        pOSTAreaDetail.POSTCurriculumAreaDescription = row["POSTCurriculumAreaDescription"] == DBNull.Value ? "" : (string)row["POSTCurriculumAreaDescription"];
                                        pOSTAreaDetail.POSTAreaName = row["POSTAreaName"] == DBNull.Value ? "" : (string)row["POSTAreaName"];
                                        pOSTAreaDetail.POSTCurriculumAreaName = row["POSTCurriculumAreaName"] == DBNull.Value ? "" : (string)row["POSTCurriculumAreaName"];
                                        pOSTAreaDetail.POSTAreaID = (decimal)row["POSTAreaID"];
                                        pOSTAreaDetail.POSTCurriculumAreaID = row["POSTCurriculumAreaID"] == DBNull.Value ? 0 : (decimal)row["POSTCurriculumAreaID"];
                                        pOSTAreaDetail.MandatedHours = row["MandatedHours"] == DBNull.Value ? 0 : (int)row["MandatedHours"];
                                        pOSTAreaDetail.TotalRecords = (int)row["TotalRecords"];
                                        postAreaDetailList.Add(pOSTAreaDetail);
                                    }

                                }
                                cmdRating.ExecuteNonQuery();
                                connection.Close();
                                return postAreaDetailList;

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
            return postAreaDetailList;
        }

        public async Task<List<PostcurriculumArea>> GetAllPostCurriculumArea()
        {
            return await this.context.PostcurriculumAreas.OrderBy(item => item.AddedOn).ToListAsync();
        }

        public async Task<List<POSTCoursesDetail>> GetPOSTCoursesDetails(int IncludeArchived, int currentpage, int pagesize, string SortColumn, string SearchString)
        {
            List<POSTCoursesDetail> postCourseDetailList = new();
            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
            int DepartmentID = Convert.ToInt32(principal.Claims
                    .Where(c => c.Type == "DepartmentID")
                    .Select(c => c.Value)
                    .FirstOrDefault());
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (SqlCommand cmdRating = new("POSTCourseDetailList", connection))
                {
                    cmdRating.CommandType = CommandType.StoredProcedure;
                    cmdRating.CommandTimeout = 120;

                    using (SqlDataAdapter adapter = new(cmdRating))
                    {
                        cmdRating.Parameters.AddWithValue("@IncludeArchived", IncludeArchived);
                        cmdRating.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        cmdRating.Parameters.AddWithValue("@PageNo", currentpage);
                        cmdRating.Parameters.AddWithValue("@PageSize", pagesize);
                        cmdRating.Parameters.AddWithValue("@SortColumn", SortColumn);
                        cmdRating.Parameters.AddWithValue("@SearchString", SearchString);
                        try
                        {
                            DataSet ds = new();
                            adapter.Fill(ds);
                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow row in ds.Tables[0].Rows)
                                {
                                    POSTCoursesDetail pOSTCourseDetail = new();

                                    pOSTCourseDetail.POSTCourseID = row["POSTCourseID"] == DBNull.Value ? 0 : (decimal)row["POSTCourseID"];
                                    pOSTCourseDetail.CourseHours = row["CourseHours"] == DBNull.Value ? 0 : (decimal)row["CourseHours"];
                                    pOSTCourseDetail.CourseTitle = row["CourseTitle"] == DBNull.Value ? "" : (string)row["CourseTitle"];
                                    pOSTCourseDetail.IsTrainingRecordAvailable = row["IsTrainingRecordAvailable"] == DBNull.Value
                                        ? false
                                        : (int)row["IsTrainingRecordAvailable"] == 1
                                            ? true
                                            : false;
                                    pOSTCourseDetail.CourseStartDate = (DateTime)row["CourseStartDate"];
                                    pOSTCourseDetail.POSTCourseAreas = row["POSTCourseAreas"] == DBNull.Value ? "" : (string)row["POSTCourseAreas"];
                                    pOSTCourseDetail.InsideInstructors = row["InsideInstructors"] == DBNull.Value ? "" : (string)row["InsideInstructors"];
                                    pOSTCourseDetail.OutSideInstructorDetail = row["OutSideInstructorDetail"] == DBNull.Value ? "" : (string)row["OutSideInstructorDetail"];
                                    pOSTCourseDetail.Employees = row["Employees"] == DBNull.Value ? "" : (string)row["Employees"];
                                    pOSTCourseDetail.Instructors = row["Instructors"] == DBNull.Value ? "" : (string)row["Instructors"];
                                    pOSTCourseDetail.IsCompletedCourse = row["IsCompletedCourse"] == DBNull.Value ? false : (bool)row["IsCompletedCourse"];
                                    pOSTCourseDetail.TotalRecordsCount = row["TotalRecordsCount"] == DBNull.Value ? 0 : (long)row["TotalRecordsCount"];

                                    postCourseDetailList.Add(pOSTCourseDetail);
                                }

                            }
                            connection.Close();
                            return postCourseDetailList;

                        }
                        catch (Exception)
                        {
                            connection.Close();
                            throw new Exception("Can't able to retrieve data.");
                        }
                    }
                }
            }
        }

        #region GetPostArea
        public async Task<Postarea> GetPostAreas(decimal POSTAreaID)
        {
            Postarea postAreaDetail = new Postarea();
            return await this.context.Postareas.Where(item => item.PostareaId == POSTAreaID).FirstOrDefaultAsync();
        }
        #endregion

        #region To check Duplicate Value while saving
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FieldValue">Value on which we want to check duplicate entry</param>
        /// <param name="FieldName">Enumeration of DuplicateValueEntity</param>
        /// <param name="FieldID">Primary key of that table that we can exclude for duplicate check</param>
        /// <param name="AnotherFieldID">Extra field of table that need to take in consideration</param>
        /// <returns></returns>
        public async Task<string> ValidateDuplicateValue(string FieldValue, DuplicateValueEntity FieldName, decimal FieldID = 0, decimal AnotherFieldID = 0, string AnotherField = "")
        {
            string validationMessage = "";
            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
            int DepartmentID = Convert.ToInt32(principal.Claims
                    .Where(c => c.Type == "DepartmentID")
                    .Select(c => c.Value)
                    .FirstOrDefault());
            if (FieldName == DuplicateValueEntity.POSTIDNumber)
            {
                List<Postemployee> employeeDetail = new List<Postemployee>();

                employeeDetail = this.context.Postemployees
                                            .Where(item =>
                                                item.Postidnumber == Convert.ToInt32(FieldValue) &&
                                                item.DepartmentEmployeeId == Convert.ToInt32(FieldID) &&
                                                item.DepartmentEmployee.Department.DepartmentId == DepartmentID)
                                            .ToList();
                if (employeeDetail != null && employeeDetail.Any())
                    validationMessage = "Error";
            }
            else if (FieldName == DuplicateValueEntity.POSTAreaName)
            {
                List<Postarea> areaDetail = new List<Postarea>();
                areaDetail = await this.context.Postareas.Where(item => item.Area == FieldValue && item.PostareaId != FieldID && item.AreaDescription == AnotherField && (item.DepartmentId == Convert.ToInt32(DepartmentID) || item.DepartmentId == null) && item.IsActive == true).ToListAsync();

                if (areaDetail != null && areaDetail.Any())
                    validationMessage = "Error";
            }
            else if (FieldName == DuplicateValueEntity.InstructorIDNumber)
            {
                List<Postinstructor> instructorDetail = new List<Postinstructor>();

                instructorDetail = await this.context.Postinstructors.Where(item => item.InstructorIdnumber == Convert.ToInt32(FieldValue) && item.PostinstructorId != FieldID && item.IsActive == true && item.DepartmentEmployeeId == item.DepartmentEmployee.DepartmentId).ToListAsync();
                if (instructorDetail != null && instructorDetail.Any())
                    validationMessage = "Error";
            }
            else if (FieldName == DuplicateValueEntity.CertificationAreaIDForInstructor)
            {
                List<PostinstructorCertifiedArea> certifiedArea = new List<PostinstructorCertifiedArea>();

                certifiedArea = await this.context.PostinstructorCertifiedAreas.Where(item => item.IsActive == true && item.PostareaId == Convert.ToInt32(FieldValue) && item.PostinstructorCertifiedAreaId == FieldID && item.PostinstructorId == AnotherFieldID).ToListAsync();

                if (certifiedArea != null && certifiedArea.Any())
                {
                    validationMessage = "Error";
                }
            }
            else if (FieldName == DuplicateValueEntity.POSTCourseAreas)
            {
                List<PostcourseArea> courseArea = new List<PostcourseArea>();

                courseArea = await this.context.PostcourseAreas.Where(item => item.PostareaId == Convert.ToDecimal(FieldValue) && item.PostcourseAreaId != FieldID && item.PostcourseId == AnotherFieldID).ToListAsync();

                if (courseArea != null && courseArea.Any())
                {
                    validationMessage = "Error";
                }
            }

            else if (FieldName == DuplicateValueEntity.POSTOutSideInstructor)
            {
                List<PostoutSideInstructor> outSideInstructorDetail = new List<PostoutSideInstructor>();

                outSideInstructorDetail = await this.context.PostoutSideInstructors.Where(item => item.InstructorName == FieldValue && item.PostoutSideInstructorId != FieldID && item.IsActive == true && item.DepartmentId == DepartmentID).ToListAsync();

                if (outSideInstructorDetail != null && outSideInstructorDetail.Count > 0)
                {
                    validationMessage = "Error";
                }
            }
            return validationMessage;
        }
        #endregion

        #region Save Area
        public async Task<decimal> SavePOSTAreaDetails(AreaDetails model)
        {
            decimal postAreaID = 0;
            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
            int DepartmentID = Convert.ToInt32(principal.Claims
                    .Where(c => c.Type == "DepartmentID")
                    .Select(c => c.Value)
                    .FirstOrDefault());
            string EmployeeName = Convert.ToString(principal.Claims
                    .Where(c => c.Type == "EmployeeName")
                    .Select(c => c.Value)
                    .FirstOrDefault());
            try
            {
                Postarea areaDetail = new Postarea();
                if (model.POSTAreaID > 0)
                {
                    areaDetail = await this.context.Postareas.Where(item => item.PostareaId == model.POSTAreaID).FirstAsync();
                    postAreaID = model.POSTAreaID;
                }
                areaDetail.Area = model.Area;
                areaDetail.AreaDescription = model.AreaDescription;
                areaDetail.DepartmentId = DepartmentID;
                areaDetail.IsActive = areaDetail != null && areaDetail.IsActive.HasValue ? areaDetail.IsActive.Value : true;
                areaDetail.EditedOn = DateTime.Now;
                areaDetail.EditedName = EmployeeName;

                if (model.POSTAreaID > 0)
                {
                    this.context.Entry(areaDetail).State = EntityState.Modified;

                    await this.context.SaveChangesAsync();
                }
                else
                {
                    areaDetail.AddedOn = DateTime.Now;
                    areaDetail.AddedName = EmployeeName;
                    await this.context.AddAsync(areaDetail);

                    await this.context.SaveChangesAsync();

                    postAreaID = areaDetail.PostareaId;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("TrainingCertificationManagementRepository - SavePOSTAreaDetails()", ex);
            }
            return postAreaID;
        }
        #endregion

        #region Post Area
        public async Task<List<AreaDetails>> GetPOSTAreas()
        {
            List<AreaDetails> lstPOSTArea = new List<AreaDetails>();

            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
            int DepartmentID = Convert.ToInt32(principal.Claims
                    .Where(c => c.Type == "DepartmentID")
                    .Select(c => c.Value)
                    .FirstOrDefault());
            try
            {

                lstPOSTArea = await this.context.Postareas
                                    .Where(item => item.IsActive == true && (item.DepartmentId == null || item.DepartmentId == DepartmentID))
                                    .OrderBy(item => item.Area)
                                    .Select(item => new AreaDetails
                                    {
                                        POSTAreaID = item.PostareaId,
                                        Area = item.Area == null ? "" : item.Area,
                                        AreaDescription = item.Area != null ? item.Area + " - " + item.AreaDescription : item.AreaDescription,

                                    })
                                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Training Certification Repository - GetPOSTAreas()", ex);
            }
            return lstPOSTArea;
        }
        #endregion

        public async Task<int> InstructorCertifiedAreaCount(decimal POSTAreaID)
        {
            int instructorCertifiedAreaCount = 0;
            List<PostinstructorCertifiedArea> instructorCertifiedAreasList = await this.context.PostinstructorCertifiedAreas.Where(item => item.PostareaId == POSTAreaID).ToListAsync();
            instructorCertifiedAreaCount = Convert.ToInt32(instructorCertifiedAreasList.Count());
            return instructorCertifiedAreaCount;
        }

        public async Task<int> InstructorCourseAreaCount(decimal POSTAreaID)
        {
            int instructorCourseAreaCount = 0;
            List<PostcourseArea> instructorCourseAreaAreasList = await this.context.PostcourseAreas.Where(item => item.PostareaId == POSTAreaID).ToListAsync();
            instructorCourseAreaCount = Convert.ToInt32(instructorCourseAreaAreasList.Count());
            return instructorCourseAreaCount;
        }

        public async Task<bool> DeletePOSTArea(decimal POSTAreaID)
        {
            bool success = false;
            string cookieValueFromContext = this.httpContextAccessor.HttpContext.Request.Cookies["Token"];
            var principal = this.tokenService.GetPrincipalFromExpiredToken(cookieValueFromContext);
            string DepartmentEmployeeName = principal.Claims
                    .Where(c => c.Type == "EmployeeName")
                    .Select(c => c.Value)
                    .FirstOrDefault();
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (SqlCommand cmdRating = new("DeletePOSTAReas", connection))
                {
                    cmdRating.CommandType = CommandType.StoredProcedure;
                    cmdRating.CommandTimeout = 120;

                    using (SqlDataAdapter adapter = new(cmdRating))
                    {
                        cmdRating.Parameters.AddWithValue("@POSTAReaID", POSTAreaID);
                        cmdRating.Parameters.AddWithValue("@ReportedEmployeeName", DepartmentEmployeeName);

                        try
                        {
                            DataSet ds = new();
                            adapter.Fill(ds);
                            cmdRating.ExecuteNonQuery();
                            connection.Close();
                            return true;

                        }
                        catch (Exception)
                        {
                            connection.Close();
                            throw new Exception("Can't able delete Area.");
                        }
                    }
                }
            }
        }
    }
}
