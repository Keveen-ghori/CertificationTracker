using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentUseOfForceInjuryDetail
{
    public decimal IncidentUseOfForceInjuryDetailId { get; set; }

    public decimal? IncidentUseOfForceId { get; set; }

    public int? OfficerCheckedByMedicalCode { get; set; }

    public int? SubjectCheckedByMedicalCode { get; set; }

    public string? OfficerType { get; set; }

    public string? OfficerTypeOtherDesc { get; set; }

    public bool? OfficerTransported { get; set; }

    public string? OfficerHospital { get; set; }

    public string? SubjectType { get; set; }

    public string? SubjectTypeOtherDesc { get; set; }

    public bool? SubjectTransported { get; set; }

    public string? SubjectHospital { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual IncidentUseOfForce? IncidentUseOfForce { get; set; }

    public virtual RefIncidentReferenceDatum? OfficerCheckedByMedicalCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? SubjectCheckedByMedicalCodeNavigation { get; set; }
}
