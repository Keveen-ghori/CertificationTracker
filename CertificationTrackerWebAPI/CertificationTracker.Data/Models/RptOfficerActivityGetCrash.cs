﻿using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptOfficerActivityGetCrash
{
    public int? DepartmentId { get; set; }

    public decimal CrashId { get; set; }

    public string? CrashReportedOfficer { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public string? Rank { get; set; }

    public string? CrashNumber { get; set; }

    public DateTime? CrashOccuredDtstart { get; set; }

    public int NumCase { get; set; }

    public int NumCaseNc { get; set; }

    public int NumArrest { get; set; }

    public int NumArrestMisd { get; set; }

    public int NumWarrant { get; set; }

    public int NumAccident { get; set; }

    public int NumTicketUar { get; set; }

    public int NumTicketMisdemeanor { get; set; }

    public int NumTicketInfraction { get; set; }

    public int NumTicketWrittenWarning { get; set; }

    public int NumTicketVerbalWarning { get; set; }

    public int NumTicketNoDisposition { get; set; }

    public int NumTicketCrashInfraction { get; set; }

    public int NumTicketCrashWarning { get; set; }

    public int NumTicketCitationOnly { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
