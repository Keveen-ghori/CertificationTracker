using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonLocation
{
    public decimal MstrpersonLocationId { get; set; }

    public decimal? ResidenceLocId { get; set; }

    public decimal? Mpid { get; set; }

    public decimal? MailLocationId { get; set; }

    public decimal? SecondaryResidenceLocId { get; set; }

    public int? ApplicationType { get; set; }

    public bool? IsCurrentLocation { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Description { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromPersonId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public decimal? CopiedFromPrpersonMstrpersonLocationId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrlocation? MailLocation { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual Mstrlocation? ResidenceLoc { get; set; }

    public virtual Mstrlocation? SecondaryResidenceLoc { get; set; }
}
