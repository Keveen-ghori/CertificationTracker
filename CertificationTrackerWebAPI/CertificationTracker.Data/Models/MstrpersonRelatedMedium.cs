using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonRelatedMedium
{
    public decimal MprelatedMediaId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? MmediaInfoId { get; set; }

    public int? ApplicationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Description { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? MediaContentPath { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual MstrmediaContentInfo? MmediaInfo { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
