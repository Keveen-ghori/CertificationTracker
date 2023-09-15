using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Mstrperson
{
    public decimal Mpid { get; set; }

    public int? AgencyId { get; set; }

    public decimal? LatestBackgroundCheckId { get; set; }

    public int? PersonBloodTypeCode { get; set; }

    public int? PersonEthnicityCode { get; set; }

    public int? PersonRaceCode { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? PersonDeathDate { get; set; }

    public string? Ssnidentification { get; set; }

    public string? TaxIdentification { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? PersonDetailXml { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromPersonId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public bool? IsSexOffender { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public string? Dmvtraces { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<CrashPersonInvolvement> CrashPersonInvolvements { get; set; } = new List<CrashPersonInvolvement>();

    public virtual ICollection<FieldInterviewPersonInvolvment> FieldInterviewPersonInvolvments { get; set; } = new List<FieldInterviewPersonInvolvment>();

    public virtual ICollection<HelpQueryPersonInvolvement> HelpQueryPersonInvolvements { get; set; } = new List<HelpQueryPersonInvolvement>();

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementOwnerPeople { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementRecoveredFromPeople { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvementReturnedToPeople { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementPersonClaimingVehicleNavigations { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvementRecoveredFromPeople { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual TrxBackgroundCheck? LatestBackgroundCheck { get; set; }

    public virtual ICollection<MstrorganizationRelatedIndex> MstrorganizationRelatedIndices { get; set; } = new List<MstrorganizationRelatedIndex>();

    public virtual ICollection<MstrpersonAlert> MstrpersonAlerts { get; set; } = new List<MstrpersonAlert>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristics { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonContactDetail> MstrpersonContactDetails { get; set; } = new List<MstrpersonContactDetail>();

    public virtual ICollection<MstrpersonFingerprintSet> MstrpersonFingerprintSets { get; set; } = new List<MstrpersonFingerprintSet>();

    public virtual ICollection<MstrpersonIdentification> MstrpersonIdentifications { get; set; } = new List<MstrpersonIdentification>();

    public virtual ICollection<MstrpersonLocation> MstrpersonLocations { get; set; } = new List<MstrpersonLocation>();

    public virtual ICollection<MstrpersonMedicalCondition> MstrpersonMedicalConditions { get; set; } = new List<MstrpersonMedicalCondition>();

    public virtual ICollection<MstrpersonMugShot> MstrpersonMugShots { get; set; } = new List<MstrpersonMugShot>();

    public virtual ICollection<MstrpersonName> MstrpersonNames { get; set; } = new List<MstrpersonName>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenses { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<MstrpersonPhysicalFeature> MstrpersonPhysicalFeatures { get; set; } = new List<MstrpersonPhysicalFeature>();

    public virtual ICollection<MstrpersonRelatedMedium> MstrpersonRelatedMedia { get; set; } = new List<MstrpersonRelatedMedium>();

    public virtual ICollection<MstrpersonRelation> MstrpersonRelationLinkedPeople { get; set; } = new List<MstrpersonRelation>();

    public virtual ICollection<MstrpersonRelation> MstrpersonRelationPrimaryPeople { get; set; } = new List<MstrpersonRelation>();

    public virtual ICollection<MstrpropertyOwner> MstrpropertyOwners { get; set; } = new List<MstrpropertyOwner>();

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwners { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPeople { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NonVerifiedCallPerson> NonVerifiedCallPeople { get; set; } = new List<NonVerifiedCallPerson>();

    public virtual RefMstrinxreferenceDatum? PersonBloodTypeCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonEthnicityCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonRaceCodeNavigation { get; set; }

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();

    public virtual ICollection<TrxBackgroundCheck> TrxBackgroundChecks { get; set; } = new List<TrxBackgroundCheck>();

    public virtual ICollection<Warrant> Warrants { get; set; } = new List<Warrant>();
}
