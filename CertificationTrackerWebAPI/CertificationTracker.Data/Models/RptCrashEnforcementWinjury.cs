using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCrashEnforcementWinjury
{
    public decimal CrashId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CrashStatusId { get; set; }

    public string? CrashNumber { get; set; }

    public DateTime? CrashOccuredDtstart { get; set; }

    public decimal? CrashPersonInvolvementId { get; set; }

    public int? CrashPersonInvolvementCode { get; set; }

    public int? ActionTakenByOfficer { get; set; }

    public string? ActionTaken { get; set; }

    public string? CrashType { get; set; }

    public string? Injury { get; set; }
}
