using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsdataChangeTrace
{
    public decimal RmsdataChangeTraceId { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public string? ChangedTableName { get; set; }

    public string? ChangedTablePkcolumnName { get; set; }

    public string? ChangedTablePkcolumnValue { get; set; }

    public string? ChangeValueList { get; set; }

    public decimal? RmsuserAccessId { get; set; }
}
