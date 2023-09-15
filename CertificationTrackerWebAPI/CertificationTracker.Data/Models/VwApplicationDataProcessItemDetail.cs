using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class VwApplicationDataProcessItemDetail
{
    public string? StepName { get; set; }

    public decimal? ProcessControllerId { get; set; }

    public int? StepSequence { get; set; }

    public string? StepItemName { get; set; }

    public string? StepItemType { get; set; }

    public string? DefaultValue { get; set; }

    public string? StepItemDesciption { get; set; }

    public int? ItemSequence { get; set; }

    public string? StepStatus { get; set; }

    public string? UserAnswer { get; set; }

    public string? DataBindingXml { get; set; }

    public decimal StepItemDefinitionId { get; set; }

    public decimal StepItemId { get; set; }

    public string? UserAnswerStr { get; set; }

    public int? MaxLength { get; set; }
}
