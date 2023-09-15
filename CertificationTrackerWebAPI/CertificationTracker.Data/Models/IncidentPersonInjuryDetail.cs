using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPersonInjuryDetail
{
    public decimal IncidentPersonInjuryDetailId { get; set; }

    public int? InjuryTypeCode { get; set; }

    public int? InjuredTransportationSourceCode { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? InjuryStatusCode { get; set; }

    public string? InjuryCategory { get; set; }

    public DateTime? InjuryDate { get; set; }

    public string? Emsname { get; set; }

    public string? EmsrunNumber { get; set; }

    public string? MedicalFacility { get; set; }

    public string? InjuryServerity { get; set; }

    public string? InjuryLocation { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Comment { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual RefIncidentReferenceDatum? InjuredTransportationSourceCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? InjuryStatusCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? InjuryTypeCodeNavigation { get; set; }
}
