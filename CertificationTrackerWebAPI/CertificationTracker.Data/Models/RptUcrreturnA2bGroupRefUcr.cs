using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrreturnA2bGroupRefUcr
{
    public int DepartmentId { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }

    public bool? IsActive { get; set; }

    public string? Name { get; set; }

    public string? Ucrcode { get; set; }
}
