using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentUseOfForceEquipment
{
    public decimal IncidentUseOfForceEquipmentId { get; set; }

    public decimal? IncidentUseOfForceId { get; set; }

    public string? EquipmentContactPoints { get; set; }

    public string? EdwcontactPoints { get; set; }

    public bool? ImpactWeaponNa { get; set; }

    public string? ImpactWeaponType { get; set; }

    public string? ImpactWeaponNumOfStrikes { get; set; }

    public bool? OcsprayNa { get; set; }

    public bool? OcsprayDecont { get; set; }

    public bool? OcsprayMedTreatment { get; set; }

    public bool? OcsprayEffective { get; set; }

    public string? OcsprayNumApplications { get; set; }

    public bool? DischargeFirearmNa { get; set; }

    public string? DischargeFirearmWeapon { get; set; }

    public string? DischargeFirearmSubject { get; set; }

    public string? DischargeFirearmResult { get; set; }

    public bool? ImpactMunitionsNa { get; set; }

    public string? ImpactMunitionsHit { get; set; }

    public string? ImpactMunitionsType { get; set; }

    public string? ImpactMunitionsFired { get; set; }

    public bool? ImpactMunitionsEffective { get; set; }

    public bool? ChemicalMunitionsNa { get; set; }

    public string? ChemicalMunitionsHit { get; set; }

    public string? ChemicalMunitionsType { get; set; }

    public string? ChemicalMunitionsFired { get; set; }

    public bool? ChemicalMunitionsEffective { get; set; }

    public bool? Edwna { get; set; }

    public string? EdwdeploymentType { get; set; }

    public string? EdwdeployedSerialNum { get; set; }

    public string? EdwcartridgesDeployedSerialNum { get; set; }

    public string? EdwtypeCartridge { get; set; }

    public string? EdwlengthDisplayOrArcs { get; set; }

    public string? EdwlengthDriveStun { get; set; }

    public string? EdwlengthDactivationsAfterProbe { get; set; }

    public string? EdwtimeElapsedBetween { get; set; }

    public string? EdwcartridgesMissedImpactLoc { get; set; }

    public string? EdwtypeofForcePrior { get; set; }

    public string? EdwtypeofForceAfter { get; set; }

    public bool? EdwdeadlyForceJustified { get; set; }

    public string? EdwdownloadedBy { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual IncidentUseOfForce? IncidentUseOfForce { get; set; }
}
