using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ArrestBooking
{
    public decimal ArrestBookingId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public decimal? ArrestLocationId { get; set; }

    public decimal? WarrantId { get; set; }

    public int? ArrestOfficerId { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? OffenseLocationId { get; set; }

    public int? BookingOfficerId { get; set; }

    public int? ArrestCategoryCode { get; set; }

    public decimal? BookingLocationId { get; set; }

    public int? UsedNarrativeTemplateId { get; set; }

    public int? IdentifyingOfficerId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? StatusId { get; set; }

    public decimal? AttorneyOrg { get; set; }

    public decimal? BondCompany { get; set; }

    public int? CourtCode { get; set; }

    public int? CurrentEditorId { get; set; }

    public int? ReportStatusId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ArrestNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? Description { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public DateTime? BookingDateTime { get; set; }

    public string? Comments { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Narrative { get; set; }

    public string? NarrativeEditedName { get; set; }

    public DateTime? NarrativeEditedOn { get; set; }

    public string? Uarnumber { get; set; }

    public bool? IsJuvenile { get; set; }

    public string? Afisnumber { get; set; }

    public DateTime? OffenseDateTime { get; set; }

    public string? TownOfArrest { get; set; }

    public string? TownOfOffense { get; set; }

    public bool? IsTransferedAfis { get; set; }

    public string? TownOfWarrant { get; set; }

    public string? EmergencyContact { get; set; }

    public string? EmergencyContactPhone { get; set; }

    public DateTime? CourtDate { get; set; }

    public string? ReleaseToPerson { get; set; }

    public string? ReleaseMethodOther { get; set; }

    public DateTime? ReleaseDateTime { get; set; }

    public string? ReleaseComments { get; set; }

    public string? CourtGanum { get; set; }

    public DateTime? CurrentEditStartTime { get; set; }

    public string? OtherAgencyWarrantNumber { get; set; }

    public string? Prawnnumber { get; set; }

    public bool? IsLegallyEmancipated { get; set; }

    public string? CourtDispositionRaw { get; set; }

    public string? CdDocketNumber { get; set; }

    public DateTime? CdDispositionDate { get; set; }

    public DateTime? CdErasureDate { get; set; }

    public string? CdYoswitch { get; set; }

    public string? CdRearrestIndicator { get; set; }

    public DateTime? CdAppealFiledDate { get; set; }

    public DateTime? CdAppealDecidedDate { get; set; }

    public decimal? CdBondForfeitureAmount { get; set; }

    public decimal? CdCostAmount { get; set; }

    public int? CdCostIndicator { get; set; }

    public string? CdCibindicator { get; set; }

    public string? CdDispositionMessage { get; set; }

    public string? CdAdditionalTicketNumbers { get; set; }

    public string? CdAdditionalPdandCaseNumbers { get; set; }

    public string? CdRevisedIndicator { get; set; }

    public string? CdCsindicator { get; set; }

    public int? FingerPrintStatus { get; set; }

    public DateTime? FingerPrintDateTime { get; set; }

    public string? EntryNumberType { get; set; }

    public bool? IsStudent { get; set; }

    public virtual RefIncidentReferenceDatum? ArrestCategoryCodeNavigation { get; set; }

    public virtual Mstrlocation? ArrestLocation { get; set; }

    public virtual DepartmentEmployee? ArrestOfficer { get; set; }

    public virtual Mstrorganization? AttorneyOrgNavigation { get; set; }

    public virtual Mstrorganization? BondCompanyNavigation { get; set; }

    public virtual Mstrlocation? BookingLocation { get; set; }

    public virtual DepartmentEmployee? BookingOfficer { get; set; }

    public virtual ICollection<BookingProperty> BookingProperties { get; set; } = new List<BookingProperty>();

    public virtual ICollection<BookingReleaseInfo> BookingReleaseInfos { get; set; } = new List<BookingReleaseInfo>();

    public virtual RefIncidentReferenceDatum? CdCostIndicatorNavigation { get; set; }

    public virtual ICollection<CourtChargeInfo> CourtChargeInfos { get; set; } = new List<CourtChargeInfo>();

    public virtual RefIncidentReferenceDatum? CourtCodeNavigation { get; set; }

    public virtual DepartmentEmployee? CurrentEditor { get; set; }

    public virtual Department? Department { get; set; }

    public virtual SysApplicationStatus? FingerPrintStatusNavigation { get; set; }

    public virtual DepartmentEmployee? IdentifyingOfficer { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual Mstrlocation? OffenseLocation { get; set; }

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual SysApplicationStatus? Status { get; set; }

    public virtual RefNarrativeTemplate? UsedNarrativeTemplate { get; set; }

    public virtual Warrant? Warrant { get; set; }
}
