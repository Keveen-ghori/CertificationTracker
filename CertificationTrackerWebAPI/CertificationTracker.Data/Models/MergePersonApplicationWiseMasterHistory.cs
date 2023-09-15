using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MergePersonApplicationWiseMasterHistory
{
    public decimal MergePersonApplicationWiseMasterHistoryId { get; set; }

    public decimal? Prmpid { get; set; }

    public decimal? Pkmpid { get; set; }

    public string? Comments { get; set; }

    public DateTime? CopiedProcessDateTime { get; set; }

    public Guid? CopiedProcessUniqueId { get; set; }
}
