using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepApplicationUsage
{
    public int DepApplicationUsageId { get; set; }

    public int? SysapplicationTypeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? ApplicationSeq { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ApplicationNumberGeneratedMethod { get; set; }

    public bool? IsActive { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<ReportContainer> ReportContainers { get; set; } = new List<ReportContainer>();

    public virtual SysrmsapplicationType? SysapplicationType { get; set; }
}
