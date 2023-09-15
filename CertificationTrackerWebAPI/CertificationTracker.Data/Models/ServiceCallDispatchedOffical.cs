using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ServiceCallDispatchedOffical
{
    public decimal ServiceCallDispatchedOfficalId { get; set; }

    public decimal? EnforcementOfficialUnitId { get; set; }

    public int? AssignedOfficalId { get; set; }

    public string? AssignmentCategoryCode { get; set; }

    public decimal? CadonlineUnitEmployeeId { get; set; }

    public string? AssignedOfficalName { get; set; }

    public bool? IsNumberHolder { get; set; }

    public string? HoldingNumber { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual DepartmentEmployee? AssignedOffical { get; set; }

    public virtual EnforcementOfficialUnit? EnforcementOfficialUnit { get; set; }
}
