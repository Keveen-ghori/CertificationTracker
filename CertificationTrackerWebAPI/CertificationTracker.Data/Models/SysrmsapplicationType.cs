using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysrmsapplicationType
{
    public int SysrmsapplicationTypeId { get; set; }

    public string? DisplayName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsExternalSystem { get; set; }

    public string? HyperLink { get; set; }

    public string? Parameters { get; set; }

    public string? Icons { get; set; }

    public string? ApplicationType { get; set; }

    public bool? IsSystemUseOnly { get; set; }

    public virtual ICollection<DataProcessTrigger> DataProcessTriggers { get; set; } = new List<DataProcessTrigger>();

    public virtual ICollection<DepApplicationUsage> DepApplicationUsages { get; set; } = new List<DepApplicationUsage>();

    public virtual ICollection<EmployeeWorkingLog> EmployeeWorkingLogs { get; set; } = new List<EmployeeWorkingLog>();

    public virtual ICollection<HelpQueryLocationInvolvement> HelpQueryLocationInvolvements { get; set; } = new List<HelpQueryLocationInvolvement>();

    public virtual ICollection<HelpQueryOrganizationInvolvement> HelpQueryOrganizationInvolvements { get; set; } = new List<HelpQueryOrganizationInvolvement>();

    public virtual ICollection<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; } = new List<HelpQueryPersonInvolvement>();

    public virtual ICollection<HelpQueryPropertyInvolvement> HelpQueryPropertyInvolvements { get; set; } = new List<HelpQueryPropertyInvolvement>();

    public virtual ICollection<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; } = new List<HelpQueryVehicleInvolvement>();

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUsers { get; set; } = new List<IndividualSecurityToUser>();

    public virtual ICollection<MstrlocationAlert> MstrlocationAlerts { get; set; } = new List<MstrlocationAlert>();

    public virtual ICollection<MstrlocationImage> MstrlocationImages { get; set; } = new List<MstrlocationImage>();

    public virtual ICollection<MstrorganizationImage> MstrorganizationImages { get; set; } = new List<MstrorganizationImage>();

    public virtual ICollection<MstrpersonAlert> MstrpersonAlerts { get; set; } = new List<MstrpersonAlert>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristics { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonContactDetail> MstrpersonContactDetails { get; set; } = new List<MstrpersonContactDetail>();

    public virtual ICollection<MstrpersonLocation> MstrpersonLocations { get; set; } = new List<MstrpersonLocation>();

    public virtual ICollection<MstrpersonMedicalCondition> MstrpersonMedicalConditions { get; set; } = new List<MstrpersonMedicalCondition>();

    public virtual ICollection<MstrpersonMugShot> MstrpersonMugShots { get; set; } = new List<MstrpersonMugShot>();

    public virtual ICollection<MstrpersonName> MstrpersonNames { get; set; } = new List<MstrpersonName>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenses { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<MstrpersonPhysicalFeature> MstrpersonPhysicalFeatures { get; set; } = new List<MstrpersonPhysicalFeature>();

    public virtual ICollection<MstrpersonRelatedMedium> MstrpersonRelatedMedia { get; set; } = new List<MstrpersonRelatedMedium>();

    public virtual ICollection<MstrpropertyImage> MstrpropertyImages { get; set; } = new List<MstrpropertyImage>();

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwners { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual ICollection<NonVerifiedCallPerson> NonVerifiedCallPeople { get; set; } = new List<NonVerifiedCallPerson>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplates { get; set; } = new List<RefNarrativeTemplate>();

    public virtual ICollection<RestoreCancelledApplicationDatum> RestoreCancelledApplicationData { get; set; } = new List<RestoreCancelledApplicationDatum>();

    public virtual ICollection<RmsapplicationActionTrace> RmsapplicationActionTraces { get; set; } = new List<RmsapplicationActionTrace>();

    public virtual ICollection<RmsapplicationDataExportLog> RmsapplicationDataExportLogs { get; set; } = new List<RmsapplicationDataExportLog>();

    public virtual ICollection<RmsdataProcessController> RmsdataProcessControllers { get; set; } = new List<RmsdataProcessController>();

    public virtual ICollection<RmsdeptWorkFlow> RmsdeptWorkFlows { get; set; } = new List<RmsdeptWorkFlow>();

    public virtual ICollection<RmsnotificationLog> RmsnotificationLogs { get; set; } = new List<RmsnotificationLog>();

    public virtual ICollection<RmsworkFlowController> RmsworkFlowControllers { get; set; } = new List<RmsworkFlowController>();

    public virtual ICollection<RmsworkFlowDef> RmsworkFlowDefs { get; set; } = new List<RmsworkFlowDef>();

    public virtual ICollection<SysApplicationRelation> SysApplicationRelationCreatedFromApplicationNavigations { get; set; } = new List<SysApplicationRelation>();

    public virtual ICollection<SysApplicationRelation> SysApplicationRelationGeneratedToApplicationNavigations { get; set; } = new List<SysApplicationRelation>();

    public virtual ICollection<SysApplicationStatus> SysApplicationStatuses { get; set; } = new List<SysApplicationStatus>();

    public virtual ICollection<SysDataValidationControlConfiguration> SysDataValidationControlConfigurations { get; set; } = new List<SysDataValidationControlConfiguration>();

    public virtual ICollection<SysDataValidationRule> SysDataValidationRules { get; set; } = new List<SysDataValidationRule>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<SysNumberAssignment> SysNumberAssignments { get; set; } = new List<SysNumberAssignment>();

    public virtual ICollection<SysNumberController> SysNumberControllers { get; set; } = new List<SysNumberController>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUis { get; set; } = new List<SysapplicationStatusAllowedUi>();

    public virtual ICollection<SysapplicationValidation> SysapplicationValidations { get; set; } = new List<SysapplicationValidation>();

    public virtual ICollection<SysrmsuserInterfaceDefinition> SysrmsuserInterfaceDefinitions { get; set; } = new List<SysrmsuserInterfaceDefinition>();
}
