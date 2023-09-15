using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonContactDetail
{
    public decimal MstrcontactId { get; set; }

    public decimal? Mpid { get; set; }

    public int? ApplicationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? LnkcentralMstrpersonContactDetail { get; set; }

    public DateTime? LinkedCentralOn { get; set; }

    public string? LinkedCentralName { get; set; }

    public string? Description { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public bool? IsCurrentContact { get; set; }

    public string? ContactDetailXml { get; set; }

    public decimal? CopiedFromPrpersonMstrcontactId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
