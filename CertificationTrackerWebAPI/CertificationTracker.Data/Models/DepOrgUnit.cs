using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepOrgUnit
{
    public decimal DepOrgUnitId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public decimal? DepartmentUnitId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Area { get; set; }

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual DepartmentUnit? DepartmentUnit { get; set; }
}
