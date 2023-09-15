using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysApplicationRelationHierarchy
{
    public decimal SysApplicationRelationHierarchyId { get; set; }

    public decimal SysApplicationRelationId { get; set; }

    public int CreatedFromApplicationType { get; set; }

    public decimal CreatedFromApplicationId { get; set; }

    public int GeneratedToApplicationType { get; set; }

    public decimal GeneratedToApplicationId { get; set; }

    public int ParentApplicationType { get; set; }

    public decimal ParentApplicationId { get; set; }

    public DateTime? AddedOn { get; set; }

    public virtual SysApplicationRelation SysApplicationRelation { get; set; } = null!;
}
