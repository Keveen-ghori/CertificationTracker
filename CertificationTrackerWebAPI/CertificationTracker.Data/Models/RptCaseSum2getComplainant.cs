using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCaseSum2getComplainant
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public string? SurName { get; set; }

    public string? GivenName { get; set; }
}
