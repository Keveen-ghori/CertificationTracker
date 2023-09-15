using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefViolation
{
    public int ViolationId { get; set; }

    public int? RefstatuteDefinition { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ViolationName { get; set; }

    public short? ViolationType { get; set; }

    public short? CourtCode { get; set; }

    public decimal? FineAmount { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }

    public virtual RefStatuteDefinition? RefstatuteDefinitionNavigation { get; set; }

    public virtual ICollection<TicketViolation> TicketViolations { get; set; } = new List<TicketViolation>();

    public virtual ICollection<TrafficStopViolation> TrafficStopViolations { get; set; } = new List<TrafficStopViolation>();
}
