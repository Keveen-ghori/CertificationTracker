using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentInvestigationManagement
{
    public decimal IncidentInvestigationManagementId { get; set; }

    public int? InvestigativeStatusReasonCodeId { get; set; }

    public decimal? InvestigativeGroupId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? InvestigativeEmployeeId { get; set; }

    public int? InvestigativeStatusId { get; set; }

    public decimal? InvestigativeSupervisorOrgId { get; set; }

    public int? InvestigativeSupervisorId { get; set; }

    public string? InvestigavtiveStatusComment { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? ReviewedBy { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual DepartmentEmployee? InvestigativeEmployee { get; set; }

    public virtual DepartmentOrg? InvestigativeGroup { get; set; }

    public virtual SysApplicationStatus? InvestigativeStatus { get; set; }

    public virtual RefIncidentReferenceDatum? InvestigativeStatusReasonCode { get; set; }

    public virtual DepartmentEmployee? InvestigativeSupervisor { get; set; }

    public virtual DepartmentOrg? InvestigativeSupervisorOrg { get; set; }
}
