using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SummonsInfraction
{
    public decimal SummonsInfractionId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? BondType { get; set; }

    public string? SummonsNumber { get; set; }

    public DateTime? CourtDate { get; set; }

    public decimal? BondAmount { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? CourtDispositionRaw { get; set; }

    public string? CdDocketNumber { get; set; }

    public DateTime? CdDispositionDate { get; set; }

    public DateTime? CdErasureDate { get; set; }

    public string? CdYoswitch { get; set; }

    public string? CdRearrestIndicator { get; set; }

    public DateTime? CdAppealFiledDate { get; set; }

    public DateTime? CdAppealDecidedDate { get; set; }

    public decimal? CdBondForfeitureAmount { get; set; }

    public decimal? CdCostAmount { get; set; }

    public int? CdCostIndicator { get; set; }

    public string? CdCibindicator { get; set; }

    public string? CdDispositionMessage { get; set; }

    public string? CdAdditionalTicketNumbers { get; set; }

    public string? CdAdditionalPdandCaseNumbers { get; set; }

    public string? CdRevisedIndicator { get; set; }

    public string? CdCsindicator { get; set; }

    public decimal? TrafficStopId { get; set; }

    public DateTime? ArrestDate { get; set; }

    public int? CourtCode { get; set; }

    public bool? IsStudent { get; set; }

    public virtual RefIncidentReferenceDatum? BondTypeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CdCostIndicatorNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CourtCodeNavigation { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual TrafficStop? TrafficStop { get; set; }
}
