using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EnforcementOfficialUnit
{
    public decimal EnforcementOfficialUnitId { get; set; }

    public decimal? ServiceCallId { get; set; }

    public decimal? CadunitOnlineId { get; set; }

    public string? UnitName { get; set; }

    public string? UnitType { get; set; }

    public string? UnitProvider { get; set; }

    public string? Shift { get; set; }

    public DateTime? SchOnlineTime { get; set; }

    public DateTime? OnlineTime { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? OfflineTime { get; set; }

    public DateTime? SchOfflineTime { get; set; }

    public DateTime? DateAssigned { get; set; }

    public DateTime? DateActive { get; set; }

    public DateTime? DateClosed { get; set; }

    public DateTime? DateClear { get; set; }

    public string? UnitBeatAssignmentXml { get; set; }

    public string? ClearanceCode { get; set; }

    public string? ResourceType { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? VehicleId { get; set; }

    public string? Dispatcher { get; set; }

    public string? UnitReportingArea { get; set; }

    public virtual ICollection<EnforcementOfficialUnitStatusDetail> EnforcementOfficialUnitStatusDetails { get; set; } = new List<EnforcementOfficialUnitStatusDetail>();

    public virtual ServiceCall? ServiceCall { get; set; }

    public virtual ICollection<ServiceCallDispatchedOffical> ServiceCallDispatchedOfficals { get; set; } = new List<ServiceCallDispatchedOffical>();
}
