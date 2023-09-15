using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentUseOfForce
{
    public decimal IncidentUseOfForceId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? SupervisorEmployeeId { get; set; }

    public int? SupervisorReviewClassificationCode { get; set; }

    public bool? OfficerInitiated { get; set; }

    public bool? OfficerDispatched { get; set; }

    public bool? WasOfficerFlaggedDown { get; set; }

    public string? PoliceForceLocationCode { get; set; }

    public string? IndoorsPrivatePropertyDesc { get; set; }

    public string? IndoorsPublicBuildingDesc { get; set; }

    public string? EducationalFacilityDesc { get; set; }

    public string? CommercialEstablishmentDesc { get; set; }

    public string? WitnessesIdlst { get; set; }

    public bool? SupervisorNotified { get; set; }

    public DateTime? NotifiedTime { get; set; }

    public bool? SupervisorAtScene { get; set; }

    public string? SupervisorComments { get; set; }

    public string? SubjectResistanceCode { get; set; }

    public string? SubjectArmedAssaultDesc { get; set; }

    public string? SubjectOtherResistenceDesc { get; set; }

    public bool? WasWarningProvidedToSubject { get; set; }

    public string? EmployeeWitnessesIdlst { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual ICollection<IncidentUseOfForceEquipment> IncidentUseOfForceEquipments { get; set; } = new List<IncidentUseOfForceEquipment>();

    public virtual ICollection<IncidentUseOfForceInjuryDetail> IncidentUseOfForceInjuryDetails { get; set; } = new List<IncidentUseOfForceInjuryDetail>();

    public virtual ICollection<IncidentUseOfForceOfficerDetail> IncidentUseOfForceOfficerDetails { get; set; } = new List<IncidentUseOfForceOfficerDetail>();

    public virtual DepartmentEmployee? SupervisorEmployee { get; set; }

    public virtual RefIncidentReferenceDatum? SupervisorReviewClassificationCodeNavigation { get; set; }
}
