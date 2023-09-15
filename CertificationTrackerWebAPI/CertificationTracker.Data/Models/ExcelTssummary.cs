using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ExcelTssummary
{
    public string? Department { get; set; }

    public string? TrafficStopNumber { get; set; }

    public string? CitationTicketNumber { get; set; }

    public string? ResultofStop { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public string? TrafficStopStatus { get; set; }

    public string? ReportedEmployee { get; set; }

    public string? ServiceCallType { get; set; }

    public string? EventTypeCategory { get; set; }

    public string? StatuteCode { get; set; }

    public string? Statue { get; set; }

    public string? HitgislayerName { get; set; }

    public string? HitgeometryName { get; set; }

    public string? StreetName { get; set; }
}
