using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RmsapplicationDataExportLog
{
    public decimal RmsapplicationDataExportLogId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ExportData { get; set; }

    public string? ExportDestination { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }

    public string? ExportStatus { get; set; }

    public string? ExportError { get; set; }

    public decimal? ApplicationPkid { get; set; }

    public string? ResponseData { get; set; }

    public string? ApplicationNumber { get; set; }

    public string? Environment { get; set; }

    public string? ExportTrace { get; set; }

    public bool? IsLastExport { get; set; }

    public string? CissrequestId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }
}
