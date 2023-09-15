using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentBiasHateCrimeFactor
{
    public decimal IncidentBiasHateCrimeFactorId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? OffenderEthnicityCode { get; set; }

    public int? OffenderRaceCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public short? NumberofOffendersUnder18 { get; set; }

    public short? NumberofIndividualVictimsunder18 { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public short? NumberofIndividualVictims18andOver { get; set; }

    public short? NumberofOffenders18andOver { get; set; }

    public bool? InitialBox { get; set; }

    public bool? AdjustmentBox { get; set; }

    public bool? DeleteBox { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual ICollection<IncidentBiasHateCrimeFactorsOffense> IncidentBiasHateCrimeFactorsOffenses { get; set; } = new List<IncidentBiasHateCrimeFactorsOffense>();

    public virtual RefIncidentReferenceDatum? OffenderEthnicityCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? OffenderRaceCodeNavigation { get; set; }
}
