using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsimportLog
{
    public decimal RmsimportLogId { get; set; }

    public string Category { get; set; } = null!;

    public string? FileName { get; set; }

    public string? FileUploadedRaw { get; set; }

    public DateTime Addedon { get; set; }

    public string AddedName { get; set; } = null!;

    public string? ImportTrace { get; set; }

    public virtual ICollection<DispositionsImport> DispositionsImports { get; set; } = new List<DispositionsImport>();
}
