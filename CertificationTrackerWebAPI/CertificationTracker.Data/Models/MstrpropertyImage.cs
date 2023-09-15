using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpropertyImage
{
    public decimal MstrpropertyImageId { get; set; }

    public decimal? Mppid { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public byte[]? ImageContent { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Description { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ImageContentPath { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
