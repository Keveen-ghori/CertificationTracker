using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MergePersonApplicationWiseRecordsHistory
{
    public decimal MergePersonApplicationWiseRecordsHistoryId { get; set; }

    public decimal? MergePersonApplicationWiseMasterHistoryId { get; set; }

    public string? TableName { get; set; }

    public decimal? TablePkid { get; set; }

    public string? CopiedStatus { get; set; }

    public string? Comments { get; set; }
}
