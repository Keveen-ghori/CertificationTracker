using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPuofSummary
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string? ViewIncidentUrl { get; set; }

    public string? UniqueId { get; set; }

    public DateTime? InvolvementDateTime { get; set; }

    public int OfficerId { get; set; }

    public string? OfficerName { get; set; }

    public string? SupvisorName { get; set; }

    public string IsOfficerInitiated { get; set; } = null!;

    public string IsOfficerDispatched { get; set; } = null!;

    public string WasOfficerFlaggedDown { get; set; } = null!;

    public string? PoliceForceLocationCode { get; set; }

    public string? LocationDescription { get; set; }

    public string? EmployeeWitnessesIdlst { get; set; }

    public string? ArrivalMethods { get; set; }

    public string? Employee1ControlMethods { get; set; }

    public string? InvolvedEmployee1ControlMethodsOtherDesc { get; set; }

    public string? ActivityThatLedtoIncident { get; set; }

    public string? ActionsLeadToIncidentOtherDesc { get; set; }

    public string? InitialPerception { get; set; }

    public string? InitialPerceptionArmedDesc { get; set; }

    public string? InitialPerceptionOtherDesc { get; set; }

    public string? SubjectResistence { get; set; }

    public string? SubOtherResistanceDesc { get; set; }

    public string? SuspectName { get; set; }

    public decimal? SuspectId { get; set; }

    public string? SubjRace { get; set; }

    public string? SubjEthn { get; set; }

    public string? SubjSex { get; set; }

    public DateTime? SubjDob { get; set; }

    public int? SubjAge { get; set; }

    public string? SuspInjury { get; set; }

    public string? SubjOtherInjury { get; set; }

    public string SubjHosptialization { get; set; } = null!;

    public string SubjWarned { get; set; } = null!;

    public string? OfficerCheckedByMed { get; set; }

    public string? OfficerInjury { get; set; }

    public string? OfficerInjuryOther { get; set; }

    public string OfficerHospitalization { get; set; } = null!;

    public string? OfficerHospital { get; set; }

    public string? ImpactWeaponBaton { get; set; }

    public string? Ocspray { get; set; }

    public string? Dcfaweapon { get; set; }

    public string? Dcfasubject { get; set; }

    public string? Dcfaresult { get; set; }

    public string? ImpactMunition { get; set; }

    public string? ChemicalMunitions { get; set; }

    public string? EdwdeploymentType { get; set; }

    public string? EdwtypeofForcePrior { get; set; }

    public string? EdwtypeofForceAfter { get; set; }

    public string EdwdeadlyForceJustified { get; set; } = null!;

    public string? OfficerComments { get; set; }
}
