using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TestRmsapplicationDataExportLog
{
    public decimal TestRmsapplicationDataExportLogId { get; set; }

    public decimal RmsapplicationDataExportLogId { get; set; }

    public string? ExportData { get; set; }

    public string? ExportDestination { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public string? ExportStatus { get; set; }

    public string? ExportError { get; set; }

    public string? ResponseData { get; set; }

    public string? Environment { get; set; }

    public string? ExportTrace { get; set; }

    public bool? IsLastExport { get; set; }

    public bool? IsSentToCiss { get; set; }

    public string? SentToCissreason { get; set; }

    public string? ErrorCode { get; set; }

    public string? ActualError { get; set; }

    public string? RequestId { get; set; }

    public string? ApplicationNumber { get; set; }
}
