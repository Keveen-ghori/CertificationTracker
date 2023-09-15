using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Warrant
{
    public decimal WarrantId { get; set; }

    public int? DepartmentId { get; set; }

    public int? RequestingOfficerId { get; set; }

    public decimal? WarrantPersonId { get; set; }

    public decimal? RelatedIncidentId { get; set; }

    public int? WarrantStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? UsedNarrativeTemplateId { get; set; }

    public int? DataEntryEmployeeId { get; set; }

    public int? WarrantTypeCode { get; set; }

    public int? BondTypeCode { get; set; }

    public int? WarrantSourceCode { get; set; }

    public int? Court { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? WarrantNumber { get; set; }

    public DateTime? WarrantEffectDateTime { get; set; }

    public DateTime? WarrantExpirationDateTime { get; set; }

    public string? Comments { get; set; }

    public DateTime? WarrantStatusDateTime { get; set; }

    public DateTime? IssuedDateTime { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public string? Judge { get; set; }

    public DateTime? CourtDate { get; set; }

    public string? IncidentNumber { get; set; }

    public decimal? BondAmount { get; set; }

    public string? Affidavit { get; set; }

    public string? AffidavitEditedName { get; set; }

    public DateTime? AffidavitDateTime { get; set; }

    public string? Collectnumber { get; set; }

    public bool? ExtraditableWarrant { get; set; }

    public string? Ncicnumber { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? DomesticRelated { get; set; }

    public string? JacketNumber { get; set; }

    public DateTime? SwornDate { get; set; }

    public string? ExtraditableDetails { get; set; }

    public int? NotaryId { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookings { get; set; } = new List<ArrestBooking>();

    public virtual RefIncidentReferenceDatum? BondTypeCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CourtNavigation { get; set; }

    public virtual DepartmentEmployee? DataEntryEmployee { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? Notary { get; set; }

    public virtual Incident? RelatedIncident { get; set; }

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual DepartmentEmployee? RequestingOfficer { get; set; }

    public virtual RefNarrativeTemplate? UsedNarrativeTemplate { get; set; }

    public virtual ICollection<WarrantAttempt> WarrantAttempts { get; set; } = new List<WarrantAttempt>();

    public virtual ICollection<WarrantGeneratedReport> WarrantGeneratedReports { get; set; } = new List<WarrantGeneratedReport>();

    public virtual ICollection<WarrantOffense> WarrantOffenses { get; set; } = new List<WarrantOffense>();

    public virtual Mstrperson? WarrantPerson { get; set; }

    public virtual RefIncidentReferenceDatum? WarrantSourceCodeNavigation { get; set; }

    public virtual SysApplicationStatus? WarrantStatus { get; set; }

    public virtual RefIncidentReferenceDatum? WarrantTypeCodeNavigation { get; set; }
}
