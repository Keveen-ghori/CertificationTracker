using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsreportProperty
{
    public decimal NibrsreportPropertyId { get; set; }

    public decimal? NibrsreportAdminId { get; set; }

    public int? PropertyLossCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual NibrsreportAdmin? NibrsreportAdmin { get; set; }

    public virtual ICollection<NibrsreportPropertyDetail> NibrsreportPropertyDetails { get; set; } = new List<NibrsreportPropertyDetail>();

    public virtual NibrsreferenceDatum? PropertyLossCodeNavigation { get; set; }
}
