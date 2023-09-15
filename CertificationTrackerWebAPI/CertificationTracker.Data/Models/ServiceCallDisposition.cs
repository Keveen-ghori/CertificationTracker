using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ServiceCallDisposition
{
    public decimal ServiceCallDispositionId { get; set; }

    public decimal? ServiceCallId { get; set; }

    public int? DispositionCodeId { get; set; }

    public bool? IsDispositionProcess { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? CrashId { get; set; }

    public decimal? ArrestId { get; set; }

    public decimal? CitationTicketId { get; set; }

    public decimal? TicketId { get; set; }

    public virtual RefDispositionCode? DispositionCode { get; set; }

    public virtual ServiceCall? ServiceCall { get; set; }
}
