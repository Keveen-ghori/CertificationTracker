using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class WarrantOffense
{
    public decimal WarrantOffenseId { get; set; }

    public decimal? WarrantId { get; set; }

    public int? WarrantOffenseCodeId { get; set; }

    public int? AclflagCode { get; set; }

    public int? AgencyId { get; set; }

    public string? Comments { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? Count { get; set; }

    public string? OnOrAboutDate { get; set; }

    public int? OffenseSeq { get; set; }

    public virtual RefIncidentReferenceDatum? AclflagCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? Agency { get; set; }

    public virtual Warrant? Warrant { get; set; }

    public virtual RefStatuteDefinition? WarrantOffenseCode { get; set; }
}
