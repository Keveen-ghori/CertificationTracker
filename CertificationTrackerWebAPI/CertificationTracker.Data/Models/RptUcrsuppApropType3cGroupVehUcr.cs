using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppApropType3cGroupVehUcr
{
    public int DepartmentId { get; set; }

    public int? DeptId { get; set; }

    public string? Name { get; set; }

    public int? IncidentOccuredDtstart { get; set; }

    public int? StolenValue { get; set; }

    public int? RecoveredValue { get; set; }

    public string Rptcategory { get; set; } = null!;
}
