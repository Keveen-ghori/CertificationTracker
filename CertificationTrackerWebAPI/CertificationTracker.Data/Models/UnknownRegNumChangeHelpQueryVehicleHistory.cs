using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class UnknownRegNumChangeHelpQueryVehicleHistory
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

    public decimal? OldMvid { get; set; }

    public decimal? NewMvid { get; set; }

    public bool? IsSuccess { get; set; }

    public string? ErrorMessage { get; set; }
}
