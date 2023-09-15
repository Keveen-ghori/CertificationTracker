using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrlocationRelatedMedium
{
    public decimal MlrelatedMediaId { get; set; }

    public decimal? MmediaInfoId { get; set; }

    public decimal? LocationId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? EntityCommentsXml { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsPrimary { get; set; }

    public virtual Mstrlocation? Location { get; set; }

    public virtual MstrmediaContentInfo? MmediaInfo { get; set; }
}
