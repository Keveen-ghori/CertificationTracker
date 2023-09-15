using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpropertyRelatedMedium
{
    public decimal MpprelatedMediaId { get; set; }

    public decimal? Mppid { get; set; }

    public decimal? MmediaInfoId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? AddedOnCity { get; set; }

    public string? EditedOnCity { get; set; }

    public string? AddedOnState { get; set; }

    public string? EditedOnState { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public Guid? UniqueId { get; set; }

    public string? LnkcentralMstrpropertyRelatedMedia { get; set; }

    public DateTime? LinkedCentralOn { get; set; }

    public string? LinkedCentralName { get; set; }

    public string? Comment { get; set; }

    public virtual MstrmediaContentInfo? MmediaInfo { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }
}
