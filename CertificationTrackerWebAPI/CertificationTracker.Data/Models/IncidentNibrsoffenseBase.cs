using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentNibrsoffenseBase
{
    public decimal IncidentNibrsoffenseBaseId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public int? OffenseAc { get; set; }

    public string? SuspectedofUsing { get; set; }

    public bool? GangViolence { get; set; }

    public string? BiasMotivationCode { get; set; }

    public int? LocationTypeCode { get; set; }

    public int? NumPremisesEntered { get; set; }

    public int? EntryMethod { get; set; }

    public string? CriminalActivity { get; set; }

    public string? WeaponForce { get; set; }

    public bool? CargoTheft { get; set; }

    public bool? PoliceOfficerKilledorAssaulted { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? IncidentGeneralCategoryId { get; set; }

    public string? Source { get; set; }

    public virtual NibrsreferenceDatum? EntryMethodNavigation { get; set; }

    public virtual IncidentGeneralCategory? IncidentGeneralCategory { get; set; }

    public virtual NibrsreferenceDatum? LocationTypeCodeNavigation { get; set; }

    public virtual NibrsreferenceDatum? OffenseAcNavigation { get; set; }

    public virtual Incident? PrimaryIncident { get; set; }
}
