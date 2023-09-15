using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class HelpQueryOrganizationInvolvement
{
    public decimal HelpQueryOrganizationInvolvementId { get; set; }

    public decimal? Moid { get; set; }

    public decimal? IncidentOrganizationInvolvementId { get; set; }

    public int? ApplicationType { get; set; }

    public string? InvolvementCode { get; set; }

    public string? ApplicationNumber { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public int? InvolvementRefCodeId { get; set; }

    public string? InvolvementRefCodeTable { get; set; }

    public string? MasterIndexTable { get; set; }

    public decimal? MasterIndexId { get; set; }

    public string? FieldName { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual IncidentOrganizationInvolvement? IncidentOrganizationInvolvement { get; set; }

    public virtual Mstrorganization? Mo { get; set; }
}
