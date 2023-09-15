using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MissingPersonApplicationWiseRecordsHistory
{
    public decimal MissingPersonApplicationWiseRecordsHistoryId { get; set; }

    public decimal? Mpid { get; set; }

    public string? TableName { get; set; }

    public decimal? TablePkid { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? CopiedStatus { get; set; }

    public string? Comments { get; set; }
}
