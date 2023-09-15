using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class HelpQueryVehicleInvolvement
{
    public decimal HelpQueryVehicleInvolvementId { get; set; }

    public decimal? Mvid { get; set; }

    public decimal? CrashVehicleInvolvementId { get; set; }

    public decimal? IncidentVehicleInvolvementId { get; set; }

    public decimal? TrafficStopId { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? FieldInterviewVehicleInvolvmentId { get; set; }

    public string? InvolvementCode { get; set; }

    public string? ApplicationNumber { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public int? InvolvementRefCodeId { get; set; }

    public string? InvolvementRefCodeTable { get; set; }

    public string? MasterIndexTable { get; set; }

    public decimal? MasterIndexId { get; set; }

    public string? FieldName { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual CrashVehicleInvolvement? CrashVehicleInvolvement { get; set; }

    public virtual FieldInterviewVehicleInvolvment? FieldInterviewVehicleInvolvment { get; set; }

    public virtual IncidentVehicleInvolvement? IncidentVehicleInvolvement { get; set; }

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual TrafficStop? TrafficStop { get; set; }
}
