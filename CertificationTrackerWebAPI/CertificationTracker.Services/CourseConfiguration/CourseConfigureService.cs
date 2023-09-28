using CertificationTracker.Application.Common;
using CertificationTracker.Application.Dtos.ConfigurePOSTAreas;
using CertificationTracker.Application.Dtos.CourseConfiguration;
using CertificationTracker.Application.Dtos.DataItems;
using CertificationTracker.Application.ServiceContract.CourseConfiguration;
using CertificationTracker.Core;
using CertificationTracker.Core.Constants;
using CertificationTracker.Data.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CertificationTracker.Services.CourseConfiguration
{
    public class CourseConfigureService : ICourseConfigureService
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly TokenManager tokenManager;
        private readonly ConvertToXML convertToXML;

        public CourseConfigureService(IUnitOfWorks unitOfWorks, TokenManager tokenManager, ConvertToXML convertToXML)
        {
            this.unitOfWorks = unitOfWorks;
            this.tokenManager = tokenManager;
            this.convertToXML = convertToXML;
        }

        #region Add Default Instructor Hour
        public async void AddDefaultInstructorTughtHour(decimal POSTCourseID)
        {
            try
            {
                Postcourse courseRecord = new Postcourse();
                TokenValueFromCookie tokenValueFromCookie = this.tokenManager.TokenValue();


                courseRecord = await this.unitOfWorks.CourseConfigurationRepository.GetCourseDetails(POSTCourseID);
                if (courseRecord != null)
                {
                    courseRecord.IsCompletedCourse = true;
                    courseRecord.EditedName = tokenValueFromCookie.EmployeeName;
                    courseRecord.EditedOn = DateTime.Now;
                    this.unitOfWorks.CourseConfigurationRepository.SaveEmployeeAttendance(courseRecord);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region AllInsideInstructors
        public async Task<ApplicableAreas> POSTApplicableAreas(decimal POSTCourseAreaID, decimal POSTCourseID, decimal POSTAreaID = 0)
        {
            ApplicableAreas applicableAreas = new ApplicableAreas();

            TokenValueFromCookie tokenValueFromCookie = this.tokenManager.TokenValue();

            List<POSTInstructorsDto> postinstructors = await this.unitOfWorks.CourseConfigurationRepository.GetPostinstructors();
            List<POSTInstructorsDto> lstAreaInsideInstructors = new();
            applicableAreas.lstAllInsideInstructors = postinstructors;

            applicableAreas.POSTCourseID = POSTCourseID;

            applicableAreas.lstArea = await this.unitOfWorks.CourseConfigurationRepository.GetPostAreas(tokenValueFromCookie.DepartmentID);

            if (POSTCourseAreaID > 0)
            {
                PostcourseArea courseArea = new PostcourseArea();
                courseArea = await this.unitOfWorks.CourseConfigurationRepository.PostCourseArea(POSTCourseAreaID);

                if (courseArea != null)
                {
                    applicableAreas.POSTCourseAreaID = courseArea.PostcourseAreaId;
                    applicableAreas.AreaNameID = Convert.ToInt32(courseArea.PostareaId);

                    //Inside Instructors
                    applicableAreas.IncludeAllInstructors = false;
                    lstAreaInsideInstructors = await this.unitOfWorks.CourseConfigurationRepository.GetListOfPostinstructor(courseArea.PostareaId, POSTCourseID);
                    applicableAreas.lstInsideInstructors = lstAreaInsideInstructors;
                    applicableAreas.lstAreaInsideInstructors = lstAreaInsideInstructors;

                    if (!string.IsNullOrWhiteSpace(courseArea.PostinstructorDetail))
                    {
                        DataItems dataItems = new DataItems();
                        XmlSerializer serializer = new XmlSerializer(typeof(DataItems));
                        if (courseArea.PostinstructorDetail != null)
                        {
                            using (StringReader reader = new StringReader(courseArea.PostinstructorDetail!))
                            {
                                dataItems = (DataItems)serializer.Deserialize(reader)!;
                            }

                            if (dataItems != null && dataItems.DataItem != null)
                            {
                                applicableAreas.InsideInstructorsDetail = "[" + string.Join(",", dataItems.DataItem.ToList().Select(p => "{value:'" + p.PKID + "'}")) + "]";

                                bool isAllInstructorsInList = true;
                                foreach (var item in dataItems.DataItem)
                                {
                                    if (applicableAreas.lstInsideInstructors.Count == 0 ||
                                        (applicableAreas.lstInsideInstructors.Count > 0 && !applicableAreas.lstInsideInstructors.Any(x => x.POSTInstructorID == Convert.ToDecimal(item.PKID))))
                                    {
                                        isAllInstructorsInList = false;
                                    }
                                }

                                if (!isAllInstructorsInList)
                                {
                                    applicableAreas.IncludeAllInstructors = true;
                                    applicableAreas.lstInsideInstructors = postinstructors;
                                }
                            }
                        }
                    }

                    //Outside Instructors
                    if (!string.IsNullOrWhiteSpace(courseArea.PostoutSideInstructorDetail))
                    {
                        DataItems dataItems = new DataItems();
                        XmlSerializer serializer = new XmlSerializer(typeof(DataItems));
                        if (courseArea.PostoutSideInstructorDetail != null)
                        {
                            using (StringReader reader = new StringReader(courseArea.PostoutSideInstructorDetail!))
                            {
                                dataItems = (DataItems)serializer.Deserialize(reader)!;
                            }

                            if (dataItems != null && dataItems.DataItem != null)
                                applicableAreas.OutSideInstructorsDetail = "[" + string.Join(",", dataItems.DataItem.ToList().Select(p => "{value:'" + p.PKID + "'}")) + "]";
                        }
                    }
                    applicableAreas.Credit = courseArea.AreaCredits;
                }
            }
            return applicableAreas;

        }
        #endregion

        #region checkCourseIsAlreadyExist
        public async Task<CheckCourseIsAlreadyExistResponse> checkCourseIsAlreadyExist(string courseTitle, string courseStartDate, string courseEndDate, decimal postCourseID)
        {
            CheckCourseIsAlreadyExistResponse checkCourseIsAlready = new();

            List<Postcourse> lstPOSTCourses = new();

            lstPOSTCourses = await this.unitOfWorks.CourseConfigurationRepository.GetExistingCourses(courseTitle, courseStartDate, courseEndDate, postCourseID);

            if (lstPOSTCourses != null && lstPOSTCourses.Any())
            {
                checkCourseIsAlready.courseIsAlreadyExist = true;
                checkCourseIsAlready.errorMessage = "Course name and dates are the same as an existing course. Please change the name or dates to avoid confusion.";
            }

            checkCourseIsAlready.courseIsAlreadyExist = false;
            checkCourseIsAlready.errorMessage = "";
            return checkCourseIsAlready;
        }

        #endregion

        #region courseConfiguration
        public async Task<CourseConfigurations> courseConfiguration(decimal POSTCourseID, decimal ClonePOSTCourseID)
        {
            CourseConfigurations courseConfigurations = new();

            decimal postNewCourseID = 0;
            if (POSTCourseID > 0)
                postNewCourseID = POSTCourseID;
            else if (ClonePOSTCourseID > 0)
                postNewCourseID = ClonePOSTCourseID;

            courseConfigurations.lstEmployees = new List<DataItemType>();

            Postcourse courseDetail = new Postcourse();
            if (postNewCourseID > 0)
            {
                courseDetail = await this.unitOfWorks.CourseConfigurationRepository.GetCourseDetails(postNewCourseID);

                if (courseDetail != null)
                {
                    courseConfigurations.POSTCourseID = ClonePOSTCourseID > 0 ? 0 : postNewCourseID;
                    courseConfigurations.CourseTitle = ClonePOSTCourseID > 0 ? courseDetail.CourseTitle + " Clone" : courseDetail.CourseTitle;
                    courseConfigurations.Sponsor = courseDetail.Sponsor;
                    if (courseDetail.CourseStartDate != DateTime.MinValue && ClonePOSTCourseID == 0)
                        courseConfigurations.StartDate = courseDetail.CourseStartDate;
                    if (courseDetail.CourseEndDate != DateTime.MinValue && ClonePOSTCourseID == 0)
                        courseConfigurations.EndDate = courseDetail.CourseEndDate;
                    courseConfigurations.CourseHours = courseDetail.CourseHours;
                    courseConfigurations.CourseFee = courseDetail.CourseFee;
                    if (courseDetail.OutOfDepartment != null && courseDetail.OutOfDepartment.HasValue)
                        courseConfigurations.InSideLocation = courseDetail.OutOfDepartment == false ? true : false;
                    courseConfigurations.State = courseDetail.State;
                    courseConfigurations.City = courseDetail.City;
                    courseConfigurations.Zip = courseDetail.Zip;
                    courseConfigurations.Street = courseDetail.Street;
                    courseConfigurations.AddressName = courseDetail.AddressName;
                    courseConfigurations.Comment = courseDetail.Comments;
                    courseConfigurations.AttendanceHours = courseDetail.AttendenceHours;
                    courseConfigurations.MainCourseIDOfClone = ClonePOSTCourseID > 0 ? Convert.ToInt32(ClonePOSTCourseID) : 0;

                    if (POSTCourseID > 0)
                    {
                        //get Employee
                        DataItems dataItems;
                        XmlSerializer serializer = new XmlSerializer(typeof(DataItems));
                        if (courseDetail.DepartmentEmployeeXml != null)
                        {
                            using (StringReader reader = new StringReader(courseDetail.DepartmentEmployeeXml!))
                            {
                                dataItems = (DataItems)serializer.Deserialize(reader)!;
                            }
                            if (dataItems != null && dataItems.DataItem != null)
                            {
                                courseConfigurations.EmployeeDetail = "[" + string.Join(",", dataItems.DataItem.ToList().Select(p => "{value:'" + p.PKID + "'}")) + "]";
                                courseConfigurations.ListSelectedEmployee = dataItems.DataItem.Select(x => x.Value).ToArray();
                                courseConfigurations.ListEmployee = dataItems.DataItem.Select(x => int.Parse(x.Value)).ToArray();
                            }
                        }
                    }
                }
            }

            //Get Applicable areas 
            List<POSTApplicableAreaDetail> applicableAreas = new List<POSTApplicableAreaDetail>();
            applicableAreas = await this.unitOfWorks.CourseConfigurationRepository.GETPOSTApplicableAreaList(postNewCourseID);
            if (applicableAreas != null && applicableAreas.Any())
                courseConfigurations.POSTApplicableAreaDetails = applicableAreas;
            else
                courseConfigurations.POSTApplicableAreaDetails = new List<POSTApplicableAreaDetail>();

            ////Get Employees
            List<Postemployee> allEmployeeDetail = new List<Postemployee>();
            allEmployeeDetail = await this.unitOfWorks.CourseConfigurationRepository.allEmployeeDetail();

            if (allEmployeeDetail != null && allEmployeeDetail.Any())
            {
                allEmployeeDetail.ForEach(x =>
                    courseConfigurations.lstEmployees.Add(new DataItemType()
                    {
                        PKID = Convert.ToInt32(x.PostemployeeId),
                        DisplayString = x.DepartmentEmployee.FullName,
                        Value = Convert.ToString(x.DepartmentEmployeeId),
                        Table = "POSTEmployee"
                    })
                );
            }

            return courseConfigurations;
        }
        #endregion

        #region courseForEditingDetails
        public async Task<CourseForEditingDetails> courseForEditingDetails(decimal POSTCourseID)
        {
            CourseForEditingDetails courseForEditingDetails = new();
            courseForEditingDetails = await this.unitOfWorks.CourseConfigurationRepository.GetEditingDetails(POSTCourseID);

            return courseForEditingDetails;
        }
        #endregion

        #region CourseList
        public async Task<List<POSTCoursesDetail>> CourseList(ConfigureCourseFilterParams configureCourseFilterParams)
        {
            List<POSTCoursesDetail> courseLists = new();

            courseLists = await this.unitOfWorks.CourseConfigurationRepository.GetPOSTCoursesDetails(configureCourseFilterParams);
            return courseLists;
        }

        #endregion

        #region GetApplicableAreaRecord
        public async Task<List<POSTApplicableAreaDetail>> GetApplicableAreaRecord(decimal POSTCourseID)
        {
            List<POSTApplicableAreaDetail> postApplicableAreaDetails = new();

            postApplicableAreaDetails = await this.unitOfWorks.CourseConfigurationRepository.GETPOSTApplicableAreaList(POSTCourseID);

            return postApplicableAreaDetails;
        }
        #endregion

        #region GetCourseCloneLists

        public async Task<List<CloneCourseList>> GetCourseCloneLists()
        {
            List<CloneCourseList> course = new();
            course = await this.unitOfWorks.CourseConfigurationRepository.GetCloneCourseList();
            return course;
        }
        #endregion

        #region IsEmployeesDeleted
        public async Task<bool> IsEmployeesDeleted(decimal POSTCourseID)
        {
            List<PostemployeeCourse> postEmployeeCourse = new();

            postEmployeeCourse = await this.unitOfWorks.CourseConfigurationRepository.GetPostEmployeeCourses(POSTCourseID);

            if (postEmployeeCourse != null && postEmployeeCourse.Any())
            {
                return true;
            }
            return false;
        }
        #endregion

        #region SaveCourseDetails
        public async Task<string> SaveCourseDetails(CourseConfigurations configurations)
        {
            decimal POSTCourseID = 0;

            Postcourse courseDetail = new Postcourse();

            TokenValueFromCookie tokenValueFromCookie = this.tokenManager.TokenValue();

            if (configurations.POSTCourseID > 0)
            {
                POSTCourseID = configurations.POSTCourseID;
                courseDetail = await this.unitOfWorks.CourseConfigurationRepository.GetCourseDetails(POSTCourseID);
            }

            courseDetail.DepartmentId = tokenValueFromCookie.DepartmentID;
            courseDetail.CourseTitle = configurations.CourseTitle;
            courseDetail.Sponsor = configurations.Sponsor;
            courseDetail.CourseStartDate = configurations.StartDate != null ? configurations.StartDate.Value : DateTime.MinValue;
            courseDetail.CourseFee = Convert.ToDecimal(configurations.CourseFee);
            courseDetail.IsActive = courseDetail != null && courseDetail.IsActive.HasValue ? courseDetail.IsActive : true;
            if (configurations.InSideLocation != null && configurations.InSideLocation.HasValue)
                courseDetail.OutOfDepartment = configurations.InSideLocation.Value ? false : true;
            courseDetail.AddressName = configurations.AddressName;
            courseDetail.Street = configurations.Street;
            courseDetail.City = configurations.City;
            courseDetail.State = configurations.State;
            courseDetail.Zip = configurations.Zip;
            courseDetail.Comments = configurations.Comment;
            courseDetail.CourseHours = configurations.CourseHours;
            courseDetail.CourseEndDate = configurations.EndDate != null ? configurations.EndDate.Value : DateTime.MinValue;
            courseDetail.EditedName = tokenValueFromCookie.EmployeeName;
            courseDetail.EditedOn = DateTime.Now;

            //Employee
            if (configurations.EmployeeDetail != null)
            {
                DataItems dataItemsForNewEmployee = new DataItems();
                dataItemsForNewEmployee.DataItem = JsonConvert.DeserializeObject<List<DataItem>>(configurations.EmployeeDetail);

                courseDetail.DepartmentEmployeeXml = dataItemsForNewEmployee.DataItem.Any() ? this.convertToXML.ConvertedXML(dataItemsForNewEmployee) : string.Empty;

                string deletedEmployees = null;
                if (dataItemsForNewEmployee != null && dataItemsForNewEmployee.DataItem != null && dataItemsForNewEmployee.DataItem.Any())
                {
                    deletedEmployees = string.Join(",", dataItemsForNewEmployee.DataItem.Select(x => x.Value));
                }

                if (!string.IsNullOrEmpty(deletedEmployees))
                {
                    List<PostemployeeCourse> postEmployeeCourse = await this.unitOfWorks.CourseConfigurationRepository.GetPostemployeeCourse(deletedEmployees, POSTCourseID);
                    if (postEmployeeCourse != null && postEmployeeCourse.Any())
                    {
                        foreach (var employeeId in postEmployeeCourse)
                        {
                            List<PostemployeeCourseArea> postEmployeeCourseArea = await this.unitOfWorks.CourseConfigurationRepository.PostemployeeCourseAreas(employeeId.PostemployeeCourseId.ToString());
                            for (int i = 0; i < postEmployeeCourseArea.Count; i++)
                            {
                                if (postEmployeeCourseArea != null && postEmployeeCourseArea.Any())
                                {
                                    this.unitOfWorks.CourseConfigurationRepository.DeletePostEmployeeCourse(employeeId.PostemployeeCourseId);
                                }

                            }
                        }
                    }
                }
            }
            if (configurations.POSTCourseID > 0)
            {
                this.unitOfWorks.CourseConfigurationRepository.SaveEmployeeAttendance(courseDetail);
            }
            else
            {
                courseDetail.AddedOn = DateTime.Now;
                courseDetail.AddedName = tokenValueFromCookie.EmployeeName;
                courseDetail = await this.unitOfWorks.CourseConfigurationRepository.CreateCourse(courseDetail);
                POSTCourseID = courseDetail.PostcourseId;
            }

            //Save clone course area
            if (configurations.MainCourseIDOfClone > 0)
            {
                List<PostcourseArea> mainCourseApplicableArea = new List<PostcourseArea>();
                mainCourseApplicableArea = await this.unitOfWorks.CourseConfigurationRepository.postcourseAreas(configurations.MainCourseIDOfClone);

                if (mainCourseApplicableArea != null && mainCourseApplicableArea.Any())
                {
                    foreach (var item in mainCourseApplicableArea)
                    {
                        PostcourseArea newCourseArea = new PostcourseArea();
                        newCourseArea.AreaCredits = item.AreaCredits;
                        newCourseArea.PostareaId = item.PostareaId;
                        newCourseArea.PostcourseId = POSTCourseID;
                        newCourseArea.PostinstructorDetail = item.PostoutSideInstructorDetail;
                        newCourseArea.PostoutSideInstructorDetail = item.PostoutSideInstructorDetail;
                        newCourseArea.AddedOn = newCourseArea.EditedOn = DateTime.Now;
                        newCourseArea.AddedName = newCourseArea.EditedName = tokenValueFromCookie.EmployeeName;
                        this.unitOfWorks.CourseConfigurationRepository.CreateCourseArea(newCourseArea);
                    }
                }
            }
            return POSTCourseID.ToString();

        }
        #endregion

        #region SaveCourseWithEmployeeDetail
        public async Task<bool> SaveCourseWithEmployeeDetail(CourseTrainingDetail courseTrainingDetail)
        {
            Postcourse courseRecord = new Postcourse();

            bool IsSaveSucess = false;

            TokenValueFromCookie tokenValueFromCookie = this.tokenManager.TokenValue();

            if (courseTrainingDetail != null && courseTrainingDetail.POSTCourseID > 0)
            {
                courseRecord = await this.unitOfWorks.CourseConfigurationRepository.GetCourseDetails(courseTrainingDetail.POSTCourseID);
                if (courseRecord != null)
                {
                    courseRecord.AttendenceHours = courseTrainingDetail.AttendanceHours;
                    courseRecord.EditedOn = DateTime.Now;
                    courseRecord.EditedName = tokenValueFromCookie.EmployeeName;

                    this.unitOfWorks.CourseConfigurationRepository.SaveEmployeeAttendance(courseRecord);
                }

                //Employee Record
                if (!string.IsNullOrWhiteSpace(courseTrainingDetail.Employees))
                {
                    DataItems dataItems = new DataItems();
                    dataItems.DataItem = JsonConvert.DeserializeObject<List<DataItem>>(courseTrainingDetail.Employees);
                    string EmployeeId = string.Join(",", dataItems.DataItem.Select(p => p.Value));

                    List<PostemployeeCourseArea> courseAreaDetail = new List<PostemployeeCourseArea>();
                    List<PostemployeeCourse> courseDetail = new List<PostemployeeCourse>();

                    courseDetail = await this.unitOfWorks.CourseConfigurationRepository.GetPostemployeeCourse(EmployeeId, courseTrainingDetail.POSTCourseID);

                    if (courseDetail != null && courseDetail.Any())
                    {
                        string postEmployeeCourseIDs = string.Join(",", courseDetail.Select(p => p.PostemployeeCourseId));
                        courseAreaDetail = await this.unitOfWorks.CourseConfigurationRepository.PostemployeeCourseAreas(postEmployeeCourseIDs);

                        if (courseAreaDetail != null && courseAreaDetail.Any())
                        {

                        }


                    }
                    if (dataItems.DataItem != null && dataItems.DataItem.Any())
                    {
                        List<PostemployeeCourseArea> courseAreaEmployee = new List<PostemployeeCourseArea>();

                        foreach (var data in dataItems.DataItem)
                        {
                            List<PostemployeeCourse> postEmployeeCourse = new List<PostemployeeCourse>();

                            postEmployeeCourse = await this.unitOfWorks.CourseConfigurationRepository.GetpostemployeeCoursesByDepartment(data.Value, courseTrainingDetail.POSTCourseID);

                            PostemployeeCourse employeeCourseDetail = new PostemployeeCourse();

                            if (postEmployeeCourse != null && postEmployeeCourse.Any())
                                employeeCourseDetail = postEmployeeCourse[0];

                            if (courseTrainingDetail.AttendanceHours > 0)
                                employeeCourseDetail.AttendenceHours = courseTrainingDetail.AttendanceHours;

                            employeeCourseDetail.DepartmentEmployeeId = Convert.ToInt32(data.Value);
                            employeeCourseDetail.PostcourseId = courseTrainingDetail.POSTCourseID;
                            employeeCourseDetail.EditedName = tokenValueFromCookie.EmployeeName;
                            employeeCourseDetail.EditedOn = DateTime.Now;

                            if (postEmployeeCourse == null || postEmployeeCourse.Count == 0)
                            {
                                employeeCourseDetail.Passed = true;
                                employeeCourseDetail.AddedName = employeeCourseDetail.EditedName = tokenValueFromCookie.EmployeeName;
                                employeeCourseDetail.AddedOn = employeeCourseDetail.EditedOn = DateTime.Now;
                                employeeCourseDetail = await this.unitOfWorks.CourseConfigurationRepository.SaveEmployeeCourseDetail(employeeCourseDetail);
                            }

                            courseAreaEmployee = await this.unitOfWorks.CourseConfigurationRepository.PostemployeeCourseAreas(employeeCourseDetail.PostemployeeCourseId.ToString());

                            if (courseAreaEmployee == null || courseAreaEmployee.Count == 0)
                            {
                                //Create Entry for all Areas
                                List<PostcourseArea> courseAreas = new List<PostcourseArea>();
                                courseAreas = await this.unitOfWorks.CourseConfigurationRepository.postcourseAreas(courseTrainingDetail.POSTCourseID);

                                if (courseAreas != null && courseAreas.Count > 0)
                                {
                                    foreach (var areas in courseAreas)
                                    {
                                        PostemployeeCourseArea empCourseArea = new PostemployeeCourseArea();
                                        empCourseArea.PostemployeeCourseId = employeeCourseDetail.PostemployeeCourseId;
                                        empCourseArea.PostareaId = areas.PostareaId;
                                        empCourseArea.CreditEarned = areas.AreaCredits;
                                        empCourseArea.IsPastEmployeeCourseArea = true;
                                        empCourseArea.AddedName = empCourseArea.EditedName = tokenValueFromCookie.EmployeeName;
                                        empCourseArea.AddedOn = empCourseArea.EditedOn = DateTime.Now;

                                        this.unitOfWorks.CourseConfigurationRepository.SaveEmployeeCourseArea(empCourseArea);
                                    }
                                }
                            }
                            else
                            {
                                //To add new areas from EDIT Cource 
                                List<PostcourseArea> courseAreas = new List<PostcourseArea>();
                                List<PostcourseArea> courseAreasAfterEdit = new List<PostcourseArea>();
                                courseAreas = await this.unitOfWorks.CourseConfigurationRepository.postcourseAreas(courseTrainingDetail.POSTCourseID);

                                courseAreasAfterEdit = courseAreas.Where(p => !courseAreaEmployee.Any(p2 => p2.PostareaId == p.PostareaId)).ToList();

                                if (courseAreasAfterEdit != null && courseAreasAfterEdit.Count > 0)
                                {
                                    foreach (var areas in courseAreasAfterEdit)
                                    {
                                        PostemployeeCourseArea empCourseArea = new PostemployeeCourseArea();
                                        empCourseArea.PostemployeeCourseId = employeeCourseDetail.PostemployeeCourseId;
                                        empCourseArea.PostareaId = areas.PostareaId;
                                        empCourseArea.CreditEarned = areas.AreaCredits;
                                        empCourseArea.IsPastEmployeeCourseArea = true;
                                        empCourseArea.AddedName = empCourseArea.EditedName = tokenValueFromCookie.EmployeeName;
                                        empCourseArea.AddedOn = empCourseArea.EditedOn = DateTime.Now;

                                        this.unitOfWorks.CourseConfigurationRepository.SaveEmployeeCourseArea(empCourseArea);
                                    }
                                }
                            }

                            IsSaveSucess = true;

                        }
                    }



                }
            }
            return IsSaveSucess;
        }
        #endregion

        #region ViewCourseDetails
        public async Task<CourseConfigurations> ViewCourseDetails(decimal POSTCourseID)
        {
            CourseConfigurations courseConfigurations = new();
            decimal postNewCourseID = 0;
            if (POSTCourseID > 0)
                postNewCourseID = POSTCourseID;

            Postcourse courseDetail = new Postcourse();

            if (postNewCourseID > 0)
            {
                courseDetail = await this.unitOfWorks.CourseConfigurationRepository.GetCourseDetails(POSTCourseID);
                if (courseDetail != null)
                {
                    courseConfigurations.POSTCourseID = postNewCourseID; //Actual POSTCourseID from edit detail
                    courseConfigurations.CourseTitle = courseDetail.CourseTitle;
                    courseConfigurations.Sponsor = courseDetail.Sponsor;
                    courseConfigurations.CourseStartDateLabel = courseDetail.CourseStartDate != DateTime.MinValue ? courseDetail.CourseStartDate.ToString() : string.Empty;
                    courseConfigurations.CourseEndDateLabel = courseDetail.CourseEndDate != DateTime.MinValue ? courseDetail.CourseEndDate.ToString() : string.Empty;
                    courseConfigurations.CourseHours = courseDetail.CourseHours;
                    courseConfigurations.CourseFeeLabel = courseDetail.CourseFee > 0 ? "$" + courseDetail.CourseFee?.ToString("#0.00") : string.Empty;
                    //mdlCourseConfiguration.CertifiedCourse = courseDetail.CertifiedCourse;
                    courseConfigurations.Comment = courseDetail.Comments;

                    if (courseDetail.OutOfDepartment != null && courseDetail.OutOfDepartment.HasValue && courseDetail.OutOfDepartment.Value == true)
                    {
                        courseConfigurations.LocationString = string.Format("{0}{1}{2}{3}{4}",
                                                                   !string.IsNullOrWhiteSpace(courseDetail.AddressName) ? " Name : " + courseDetail.AddressName : string.Empty,
                                                                   !string.IsNullOrWhiteSpace(courseDetail.Street) ? " Street : " + courseDetail.Street : string.Empty,
                                                                   !string.IsNullOrWhiteSpace(courseDetail.City) ? " ,City  : " + courseDetail.City : string.Empty,
                                                                   !string.IsNullOrWhiteSpace(courseDetail.State) ? " ,State  : " + courseDetail.State : string.Empty,
                                                                   !string.IsNullOrWhiteSpace(courseDetail.Zip) ? " ,Zip  : " + courseDetail.Zip : string.Empty);
                    }
                    else
                        courseConfigurations.LocationString = "In Department";

                    //get Employee
                    DataItems dataItems;
                    XmlSerializer serializer = new XmlSerializer(typeof(DataItems));
                    if (courseDetail.DepartmentEmployeeXml != null)
                    {
                        using (StringReader reader = new StringReader(courseDetail.DepartmentEmployeeXml!))
                        {
                            dataItems = (DataItems)serializer.Deserialize(reader)!;
                        }

                        if (dataItems != null && dataItems.DataItem != null)
                        {
                            courseConfigurations.EmployeeDetail = string.Join(";  ", dataItems.DataItem.ToList().Select(p => p.DisplayString));
                        }
                    }

                }
            }
            //Get Applicable areas 
            List<POSTApplicableAreaDetail> applicableAreas = new List<POSTApplicableAreaDetail>();
            applicableAreas = await this.unitOfWorks.CourseConfigurationRepository.GETPOSTApplicableAreaList(postNewCourseID);
            if (applicableAreas != null && applicableAreas.Any())
                courseConfigurations.POSTApplicableAreaDetails = applicableAreas.OrderBy(x => x.ApplicableAreas).ToList();
            else
                courseConfigurations.POSTApplicableAreaDetails = new List<POSTApplicableAreaDetail>();

            return courseConfigurations;

        }

        #endregion

        #region Check Records Exists
        public async Task<bool> CheckTrainingRecordAvailForEmployee(decimal POSTCourseID)
        {
            bool returnValue = false;
            List<PostemployeeCourse> postEmployeeCourse = await this.unitOfWorks.CourseConfigurationRepository.GetPostEmployeeCourses(POSTCourseID);

            if (postEmployeeCourse != null && postEmployeeCourse.Any())
            {
                returnValue = true;
            }
            return returnValue;
        }

        #endregion

        #region Valid Course At Server
        public async Task<string> ValidateCourseAtServer(decimal POSTCourseID)
        {
            string errorMessage = "";
            List<PostcourseArea> courseAreas = new List<PostcourseArea>();
            courseAreas = await this.unitOfWorks.CourseConfigurationRepository.postcourseAreas(POSTCourseID);

            if (courseAreas != null && courseAreas.Any())
            {
                if (courseAreas[0].Postcourse != null && courseAreas[0]?.Postcourse?.DepartmentEmployeeXml == null)
                {
                    errorMessage = "Please select Employee before confirm training";
                }
            }
            else
            {
                errorMessage = "Please select applicable areas before confirm training";
            }
            return errorMessage;
        }
        #endregion
    }
}
