using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class BookingProperty
{
    public decimal BookingPropertyId { get; set; }

    public decimal? ArrestBookingId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Properties { get; set; }

    public bool? IsReceived { get; set; }

    public bool? IsReleased { get; set; }

    public string? Storage { get; set; }

    public string? Other { get; set; }

    public string? Comments { get; set; }

    public decimal? CurrencyBillsTotal { get; set; }

    public decimal? CurrencyCoinsTotal { get; set; }

    public virtual ArrestBooking? ArrestBooking { get; set; }
}
