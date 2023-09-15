using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentEmployeeManagement
{
    public int EmployeeManagementId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual DepartmentEmployee? Manager { get; set; }
}
