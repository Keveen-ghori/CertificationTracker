using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentDailyRoster
{
    public decimal DepartmentDailyRosterId { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? DepartmentVehicleId { get; set; }

    public decimal? DepartmentUnitId { get; set; }

    public decimal? DepartmentUnitShiftGroupId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public DateTime? ScheduledStartDateTime { get; set; }

    public DateTime? ScheduledEndDateTime { get; set; }

    public DateTime? OnlineDateTime { get; set; }

    public DateTime? OfflineDateTime { get; set; }

    public int? MappingCadunitShiftStatusId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual DepartmentUnit? DepartmentUnit { get; set; }

    public virtual DepartmentUnitShiftGroup? DepartmentUnitShiftGroup { get; set; }

    public virtual DepartmentVehicle? DepartmentVehicle { get; set; }
}
