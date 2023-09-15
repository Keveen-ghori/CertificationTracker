using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentGeneralCategory
{
    public decimal IncidentGeneralCategoryId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? UcrcodeId { get; set; }

    public int? NibrscodeId { get; set; }

    public int? Ucrclearance { get; set; }

    public int? Nibrsclearance { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? PickUpCategoryGroup { get; set; }

    public string? PickUpClassification { get; set; }

    public string? PickUpStatuteCode { get; set; }

    public string? Source { get; set; }

    public bool? IsSystemGenerated { get; set; }

    public int? HierarchyRank { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public DateTime? NibrsclearanceDate { get; set; }

    public bool? NeedsVerification { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual ICollection<IncidentNibrsoffenseBase> IncidentNibrsoffenseBases { get; set; } = new List<IncidentNibrsoffenseBase>();

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual NibrsreferenceDatum? NibrsclearanceNavigation { get; set; }

    public virtual RefNibrscodeDefinition? Nibrscode { get; set; }

    public virtual RefIncidentReferenceDatum? UcrclearanceNavigation { get; set; }

    public virtual RefUcrcodeDefinition? Ucrcode { get; set; }
}
