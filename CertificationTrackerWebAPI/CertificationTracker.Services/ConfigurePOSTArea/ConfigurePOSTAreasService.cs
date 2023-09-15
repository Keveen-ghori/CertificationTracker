using CertificationTracker.Application.Common;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.ServiceContract.ConfigurePOSTAreas;
using CertificationTracker.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using CertificationTracker.Services.Common;
using CertificationTracker.Core.Enums;
using Azure.Core;

namespace CertificationTracker.Services.ConfigurePOSTArea
{
    public class ConfigurePOSTAreasService : IConfigurePOSTAreasService
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly setCookie cookie;

        public ConfigurePOSTAreasService(IUnitOfWorks unitOfWorks, setCookie cookie)
        {
            this.unitOfWorks = unitOfWorks;
            this.cookie = cookie;
        }
        public async Task<CourseAreaConfiguration> GetCourseAreaConfiguration(bool IncludeArchived, int currentpage, int pagesize, string SortColumn, string SearchString, string ShortOrder)
        {
            CourseAreaConfiguration modelConfigureCourses = new();

            List<POSTAreaDetail> pOSTAreaDetail = new();

            

            pOSTAreaDetail = await this.unitOfWorks.ConfigurePOSTAreas.GetPOSTAreaDetail(IncludeArchived, currentpage, pagesize, SortColumn, SearchString, ShortOrder);
            if (pOSTAreaDetail.Count > 0)
            {
                modelConfigureCourses.AreaDetailList = pOSTAreaDetail;

                //List<POSTCoursesDetail> pOSTCourses = new List<POSTCoursesDetail>();
                //pOSTCourses = await this.unitOfWorks.ConfigurePOSTAreas.GetPOSTCoursesDetails(IncludeArchived, currentpage, pagesize, SortColumn, SearchString);
                //modelConfigureCourses.CoursesDetailList = pOSTCourses;

                long totalRecordsCount = pOSTAreaDetail != null && pOSTAreaDetail.Any() ? pOSTAreaDetail.FirstOrDefault().TotalRecords : 0;
                #region Stroed value in session for print option
                //this.cookie.SetCookies("POSTCoursesIncludeArchived", IncludeArchived.ToString());
                //this.cookie.SetCookies("POSTCoursesSortColumn", SearchString);
                //this.cookie.SetCookies("POSTCoursesSearchString", SortColumn);
                //this.cookie.SetCookies("POSTCoursesShortOrder", ShortOrder);
                //this.cookie.SetCookies("POSTCoursesTotalRecordsCount", totalRecordsCount > 0 ? Convert.ToString(totalRecordsCount) : string.Empty);

                modelConfigureCourses.TotalRecordsCount = totalRecordsCount;
                #endregion
                return modelConfigureCourses;
            }
            else
            {
                throw new Exception("No Records Found...");
            }
        }

        public async Task<AreaRequirements> GetCurriculumArea(string ControlType)
        {
            AreaRequirements areaRequirements = new();

            List<PostcurriculumArea> pOSTCurriculumAreaList = new();
            pOSTCurriculumAreaList = await this.unitOfWorks.ConfigurePOSTAreas.GetAllPostCurriculumArea();
            areaRequirements.POSTCurriculumAreaList = pOSTCurriculumAreaList;
            areaRequirements.IsGeneralAreaList = false;
            if (ControlType == "GeneralArea")
            {
                areaRequirements.IsGeneralAreaList = true;
                List<PostcurriculumArea> areaList = new List<PostcurriculumArea>();
                areaList = areaRequirements.POSTCurriculumAreaList;
                if (areaList != null)
                {
                    areaRequirements.TotalMaximumHours = Convert.ToInt32(areaList.Sum(x => x.MaximumHours)).ToString();
                    areaRequirements.TotalMandatedHours = Convert.ToInt32(areaList.Sum(x => x.MandatedHours)).ToString();
                }
                return areaRequirements;
            }

            return areaRequirements;
        }

        #region AreaDetails
        public async Task<AreaDetails> AreaDetail(decimal POSTAreaID)
        {
            AreaDetails areaDetail = new AreaDetails();
            if (POSTAreaID > 0)
            {
                Postarea postAreaDetail = new Postarea();
                postAreaDetail = await this.unitOfWorks.ConfigurePOSTAreas.GetPostAreas(POSTAreaID);
                if (postAreaDetail != null)
                {
                    areaDetail.POSTAreaID = POSTAreaID;
                    areaDetail.Area = postAreaDetail.Area;
                    areaDetail.AreaDescription = postAreaDetail.AreaDescription;
                }
            }
            return areaDetail;
        }
        #endregion

        #region Save Area details
        public async Task<SavePostAreaDetailsResponse> PostAreaSave(AreaDetails AreaDetail)
        {
            SavePostAreaDetailsResponse savePostAreaDetailsResponse = new();

            string validationMessage = string.Empty;
            decimal createdAreaId = 0;
            List<AreaDetails> lstAreas = new List<AreaDetails>();

            validationMessage = await this.unitOfWorks.ConfigurePOSTAreas.ValidateDuplicateValue(AreaDetail.Area, DuplicateValueEntity.POSTAreaName, AreaDetail.POSTAreaID, 0, AreaDetail.AreaDescription.Trim());
            savePostAreaDetailsResponse.validationMessage = validationMessage;
            if (string.IsNullOrEmpty(validationMessage))
            {
                createdAreaId = await this.unitOfWorks.ConfigurePOSTAreas.SavePOSTAreaDetails(AreaDetail);
                lstAreas = await this.unitOfWorks.ConfigurePOSTAreas.GetPOSTAreas();
            }
            savePostAreaDetailsResponse.PostArea = lstAreas;
            savePostAreaDetailsResponse.SelectedArea = createdAreaId;
            return savePostAreaDetailsResponse;
        }
        #endregion

        #region
        public async Task<bool> CheckApplicableAndCertifiedArea(decimal POSTAreaID)
        {
            bool isRecordExist = false;

            int instructorCertifiedAreaCount = 0;
            instructorCertifiedAreaCount = await this.unitOfWorks.ConfigurePOSTAreas.InstructorCertifiedAreaCount(POSTAreaID);
            if (instructorCertifiedAreaCount > 0)
                isRecordExist = true;

            int instructorCourseAreaCount = 0;
            instructorCourseAreaCount = await this.unitOfWorks.ConfigurePOSTAreas.InstructorCourseAreaCount(POSTAreaID);
            if (instructorCourseAreaCount > 0)
                isRecordExist = true;

            return isRecordExist;
        }
        #endregion

        #region Delete Area
        public async Task<bool> IsAreaDeleted(decimal POSTAreaID)
        {
            bool success = false;
            success = await this.unitOfWorks.ConfigurePOSTAreas.DeletePOSTArea(POSTAreaID);
            return success;
        }
        #endregion
    }
}
