using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EmployeeHistory
{
    public int EmployeeHistoryId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? TransferReason { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }
}
