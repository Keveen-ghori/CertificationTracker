using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TicketViolation
{
    public decimal TicketViolationId { get; set; }

    public decimal? TicketId { get; set; }

    public int? RefstatuteDefinition { get; set; }

    public int? ViolationId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public short? Sequence { get; set; }

    public bool? Count { get; set; }

    public virtual RefStatuteDefinition? RefstatuteDefinitionNavigation { get; set; }

    public virtual Ticket? Ticket { get; set; }

    public virtual RefViolation? Violation { get; set; }
}
