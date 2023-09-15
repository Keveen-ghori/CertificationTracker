using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonMugShot
{
    public decimal MstrpersonMugShotId { get; set; }

    public decimal? Mpid { get; set; }

    public int? ApplicationType { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Description { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsCurrentRecord { get; set; }

    public decimal? CopiedFromPrpersonMstrpersonMugShotId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual ICollection<MstrpersonMugShotImage> MstrpersonMugShotImages { get; set; } = new List<MstrpersonMugShotImage>();
}
