using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PrtPropertyReceipt4custody
{
    public int? DepartmentId { get; set; }

    public decimal? IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public int? IncidentStatusId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? StatusCode { get; set; }

    public string? Status { get; set; }

    public int? ActionDoneBy { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public string? ReceivedFromName { get; set; }

    public int? CheckOutReason { get; set; }

    public string? Comment { get; set; }

    public string? CustodyActionBy { get; set; }

    public decimal? Mppid { get; set; }
}
