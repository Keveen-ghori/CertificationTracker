using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptTcexportLog
{
    public int? DepartmentId { get; set; }

    public string? ReportedEmployee { get; set; }

    public string? TrafficStopNumber { get; set; }

    public string? TicketNumber { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public DateTime? ExportedOn { get; set; }

    public string? ExportStatus { get; set; }

    public string? ExportError { get; set; }
}
