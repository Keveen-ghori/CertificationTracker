using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Crash
{
    public decimal CrashId { get; set; }

    public decimal? CrashLocationId { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public int? UsedNarrativeTemplateId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CrashType { get; set; }

    public int? TimAttributeCode { get; set; }

    public int? CrashStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? DataEntryEmployeeId { get; set; }

    public string? CrashNumber { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateClosed { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Narrative { get; set; }

    public string? NarrativeEditedName { get; set; }

    public DateTime? NarrativeEditedOn { get; set; }

    public string? Description { get; set; }

    public string? ReportingUnit { get; set; }

    public string? CrashDetail { get; set; }

    public string? RelatedIncidentNumber { get; set; }

    public bool? IsSuppressed { get; set; }

    public DateTime? SuppressedDt { get; set; }

    public DateTime? ReportStatusDataTime { get; set; }

    public DateTime? CadreportedDateTime { get; set; }

    public string? Cadnumber { get; set; }

    public DateTime? CrashOccuredDtstart { get; set; }

    public DateTime? CrashOccuredDtend { get; set; }

    public string? ReportingUnitShift { get; set; }

    public string? ReportingUnitProvider { get; set; }

    public string? ReportingUnitArea { get; set; }

    public bool? IsLocationValidated { get; set; }

    public string? StateRouteNumber { get; set; }

    public string? Uiaction { get; set; }

    public bool? IsDotsubmitted { get; set; }

    public virtual ICollection<CrashCommentsInvolvement> CrashCommentsInvolvements { get; set; } = new List<CrashCommentsInvolvement>();

    public virtual ICollection<CrashGeneratedReport> CrashGeneratedReports { get; set; } = new List<CrashGeneratedReport>();

    public virtual Mstrlocation? CrashLocation { get; set; }

    public virtual ICollection<CrashOfficialInvolvement> CrashOfficialInvolvements { get; set; } = new List<CrashOfficialInvolvement>();

    public virtual ICollection<CrashPersonInvolvement> CrashPersonInvolvements { get; set; } = new List<CrashPersonInvolvement>();

    public virtual ICollection<CrashPropertyInvolvement> CrashPropertyInvolvements { get; set; } = new List<CrashPropertyInvolvement>();

    public virtual ICollection<CrashRelatedAttachment> CrashRelatedAttachments { get; set; } = new List<CrashRelatedAttachment>();

    public virtual SysApplicationStatus? CrashStatus { get; set; }

    public virtual CrashSummaryDatum? CrashSummaryDatum { get; set; }

    public virtual RefCrashReferenceDatum? CrashTypeNavigation { get; set; }

    public virtual ICollection<CrashVehicleInvolvement> CrashVehicleInvolvements { get; set; } = new List<CrashVehicleInvolvement>();

    public virtual DepartmentEmployee? DataEntryEmployee { get; set; }

    public virtual Department? Department { get; set; }

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual DepartmentEmployee? ReportedEmployee { get; set; }

    public virtual RefCrashReferenceDatum? TimAttributeCodeNavigation { get; set; }

    public virtual RefNarrativeTemplate? UsedNarrativeTemplate { get; set; }
}
