using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentUnitShiftGroup
{
    public decimal DepartmentUnitShiftGroupId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ShiftGroupName { get; set; }

    public string? Description { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentDailyRoster> DepartmentDailyRosters { get; set; } = new List<DepartmentDailyRoster>();
}
