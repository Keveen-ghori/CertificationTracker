using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptOfficerActivityArrestCustodial
{
    public int? DepartmentId { get; set; }

    public decimal AppId { get; set; }

    public int? OfficerId { get; set; }

    public string? OfficerName { get; set; }

    public string? Rank { get; set; }

    public DateTime? CountDateTime { get; set; }

    public string Category { get; set; } = null!;

    public string Activity { get; set; } = null!;
}
