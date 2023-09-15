using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityGroupMember
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

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
