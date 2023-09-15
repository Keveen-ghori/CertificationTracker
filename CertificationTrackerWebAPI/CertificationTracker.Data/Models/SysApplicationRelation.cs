using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysApplicationRelation
{
    public decimal MstrapplicationRelationId { get; set; }

    public int? CreatedFromApplication { get; set; }

    public int? GeneratedToApplication { get; set; }

    public string? RelationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public decimal? CreatedFromApplicationPkid { get; set; }

    public decimal? GeneratedToApplicationPkid { get; set; }

    public decimal? CreatedFromInvolvementPkid { get; set; }

    public string? CreatedFromInvolvementTable { get; set; }

    public int? CreatedFromInvolvementCode { get; set; }

    public decimal? GeneratedToInvolvementPkid { get; set; }

    public string? GeneratedToInvolvementTable { get; set; }

    public int? GeneratedToInvolvementCode { get; set; }

    public virtual SysrmsapplicationType? CreatedFromApplicationNavigation { get; set; }

    public virtual SysrmsapplicationType? GeneratedToApplicationNavigation { get; set; }

    public virtual ICollection<SysApplicationRelationHierarchy> SysApplicationRelationHierarchies { get; set; } = new List<SysApplicationRelationHierarchy>();
}
