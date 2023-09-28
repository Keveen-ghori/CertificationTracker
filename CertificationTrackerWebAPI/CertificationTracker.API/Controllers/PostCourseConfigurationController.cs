using CertificationTracker.API.ResponseModel;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.Dtos.CourseConfiguration;
using CertificationTracker.Application.ServiceContract.CourseConfiguration;
using CertificationTracker.Core;
using CertificationTracker.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CertificationTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    public class PostCourseConfigurationController : ControllerBase
    {
        private readonly ICourseConfigureService courseConfigureService;

        public PostCourseConfigurationController(ICourseConfigureService courseConfigureService)
        {
            this.courseConfigureService = courseConfigureService;
        }

        #region Get Course Lists
        [HttpPost]
        [Route("GetCourseList")]
        public async Task<ApiResponse<List<POSTCoursesDetail>>> GetCourseList([FromBody] ConfigureCourseFilterParams configureCourseFilterParams)
        {
            var apiResponse = new ApiResponse<List<POSTCoursesDetail>>();

            try
            {
                List<POSTCoursesDetail> courseConfigurations = new();
                courseConfigurations = await this.courseConfigureService.CourseList(configureCourseFilterParams);
                return apiResponse.HandleResponse(courseConfigurations);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Clone Course Course Lists
        [HttpGet]
        [Route("GetCourseCloneLists")]
        public async Task<ApiResponse<List<CloneCourseList>>> GetCoursesForCloneList()
        {
            var apiResponse = new ApiResponse<List<CloneCourseList>>();
            try
            {
                List<CloneCourseList> courseList = new List<CloneCourseList>();
                courseList = await this.courseConfigureService.GetCourseCloneLists();
                return apiResponse.HandleResponse(courseList);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Course is valid for Editing
        [HttpGet]
        [Route("IsValidCourseForEditing")]
        public async Task<ApiResponse<CourseForEditingDetails>> IsValidCourseForEditing(decimal POSTCourseID)
        {
            var apiResponse = new ApiResponse<CourseForEditingDetails>();
            try
            {
                CourseForEditingDetails forEditingDetails = new CourseForEditingDetails();
                forEditingDetails = await this.courseConfigureService.courseForEditingDetails(POSTCourseID);

                return apiResponse.HandleResponse(forEditingDetails);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #endregion

        #region Course Details
        [HttpGet]
        [Route("CourseDetails")]
        public async Task<ApiResponse<CourseConfigurations>> CourseDetails(decimal POSTCourseID, decimal ClonePOSTCourseID = 0)
        {
            var apiResponse = new ApiResponse<CourseConfigurations>();
            try
            {
                CourseConfigurations courseConfiguration = new();

                courseConfiguration = await this.courseConfigureService.courseConfiguration(POSTCourseID, ClonePOSTCourseID);

                return apiResponse.HandleResponse(courseConfiguration);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region View Course Detail
        [HttpGet]
        [Route("ViewCourseDetails")]
        public async Task<ApiResponse<CourseConfigurations>> ViewCourseDetails(decimal POSTCourseID)
        {
            var apiResponse = new ApiResponse<CourseConfigurations>();
            try
            {
                CourseConfigurations courseConfiguration = new();
                courseConfiguration = await this.courseConfigureService.ViewCourseDetails(POSTCourseID);
                return apiResponse.HandleResponse(courseConfiguration);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #endregion

        #region Applicable Area Record
        [HttpGet]
        [Route("GetApplicableAreaRecord")]
        public async Task<ApiResponse<List<POSTApplicableAreaDetail>>> GetApplicableAreaRecord(decimal POSTCourseID)
        {
            var apiResponse = new ApiResponse<List<POSTApplicableAreaDetail>>();
            try
            {
                List<POSTApplicableAreaDetail> postApplicableAreaDetails = new();
                postApplicableAreaDetails = await this.courseConfigureService.GetApplicableAreaRecord(POSTCourseID);
                return apiResponse.HandleResponse(postApplicableAreaDetails);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Check Employees Deleted
        [HttpGet]
        [Route("CheckIfEmployeesDeleted")]
        public async Task<ApiResponse<bool>> CkeckIfEmployeesDeleted(decimal POSTCourseID)
        {
            var apiResponse = new ApiResponse<bool>();
            try
            {
                bool responseValue = false;
                responseValue = await this.courseConfigureService.IsEmployeesDeleted(POSTCourseID);
                return apiResponse.HandleResponse(responseValue);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Check Course is Already Exists
        [HttpGet]
        [Route("CheckCourseIsAlreadyExist")]
        public async Task<ApiResponse<CheckCourseIsAlreadyExistResponse>> CheckCourseIsAlreadyExist(string courseTitle, string courseStartDate, string courseEndDate, decimal postCourseID)
        {
            var apiResponse = new ApiResponse<CheckCourseIsAlreadyExistResponse>();
            try
            {
                CheckCourseIsAlreadyExistResponse checkCourseIsAlreadyExistResponse = new();

                checkCourseIsAlreadyExistResponse = await this.courseConfigureService.checkCourseIsAlreadyExist(courseTitle, courseStartDate, courseEndDate, postCourseID);

                return apiResponse.HandleResponse(checkCourseIsAlreadyExistResponse);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Confirm Training
        [HttpPost]
        [Route("ConfirmTraining")]
        public async Task<ApiResponse<bool>> ConfirmTraining(CourseTrainingDetail courseTrainingDetail)
        {
            var apiResponse = new ApiResponse<bool>();
            try
            {
                bool IsSaveSucess = false;
                IsSaveSucess = await this.courseConfigureService.SaveCourseWithEmployeeDetail(courseTrainingDetail);
                if (IsSaveSucess)
                {
                    this.courseConfigureService.AddDefaultInstructorTughtHour(courseTrainingDetail.POSTCourseID);   
                }
                return apiResponse.HandleResponse(IsSaveSucess);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Save Course Details
        [HttpPost]
        [Route("SavePOSTCourseDetails")]
        public async Task<ApiResponse<string>> SavePOSTCourseDetails(CourseConfigurations configurations)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                string postCourseID = string.Empty;
                
                postCourseID = await this.courseConfigureService.SaveCourseDetails(configurations);

                return apiResponse.HandleResponse(postCourseID);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #endregion

        #region Applicable Area Detail
        [HttpGet]
        [Route("ApplicableAreaDetail")]
        public async Task<ApiResponse<ApplicableAreas>> ApplicableAreaDetail(decimal POSTCourseAreaID, decimal POSTCourseID, decimal POSTAreaID = 0)
        {
            var apiResponse = new ApiResponse<ApplicableAreas>();
            try
            {
                ApplicableAreas applicableAreas = new();
                applicableAreas = await this.courseConfigureService.POSTApplicableAreas(POSTCourseAreaID, POSTCourseID, POSTAreaID);


                return apiResponse.HandleResponse(applicableAreas);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region CheckTrainingRecordAvailForEmployee
        [HttpGet]
        [Route("CheckTrainingRecordAvailForEmployee")]
        public async Task<ApiResponse<bool>> CheckTrainingRecordAvailForEmployee(decimal POSTCourseID)
        {   
            var apiResponse = new ApiResponse<bool>();
            try
            {
                bool returnValue = false;
                returnValue = await this.courseConfigureService.CheckTrainingRecordAvailForEmployee(POSTCourseID);
                return apiResponse.HandleResponse(returnValue);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }

        }
        #endregion

        #region ValidateCourseAtServer
        [HttpGet]
        [Route("ValidateCourseAtServer")]
        public async Task<ApiResponse<string>> ValidateCourseAtServer(decimal POSTCourseID)
        {
            var apiResponse = new ApiResponse<string>();
            try {
                string errorMessage = "";
                errorMessage = await this.courseConfigureService.ValidateCourseAtServer(POSTCourseID);
                return apiResponse.HandleResponse(errorMessage);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }

        }
        #endregion

        #region SaveCourseWithEmployeeDetail
        [HttpPost]
        [Route("SaveCourseWithEmployeeDetail")]
        public async Task<ApiResponse<bool>> SaveCourseWithEmployeeDetail(CourseTrainingDetail courseTrainingDetail)
        {
            var apiResponse = new ApiResponse<bool>();
            try
            {
                bool IsSaveSucess = false;
                IsSaveSucess = await this.courseConfigureService.SaveCourseWithEmployeeDetail(courseTrainingDetail);
                return apiResponse.HandleResponse(IsSaveSucess);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

    }
}
