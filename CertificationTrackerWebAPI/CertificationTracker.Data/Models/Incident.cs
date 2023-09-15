using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Incident
{
    public decimal IncidentId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public decimal? PrimaryLocationId { get; set; }

    public DateTime? CadreprotedDateTime { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public int? UsedNarrativeTemplateId { get; set; }

    public int? DispositionCodeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? SuppressedById { get; set; }

    public int? SkeletonApprovedById { get; set; }

    public int? UcrcaseClearanceCodeId { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? DataEntryEmployeeId { get; set; }

    public decimal? CloneFromIncidentId { get; set; }

    public string? IncidentReportType { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public DateTime? IncidentOccuredDtend { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateClosed { get; set; }

    public string? Narrative { get; set; }

    public string? NarrativeEditedName { get; set; }

    public DateTime? NarrativeEditedOn { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public int? SupplementSeq { get; set; }

    public bool? IsSuppressed { get; set; }

    public DateTime? SuppressedDt { get; set; }

    public DateTime? ReportStatusDataTime { get; set; }

    public DateTime? SkeletonSubmitDateTime { get; set; }

    public string? Cadnumber { get; set; }

    public string? ReportingUnit { get; set; }

    public string? ReportingUnitShift { get; set; }

    public string? ReportingUnitProvider { get; set; }

    public string? ReportingUnitArea { get; set; }

    public string? LocationDescription { get; set; }

    public string? IncidentDescription { get; set; }

    public string? Barcode { get; set; }

    public string? Uiaction { get; set; }

    public string? RichNarrativeText { get; set; }

    public bool? HideLocationOnPdf { get; set; }

    public bool? IsPoliceUseForce { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookings { get; set; } = new List<ArrestBooking>();

    public virtual Incident? CloneFromIncident { get; set; }

    public virtual DepartmentEmployee? DataEntryEmployee { get; set; }

    public virtual Department? Department { get; set; }

    public virtual RefDispositionCode? DispositionCode { get; set; }

    public virtual ICollection<IncidentBiasHateCrimeFactor> IncidentBiasHateCrimeFactors { get; set; } = new List<IncidentBiasHateCrimeFactor>();

    public virtual ICollection<IncidentCommentsInvolvement> IncidentCommentsInvolvements { get; set; } = new List<IncidentCommentsInvolvement>();

    public virtual ICollection<IncidentFamilyViolence> IncidentFamilyViolences { get; set; } = new List<IncidentFamilyViolence>();

    public virtual ICollection<IncidentForceInvolvement> IncidentForceInvolvements { get; set; } = new List<IncidentForceInvolvement>();

    public virtual ICollection<IncidentForceReport> IncidentForceReports { get; set; } = new List<IncidentForceReport>();

    public virtual ICollection<IncidentGeneralCategory> IncidentGeneralCategories { get; set; } = new List<IncidentGeneralCategory>();

    public virtual ICollection<IncidentGeneratedReport> IncidentGeneratedReports { get; set; } = new List<IncidentGeneratedReport>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagements { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<IncidentMo> IncidentMos { get; set; } = new List<IncidentMo>();

    public virtual ICollection<IncidentNibrsoffenseBase> IncidentNibrsoffenseBases { get; set; } = new List<IncidentNibrsoffenseBase>();

    public virtual ICollection<IncidentOfficialInvolvement> IncidentOfficialInvolvements { get; set; } = new List<IncidentOfficialInvolvement>();

    public virtual ICollection<IncidentOrganizationInvolvement> IncidentOrganizationInvolvements { get; set; } = new List<IncidentOrganizationInvolvement>();

    public virtual ICollection<IncidentOtherFactor> IncidentOtherFactors { get; set; } = new List<IncidentOtherFactor>();

    public virtual ICollection<IncidentOutOfTownWarrant> IncidentOutOfTownWarrants { get; set; } = new List<IncidentOutOfTownWarrant>();

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentRelatedAttachment> IncidentRelatedAttachments { get; set; } = new List<IncidentRelatedAttachment>();

    public virtual ICollection<IncidentReportDistribution> IncidentReportDistributions { get; set; } = new List<IncidentReportDistribution>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetails { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual SysApplicationStatus? IncidentStatus { get; set; }

    public virtual ICollection<IncidentUseOfForce> IncidentUseOfForces { get; set; } = new List<IncidentUseOfForce>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<Incident> InverseCloneFromIncident { get; set; } = new List<Incident>();

    public virtual ICollection<Incident> InversePrimaryIncident { get; set; } = new List<Incident>();

    public virtual ICollection<NibrsreportAdmin> NibrsreportAdminIncidents { get; set; } = new List<NibrsreportAdmin>();

    public virtual ICollection<NibrsreportAdmin> NibrsreportAdminPrimaryIncidents { get; set; } = new List<NibrsreportAdmin>();

    public virtual ICollection<PhotoLineup> PhotoLineupIncidents { get; set; } = new List<PhotoLineup>();

    public virtual ICollection<PhotoLineup> PhotoLineupPrimaryIncidents { get; set; } = new List<PhotoLineup>();

    public virtual Incident? PrimaryIncident { get; set; }

    public virtual ICollection<PropertyRoomItem> PropertyRoomItems { get; set; } = new List<PropertyRoomItem>();

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual DepartmentEmployee? ReportedEmployee { get; set; }

    public virtual DepartmentEmployee? SkeletonApprovedBy { get; set; }

    public virtual DepartmentEmployee? SuppressedBy { get; set; }

    public virtual RefIncidentReferenceDatum? UcrcaseClearanceCode { get; set; }

    public virtual RefNarrativeTemplate? UsedNarrativeTemplate { get; set; }

    public virtual ICollection<Warrant> Warrants { get; set; } = new List<Warrant>();
}
