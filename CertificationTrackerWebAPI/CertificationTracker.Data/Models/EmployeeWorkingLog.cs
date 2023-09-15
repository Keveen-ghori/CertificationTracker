using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EmployeeWorkingLog
{
    public decimal EmployeeWorkingLogId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? WorkingApplicationType { get; set; }

    public decimal? WorkingApplicationPkid { get; set; }

    public string? WorkingStatus { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual SysrmsapplicationType? WorkingApplicationTypeNavigation { get; set; }
}
