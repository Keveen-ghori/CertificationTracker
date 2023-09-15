using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CorrectionMergedPersonsHistory
{
    public decimal PrpersonMpid { get; set; }

    public decimal? RelatedPkpersonMpid { get; set; }

    public DateTime? MergedAtTime { get; set; }

    public string? StatusofMergeData { get; set; }

    public string? ExtraComments { get; set; }
}
