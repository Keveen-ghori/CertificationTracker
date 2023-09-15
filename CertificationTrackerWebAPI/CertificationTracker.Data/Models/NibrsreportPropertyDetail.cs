using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsreportPropertyDetail
{
    public decimal NibrsreportPropertyDetailId { get; set; }

    public decimal? NibrsreportPropertyId { get; set; }

    public int? PropertyDescriptionCode { get; set; }

    public decimal? PropertyValue { get; set; }

    public DateTime? RecoveredDate { get; set; }

    public int? NumStolenMv { get; set; }

    public int? NumRecoveredMv { get; set; }

    public string? DrugCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual NibrsreportProperty? NibrsreportProperty { get; set; }

    public virtual NibrsreferenceDatum? PropertyDescriptionCodeNavigation { get; set; }
}
