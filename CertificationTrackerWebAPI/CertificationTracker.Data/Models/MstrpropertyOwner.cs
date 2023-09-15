using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpropertyOwner
{
    public decimal MstrpropertyOwnerId { get; set; }

    public decimal? Mppid { get; set; }

    public decimal? PropertyOwnerId { get; set; }

    public decimal? PropertyOrgOwnerId { get; set; }

    public int? ApplicationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public bool? IsCurrentOwner { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual Mstrorganization? PropertyOrgOwner { get; set; }

    public virtual Mstrperson? PropertyOwner { get; set; }
}
