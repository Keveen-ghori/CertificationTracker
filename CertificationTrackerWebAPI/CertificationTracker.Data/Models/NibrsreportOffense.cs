using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsreportOffense
{
    public decimal NibrsreportOffenseId { get; set; }

    public decimal? NibrsreportAdminId { get; set; }

    public int? Nibrscode { get; set; }

    public int? OffenseAc { get; set; }

    public string? SuspectedofUsing { get; set; }

    public bool? FamilyViolence { get; set; }

    public bool? GangViolence { get; set; }

    public string? BiasMotivationCode { get; set; }

    public int? LocationTypeCode { get; set; }

    public int? NumPremisesEntered { get; set; }

    public int? EntryMethod { get; set; }

    public string? CriminalActivity { get; set; }

    public string? WeaponForce { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual NibrsreferenceDatum? EntryMethodNavigation { get; set; }

    public virtual NibrsreferenceDatum? LocationTypeCodeNavigation { get; set; }

    public virtual RefNibrscodeDefinition? NibrscodeNavigation { get; set; }

    public virtual NibrsreportAdmin? NibrsreportAdmin { get; set; }

    public virtual NibrsreferenceDatum? OffenseAcNavigation { get; set; }
}
