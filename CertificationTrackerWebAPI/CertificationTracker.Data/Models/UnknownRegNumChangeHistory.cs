using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class UnknownRegNumChangeHistory
{
    public decimal? Mvid { get; set; }

    public decimal? NewMvid { get; set; }

    public string? ChangeTableName { get; set; }

    public string? ChangeFieldName { get; set; }

    public decimal? ChangeTablePk { get; set; }

    public DateTime? AddedOn { get; set; }
}
