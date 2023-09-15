using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonPhysicalFeature
{
    public decimal MpphysicalFeatureId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? FeatureMediaId { get; set; }

    public int? FeatureCode { get; set; }

    public int? FeatureLocationCode { get; set; }

    public int? ApplicationType { get; set; }

    public string? PhysicalFeatureDescription { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Description { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public byte[]? FeatureImage { get; set; }

    public string? ImageContentPath { get; set; }

    public decimal? CopiedFromPrpersonMpphysicalFeatureId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FeatureCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FeatureLocationCodeNavigation { get; set; }

    public virtual MstrmediaContentInfo? FeatureMedia { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
