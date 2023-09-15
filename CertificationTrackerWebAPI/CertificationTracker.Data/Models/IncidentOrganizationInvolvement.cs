using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentOrganizationInvolvement
{
    public decimal IncidentOrganizationInvolvementId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? Moid { get; set; }

    public int? OrganizationInvolvementCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public bool? ExcludeForNibrsdetail { get; set; }

    public virtual ICollection<HelpQueryOrganizationInvolvement> HelpQueryOrganizationInvolvements { get; set; } = new List<HelpQueryOrganizationInvolvement>();

    public virtual Incident? Incident { get; set; }

    public virtual Mstrorganization? Mo { get; set; }

    public virtual ICollection<NibrsreportPerson> NibrsreportPeople { get; set; } = new List<NibrsreportPerson>();

    public virtual RefIncidentReferenceDatum? OrganizationInvolvementCodeNavigation { get; set; }
}
