using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentBiasHateCrimeFactorsOffense
{
    public decimal IncidentBiasHateCrimeFactorsOffensesId { get; set; }

    public decimal? IncidentBiasHateCrimeFactorId { get; set; }

    public int? HateCrimeTypeCode { get; set; }

    public int? PlaceofIncidentCode { get; set; }

    public string? VictimTypeCode { get; set; }

    public string? BiasMotivation { get; set; }

    public short? NumOfVictims { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual RefIncidentReferenceDatum? HateCrimeTypeCodeNavigation { get; set; }

    public virtual IncidentBiasHateCrimeFactor? IncidentBiasHateCrimeFactor { get; set; }

    public virtual RefIncidentReferenceDatum? PlaceofIncidentCodeNavigation { get; set; }
}
