using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class FieldInterview
{
    public decimal FieldInterviewId { get; set; }

    public int? InterviewOfficerId { get; set; }

    public int? DataEntryEmployeeId { get; set; }

    public decimal? LocationId { get; set; }

    public int? FistatusId { get; set; }

    public int? SuppressedById { get; set; }

    public DateTime? InterviewDatetime { get; set; }

    public string? Remarks { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? FieldInterviewNumber { get; set; }

    public string? ReportingUnit { get; set; }

    public string? ReportingUnitShift { get; set; }

    public string? ReportingUnitProvider { get; set; }

    public string? ReportingUnitArea { get; set; }

    public bool? IsSuppressed { get; set; }

    public DateTime? SuppressedDateTime { get; set; }

    public int? DepartmentId { get; set; }

    public string? Cadnumber { get; set; }

    public virtual DepartmentEmployee? DataEntryEmployee { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<FieldInterviewPersonInvolvment> FieldInterviewPersonInvolvments { get; set; } = new List<FieldInterviewPersonInvolvment>();

    public virtual ICollection<FieldInterviewVehicleInvolvment> FieldInterviewVehicleInvolvments { get; set; } = new List<FieldInterviewVehicleInvolvment>();

    public virtual SysApplicationStatus? Fistatus { get; set; }

    public virtual DepartmentEmployee? InterviewOfficer { get; set; }

    public virtual Mstrlocation? Location { get; set; }

    public virtual DepartmentEmployee? SuppressedBy { get; set; }
}
