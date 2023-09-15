using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashOfficialInvolvement
{
    public decimal OfficialInvolvement { get; set; }

    public decimal? CrashId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public string? OfficialInvolvementCode { get; set; }

    public string? AssignedUnit { get; set; }

    public string? AssignedUnitShift { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }
}
