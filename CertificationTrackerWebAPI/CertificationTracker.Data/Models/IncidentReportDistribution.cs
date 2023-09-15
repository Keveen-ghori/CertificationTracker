using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentReportDistribution
{
    public decimal IncidentReportDistributionId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? DistributedToDepartmentOrgId { get; set; }

    public int? DistributedToDepartmentEmployeeId { get; set; }

    public int? DistributionTypeCode { get; set; }

    public int? DistributedBy { get; set; }

    public string? Notes { get; set; }

    public DateTime? DistributionDt { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? DistributedByNavigation { get; set; }

    public virtual DepartmentEmployee? DistributedToDepartmentEmployee { get; set; }

    public virtual DepartmentOrg? DistributedToDepartmentOrg { get; set; }

    public virtual RefIncidentReferenceDatum? DistributionTypeCodeNavigation { get; set; }

    public virtual Incident? Incident { get; set; }
}
