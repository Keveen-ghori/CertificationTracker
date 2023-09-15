using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdataDeleteTrace
{
    public decimal RmsdataDeleteTraceId { get; set; }

    public string? DeletedRecordTableName { get; set; }

    public string? DeletedRecordPkcolumnName { get; set; }

    public string? DeletedRecordPkvalue { get; set; }

    public string? DeleteValueList { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public decimal? RmsuserAccessId { get; set; }
}
