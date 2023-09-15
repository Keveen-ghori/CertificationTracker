using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PostcostRank
{
    public decimal PostcostRankId { get; set; }

    public decimal? PostcostPeriodId { get; set; }

    public string? RankName { get; set; }

    public decimal? HourlyRate { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual PostcostPeriod? PostcostPeriod { get; set; }
}
