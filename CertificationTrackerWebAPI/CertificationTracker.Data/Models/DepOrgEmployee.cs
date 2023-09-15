using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepOrgEmployee
{
    public decimal DepOrgEmployeeId { get; set; }

    public decimal? DepartmentOrgId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? DirectSupervisorId { get; set; }

    public bool? IsOrgSupervisor { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual DepartmentOrg? DepartmentOrg { get; set; }

    public virtual DepartmentEmployee? DirectSupervisor { get; set; }
}
