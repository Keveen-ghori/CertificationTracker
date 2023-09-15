using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrlocationImage
{
    public decimal MstrlocationImageId { get; set; }

    public decimal? LocationId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public byte[]? ImageContent { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Description { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Mstrlocation? Location { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
