using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrreturnA3aArresteeAge
{
    public decimal IncidentId { get; set; }

    public int? DepartmentId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public int? PersonInvolvementCode { get; set; }

    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public bool? IsMasterName { get; set; }
}
