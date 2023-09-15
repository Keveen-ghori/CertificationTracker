using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RestoreCancelledApplicationDatum
{
    public decimal RestoreCancelledApplicationDataId { get; set; }

    public int? DepartmentId { get; set; }

    public int? ApplicationType { get; set; }

    public decimal? ApplicationPkid { get; set; }

    public string? ApplicationNumber { get; set; }

    public string? ApplicationData { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Department? Department { get; set; }
}
