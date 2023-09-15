using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DataProcessRuleCondition
{
    public decimal DataProcessRuleConditionId { get; set; }

    public decimal? DataProcessRuleId { get; set; }

    public decimal? ExtCoditionValueDataItemId { get; set; }

    public int? ExtCoditionValueProcessDetailStepId { get; set; }

    public int? ConditionSeq { get; set; }

    public string? Comparisonmethod { get; set; }

    public bool? IsExpectComparedNumericValue { get; set; }

    public string? ExpectValue { get; set; }

    public string? Name { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ExpectValue1 { get; set; }

    public string? SpecialConditionName { get; set; }

    public virtual DataProcessRule? DataProcessRule { get; set; }

    public virtual DataProcessStepDataItem? ExtCoditionValueDataItem { get; set; }

    public virtual DataProcessDetailStep? ExtCoditionValueProcessDetailStep { get; set; }
}
