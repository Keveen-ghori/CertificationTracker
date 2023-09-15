using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCrashReportHfdActivity
{
    public string? ApplicationNumber { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? ApplicationPkid { get; set; }
}
