using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonMedicalCondition
{
    public decimal MstrpersonMedicalConditionId { get; set; }

    public decimal? Mpid { get; set; }

    public int? ApplicationType { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsCurrentCodition { get; set; }

    public string? Conditions { get; set; }

    public string? Comments { get; set; }

    public string? Other { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public decimal? CopiedFromPrpersonMstrpersonMedicalConditionId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }
}
