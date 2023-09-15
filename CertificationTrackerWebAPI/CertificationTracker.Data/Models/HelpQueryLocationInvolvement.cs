using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class HelpQueryLocationInvolvement
{
    public decimal HelpQueryLocationInvolvementId { get; set; }

    public decimal? LocationId { get; set; }

    public int? ApplicationType { get; set; }

    public string? InvolvementCode { get; set; }

    public string? ApplicationNumber { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? LocationDirectoryName { get; set; }

    public int? InvolvementRefCodeId { get; set; }

    public string? InvolvementRefCodeTable { get; set; }

    public string? ApplicationInvolvementTable { get; set; }

    public decimal? ApplicationInvolvementId { get; set; }

    public string? MasterIndexTable { get; set; }

    public decimal? MasterIndexId { get; set; }

    public string? FieldName { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrlocation? Location { get; set; }
}
