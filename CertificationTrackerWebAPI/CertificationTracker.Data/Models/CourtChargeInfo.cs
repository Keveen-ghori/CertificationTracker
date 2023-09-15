using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CourtChargeInfo
{
    public decimal CourtChargeInfoId { get; set; }

    public decimal? ArrestBookingId { get; set; }

    public decimal? OffenseId { get; set; }

    public string? CourtDocketNum { get; set; }

    public string? Disposition { get; set; }

    public DateTime? DispositionDate { get; set; }

    public string? Sentence { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual ArrestBooking? ArrestBooking { get; set; }

    public virtual Offense? Offense { get; set; }
}
