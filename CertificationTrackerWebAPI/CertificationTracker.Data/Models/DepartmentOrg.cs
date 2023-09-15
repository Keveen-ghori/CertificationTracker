using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DepartmentOrg
{
    public decimal DepartmentOrgId { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? RootOrgId { get; set; }

    public int? CategoryCode { get; set; }

    public string? OrgName { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public virtual RefMiscReferenceDatum? CategoryCodeNavigation { get; set; }

    public virtual ICollection<DepOrgEmployee> DepOrgEmployees { get; set; } = new List<DepOrgEmployee>();

    public virtual ICollection<DepOrgUnit> DepOrgUnits { get; set; } = new List<DepOrgUnit>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentUnit> DepartmentUnits { get; set; } = new List<DepartmentUnit>();

    public virtual ICollection<DepartmentVehicle> DepartmentVehicles { get; set; } = new List<DepartmentVehicle>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagementInvestigativeGroups { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagementInvestigativeSupervisorOrgs { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<IncidentReportDistribution> IncidentReportDistributions { get; set; } = new List<IncidentReportDistribution>();

    public virtual ICollection<IndividualSecurityToUser> IndividualSecurityToUsers { get; set; } = new List<IndividualSecurityToUser>();

    public virtual ICollection<DepartmentOrg> InverseRootOrg { get; set; } = new List<DepartmentOrg>();

    public virtual ICollection<RmsdeptWorkFlowReviewRequirement> RmsdeptWorkFlowReviewRequirements { get; set; } = new List<RmsdeptWorkFlowReviewRequirement>();

    public virtual ICollection<RmsworkFlowController> RmsworkFlowControllers { get; set; } = new List<RmsworkFlowController>();

    public virtual DepartmentOrg? RootOrg { get; set; }

    public virtual ICollection<SysNotificationAction> SysNotificationActions { get; set; } = new List<SysNotificationAction>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUis { get; set; } = new List<SysapplicationStatusAllowedUi>();
}
