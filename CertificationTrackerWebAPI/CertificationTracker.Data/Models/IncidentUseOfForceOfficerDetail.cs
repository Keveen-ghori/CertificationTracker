using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentUseOfForceOfficerDetail
{
    public decimal IncidentUseOfForceOfficerDetailId { get; set; }

    public decimal? IncidentUseOfForceId { get; set; }

    public int? InvolvedEmployee1 { get; set; }

    public int? InvolvedEmployee2 { get; set; }

    public int? InvolvedEmployee3 { get; set; }

    public int? CanineHandlerEmployeeId { get; set; }

    public string? InvolvedEmployee1ControlMethods { get; set; }

    public string? InvolvedEmployee2ControlMethods { get; set; }

    public string? InvolvedEmployee3ControlMethods { get; set; }

    public string? ArrivalMethods { get; set; }

    public string? ArrivalMethodOtherDesc { get; set; }

    public string? ActionsLeadToIncident { get; set; }

    public string? ActionsLeadToIncidentOtherDesc { get; set; }

    public string? InitialPerception { get; set; }

    public string? InitialPerceptionArmedDesc { get; set; }

    public string? InitialPerceptionOtherDesc { get; set; }

    public string? OfficerComments { get; set; }

    public string? InvolvedEmployee1ControlMethodsOtherDesc { get; set; }

    public string? InvolvedEmployee2ControlMethodsOtherDesc { get; set; }

    public string? InvolvedEmployee3ControlMethodsOtherDesc { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? CanineHandlerEmployee { get; set; }

    public virtual IncidentUseOfForce? IncidentUseOfForce { get; set; }

    public virtual DepartmentEmployee? InvolvedEmployee1Navigation { get; set; }

    public virtual DepartmentEmployee? InvolvedEmployee2Navigation { get; set; }

    public virtual DepartmentEmployee? InvolvedEmployee3Navigation { get; set; }
}
