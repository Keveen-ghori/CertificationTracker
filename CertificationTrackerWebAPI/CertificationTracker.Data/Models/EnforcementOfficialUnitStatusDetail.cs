using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EnforcementOfficialUnitStatusDetail
{
    public decimal EnforcementOfficialUnitStatusDetailId { get; set; }

    public decimal? EnforcementOfficialUnitId { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public int? CadeventUnitActionId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual EnforcementOfficialUnit? EnforcementOfficialUnit { get; set; }
}
