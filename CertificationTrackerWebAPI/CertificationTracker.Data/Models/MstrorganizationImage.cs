using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrorganizationImage
{
    public decimal MstrorganizationImageId { get; set; }

    public decimal? Moid { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public byte[]? ImageContent { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Description { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Mstrorganization? Mo { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
