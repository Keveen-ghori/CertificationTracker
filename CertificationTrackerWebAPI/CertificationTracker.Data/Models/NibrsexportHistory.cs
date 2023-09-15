using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsexportHistory
{
    public decimal NibrsexportHistoryId { get; set; }

    public int? DepartmentId { get; set; }

    public string? FileName { get; set; }

    public string? ExportPath { get; set; }

    public int? ExportMonth { get; set; }

    public int? ExportYear { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? EditedName { get; set; }

    public virtual Department? Department { get; set; }
}
