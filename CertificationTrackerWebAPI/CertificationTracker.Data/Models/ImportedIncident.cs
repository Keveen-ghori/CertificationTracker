using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ImportedIncident
{
    public decimal IncidentId { get; set; }

    public decimal PrimaryIncidentId { get; set; }

    public decimal? PrimaryLocationId { get; set; }

    public DateTime? CadreprotedDateTime { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? DataEntryEmployeeId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public DateTime? IncidentOccuredDtend { get; set; }

    public string? IncidentNumber { get; set; }

    public string? Narrative { get; set; }

    public string? NarrativeEditedName { get; set; }

    public DateTime? NarrativeEditedOn { get; set; }

    public DateTime AddedOn { get; set; }

    public string? AddedName { get; set; }

    public string? LocationDescription { get; set; }

    public decimal UserAccessId { get; set; }

    public int? ApproverEmployeeId { get; set; }

    public string? ImportStatus { get; set; }

    public string? ImportComments { get; set; }

    public string? ClassificationType { get; set; }

    public string? Classification { get; set; }

    public virtual RmsuserAccessTrace UserAccess { get; set; } = null!;
}
