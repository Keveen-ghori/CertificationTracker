using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentOutOfTownWarrant
{
    public decimal IncidentOutOfTownWarrantId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? ReasonForContactCode { get; set; }

    public int? WantedAgencyNameCode { get; set; }

    public decimal? ArrestLocationId { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? OtherReasonDescriptioon { get; set; }

    public DateTime? CustodialTransferDt { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public virtual Mstrlocation? ArrestLocation { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual RefIncidentReferenceDatum? ReasonForContactCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? WantedAgencyNameCodeNavigation { get; set; }
}
