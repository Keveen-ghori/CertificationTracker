using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptArrestDrugDetail
{
    public decimal IncidentId { get; set; }

    public decimal? IncidentPropertyInvolvementId { get; set; }

    public int? PropertyInvolvementCode { get; set; }

    public string? Involvement { get; set; }

    public string? DrugName { get; set; }

    public string? DrugType { get; set; }

    public string? Quantity { get; set; }

    public string? Weight { get; set; }

    public string? WeightUnit { get; set; }

    public string? Description { get; set; }

    public decimal? TotalValueOfItems { get; set; }

    public string? RefCategory { get; set; }

    public string? PropertyName { get; set; }
}
