using CertificationTracker.API.ResponseModel;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.ServiceContract.ConfigurePOSTAreas;
using CertificationTracker.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CertificationTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    public class ConfigurePOSTAreasController : ControllerBase
    {
        private readonly IConfigurePOSTAreasService configurePOSTAreasService;

        public ConfigurePOSTAreasController(IConfigurePOSTAreasService configurePOSTAreasService)
        {
            this.configurePOSTAreasService = configurePOSTAreasService;
        }

        [HttpGet]
        [Route("ConfigurePOSTAreas")]
        public async Task<ApiResponse<CourseAreaConfiguration>> ConfigurePOSTAreas(bool IncludeArchived = false, int pagesize = 10, int currentpage = 1, string? SortColumn = "", string? SearchString = "", string? ShortOrder = "")
        {
            var apiResponse = new ApiResponse<CourseAreaConfiguration>();
            try
            {
                CourseAreaConfiguration modelConfigureCourses = new();

                string cookieValueFromReq = Request.Cookies["Token"];

                modelConfigureCourses = await this.configurePOSTAreasService.GetCourseAreaConfiguration(IncludeArchived, currentpage, pagesize, SortColumn, SearchString, ShortOrder);

                return apiResponse.HandleResponse(modelConfigureCourses);

            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #region CurriculumAreaList
        [HttpGet]
        [Route("RequirementDetail/CurriculumAreaList")]
        public async Task<ApiResponse<AreaRequirements>> CurriculumAreaList(string ControlType)
        {
            var apiResponse = new ApiResponse<AreaRequirements>();
            try
            {
                AreaRequirements areaRequirements = new();

                areaRequirements = await this.configurePOSTAreasService.GetCurriculumArea(ControlType);

                return apiResponse.HandleResponse(areaRequirements);

            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region AreaDetails
        [HttpGet]
        [Route("POSTAreaDetails")]
        public async Task<ApiResponse<AreaDetails>> AreaDetails(decimal POSTAreaID)
        {
            var apiResponse = new ApiResponse<AreaDetails>();
            try
            {
                AreaDetails mdlAreaDetail = new AreaDetails();
                mdlAreaDetail = await this.configurePOSTAreasService.AreaDetail(POSTAreaID);
                return apiResponse.HandleResponse(mdlAreaDetail);

            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }

        }
        #endregion

        #region Save Area Details
        [HttpPost]
        [Route("SavePOSTAreaDetail")]
        public async Task<ApiResponse<SavePostAreaDetailsResponse>> SavePOSTAreaDetail(AreaDetails AreaDetail)
        {
            var apiResponse = new ApiResponse<SavePostAreaDetailsResponse>();
            try
            {
                SavePostAreaDetailsResponse model = new SavePostAreaDetailsResponse();
                model = await this.configurePOSTAreasService.PostAreaSave(AreaDetail);
                return apiResponse.HandleResponse(model);

            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion

        #region Delete POST Area
        [HttpGet]
        [Route("CheckApplicableAndCertifiedArea")]
        public async Task<ApiResponse<bool>> CheckApplicableAndCertifiedArea(decimal POSTAreaID)
        {
            var apiResponse = new ApiResponse<bool>();
            try
            {
                bool isRecordExist = await this.configurePOSTAreasService.CheckApplicableAndCertifiedArea(POSTAreaID);

                return apiResponse.HandleResponse(isRecordExist);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }

        #endregion

        #region Delete Post Area
        [HttpPost]
        [Route("DeletePOSTArea")]
        public async Task<ApiResponse<bool>> DeletePOSTArea(decimal POSTAreaID)
            {
            var apiResponse = new ApiResponse<bool>();
            bool success = false;
            try
            {
                if (POSTAreaID > 0)
                {
                    success = await this.configurePOSTAreasService.IsAreaDeleted(POSTAreaID);
                }
                return apiResponse.HandleResponse(success);
            }
            catch (Exception ex)
            {
                return apiResponse.HandleException(ex.Message);
            }
        }
        #endregion
    }
}
