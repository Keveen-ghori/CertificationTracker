using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class UnknownNameChangeHistory
{
    public decimal? Mpid { get; set; }

    public decimal? NewMpid { get; set; }

    public string? ChangeTableName { get; set; }

    public string? ChangeFieldName { get; set; }

    public decimal? ChangeTablePk { get; set; }

    public DateTime? AddedOn { get; set; }
}
