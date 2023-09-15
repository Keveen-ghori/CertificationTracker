using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentEmployee
{
    public int DepartmentEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? DepEmployeeId { get; set; }

    public string? BadgeNumber { get; set; }

    public string? Rank { get; set; }

    public string? Title { get; set; }

    public bool? IsActive { get; set; }

    public string? RadioNumber { get; set; }

    public DateTime? DateOfHiring { get; set; }

    public bool? IsOnProbation { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? DeptCellPhone { get; set; }

    public string? CellPhone { get; set; }

    public string? HomePhone { get; set; }

    public string? Email { get; set; }

    public string? StateWideId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? EmergContact { get; set; }

    public string? EmergRelationship { get; set; }

    public string? EmergAddress { get; set; }

    public string? EmergCity { get; set; }

    public string? EmergState { get; set; }

    public string? EmergZipCode { get; set; }

    public string? EmergPhone { get; set; }

    public string? Religion { get; set; }

    public string? Allergies { get; set; }

    public string? MedicalConditions { get; set; }

    public DateTime? Dob { get; set; }

    public string? Ssn { get; set; }

    public string? BloodType { get; set; }

    public string? Divison { get; set; }

    public DateTime? DateOfSepration { get; set; }

    public string? Suffix { get; set; }

    public string? FullName { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookingArrestOfficers { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingBookingOfficers { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingCurrentEditors { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingIdentifyingOfficers { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<BookingReleaseInfo> BookingReleaseInfos { get; set; } = new List<BookingReleaseInfo>();

    public virtual ICollection<CrashCommentsInvolvement> CrashCommentsInvolvementAddedBies { get; set; } = new List<CrashCommentsInvolvement>();

    public virtual ICollection<CrashCommentsInvolvement> CrashCommentsInvolvementEditedBies { get; set; } = new List<CrashCommentsInvolvement>();

    public virtual ICollection<Crash> CrashDataEntryEmployees { get; set; } = new List<Crash>();

    public virtual ICollection<CrashOfficialInvolvement> CrashOfficialInvolvements { get; set; } = new List<CrashOfficialInvolvement>();

    public virtual ICollection<Crash> CrashReportedEmployees { get; set; } = new List<Crash>();

    public virtual ICollection<CustodyLog> CustodyLogs { get; set; } = new List<CustodyLog>();

    public virtual ICollection<DepOrgEmployee> DepOrgEmployeeDepartmentEmployees { get; set; } = new List<DepOrgEmployee>();

    public virtual ICollection<DepOrgEmployee> DepOrgEmployeeDirectSupervisors { get; set; } = new List<DepOrgEmployee>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentDailyRoster> DepartmentDailyRosters { get; set; } = new List<DepartmentDailyRoster>();

    public virtual ICollection<DepartmentEmployeeManagement> DepartmentEmployeeManagementDepartmentEmployees { get; set; } = new List<DepartmentEmployeeManagement>();

    public virtual ICollection<DepartmentEmployeeManagement> DepartmentEmployeeManagementManagers { get; set; } = new List<DepartmentEmployeeManagement>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<EmployeeEquipment> EmployeeEquipments { get; set; } = new List<EmployeeEquipment>();

    public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; } = new List<EmployeeHistory>();

    public virtual ICollection<EmployeeNote> EmployeeNotes { get; set; } = new List<EmployeeNote>();

    public virtual ICollection<EmployeePhoto> EmployeePhotos { get; set; } = new List<EmployeePhoto>();

    public virtual ICollection<EmployeeWorkingLog> EmployeeWorkingLogs { get; set; } = new List<EmployeeWorkingLog>();

    public virtual ICollection<FieldInterview> FieldInterviewDataEntryEmployees { get; set; } = new List<FieldInterview>();

    public virtual ICollection<FieldInterview> FieldInterviewInterviewOfficers { get; set; } = new List<FieldInterview>();

    public virtual ICollection<FieldInterview> FieldInterviewSuppressedBies { get; set; } = new List<FieldInterview>();

    public virtual ICollection<IncidentCommentsInvolvement> IncidentCommentsInvolvementAddedBies { get; set; } = new List<IncidentCommentsInvolvement>();

    public virtual ICollection<IncidentCommentsInvolvement> IncidentCommentsInvolvementEditedBies { get; set; } = new List<IncidentCommentsInvolvement>();

    public virtual ICollection<Incident> IncidentDataEntryEmployees { get; set; } = new List<Incident>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagementInvestigativeEmployees { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagementInvestigativeSupervisors { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<IncidentOfficialInvolvement> IncidentOfficialInvolvements { get; set; } = new List<IncidentOfficialInvolvement>();

    public virtual ICollection<IncidentReportDistribution> IncidentReportDistributionDistributedByNavigations { get; set; } = new List<IncidentReportDistribution>();

    public virtual ICollection<IncidentReportDistribution> IncidentReportDistributionDistributedToDepartmentEmployees { get; set; } = new List<IncidentReportDistribution>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetails { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<Incident> IncidentReportedEmployees { get; set; } = new List<Incident>();

    public virtual ICollection<Incident> IncidentSkeletonApprovedBies { get; set; } = new List<Incident>();

    public virtual ICollection<Incident> IncidentSuppressedBies { get; set; } = new List<Incident>();

    public virtual ICollection<IncidentUseOfForceOfficerDetail> IncidentUseOfForceOfficerDetailCanineHandlerEmployees { get; set; } = new List<IncidentUseOfForceOfficerDetail>();

    public virtual ICollection<IncidentUseOfForceOfficerDetail> IncidentUseOfForceOfficerDetailInvolvedEmployee1Navigations { get; set; } = new List<IncidentUseOfForceOfficerDetail>();

    public virtual ICollection<IncidentUseOfForceOfficerDetail> IncidentUseOfForceOfficerDetailInvolvedEmployee2Navigations { get; set; } = new List<IncidentUseOfForceOfficerDetail>();

    public virtual ICollection<IncidentUseOfForceOfficerDetail> IncidentUseOfForceOfficerDetailInvolvedEmployee3Navigations { get; set; } = new List<IncidentUseOfForceOfficerDetail>();

    public virtual ICollection<IncidentUseOfForce> IncidentUseOfForces { get; set; } = new List<IncidentUseOfForce>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUserAllowedEmployees { get; set; } = new List<IndividualSecurityToUser>();

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUserGrantedByEmployees { get; set; } = new List<IndividualSecurityToUser>();

    public virtual ICollection<NotificationMethod> NotificationMethods { get; set; } = new List<NotificationMethod>();

    public virtual ICollection<PostcourseAttachment> PostcourseAttachments { get; set; } = new List<PostcourseAttachment>();

    public virtual ICollection<PostemployeeCourse> PostemployeeCourses { get; set; } = new List<PostemployeeCourse>();

    public virtual ICollection<Postemployee> Postemployees { get; set; } = new List<Postemployee>();

    public virtual ICollection<Postinstructor> Postinstructors { get; set; } = new List<Postinstructor>();

    public virtual ICollection<Postrenewal> Postrenewals { get; set; } = new List<Postrenewal>();

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackings { get; set; } = new List<PropertyCustodyTracking>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplateAddedBies { get; set; } = new List<RefNarrativeTemplate>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplateEditedBies { get; set; } = new List<RefNarrativeTemplate>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplateEmployeeSpecifyNavigations { get; set; } = new List<RefNarrativeTemplate>();

    public virtual ICollection<RmsdeptWorkFlowReviewRequirement> RmsdeptWorkFlowReviewRequirements { get; set; } = new List<RmsdeptWorkFlowReviewRequirement>();

    public virtual ICollection<RmsnotificationLog> RmsnotificationLogEmployeeCreateds { get; set; } = new List<RmsnotificationLog>();

    public virtual ICollection<RmsnotificationLog> RmsnotificationLogEmployeeNotifieds { get; set; } = new List<RmsnotificationLog>();

    public virtual ICollection<RmsworkFlowController> RmsworkFlowControllerReportWriters { get; set; } = new List<RmsworkFlowController>();

    public virtual ICollection<RmsworkFlowController> RmsworkFlowControllerWfactionAssignedEmps { get; set; } = new List<RmsworkFlowController>();

    public virtual ICollection<ServiceCallDispatchedOffical> ServiceCallDispatchedOfficals { get; set; } = new List<ServiceCallDispatchedOffical>();

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();

    public virtual ICollection<SysNotificationAction> SysNotificationActions { get; set; } = new List<SysNotificationAction>();

    public virtual ICollection<SysNumberAssignment> SysNumberAssignments { get; set; } = new List<SysNumberAssignment>();

    public virtual ICollection<SysapplicationValidation> SysapplicationValidationAddedBies { get; set; } = new List<SysapplicationValidation>();

    public virtual ICollection<SysapplicationValidation> SysapplicationValidationEditedBies { get; set; } = new List<SysapplicationValidation>();

    public virtual ICollection<SysapplicationValidation> SysapplicationValidationEmployees { get; set; } = new List<SysapplicationValidation>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TowRequest> TowRequestNotifiedByNavigations { get; set; } = new List<TowRequest>();

    public virtual ICollection<TowRequest> TowRequestReportedEmployees { get; set; } = new List<TowRequest>();

    public virtual ICollection<TrafficStop> TrafficStopDataEntryEmployees { get; set; } = new List<TrafficStop>();

    public virtual ICollection<TrafficStop> TrafficStopReportedEmployees { get; set; } = new List<TrafficStop>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<WarrantAttempt> WarrantAttempts { get; set; } = new List<WarrantAttempt>();

    public virtual ICollection<Warrant> WarrantDataEntryEmployees { get; set; } = new List<Warrant>();

    public virtual ICollection<Warrant> WarrantNotaries { get; set; } = new List<Warrant>();

    public virtual ICollection<Warrant> WarrantRequestingOfficers { get; set; } = new List<Warrant>();
}
