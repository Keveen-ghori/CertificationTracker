using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class LnkdrugStatute
{
    public decimal LnkdrugStatuteId { get; set; }

    public int? RefDrugDataId { get; set; }

    public int? RefstatuteDefinition { get; set; }

    public string? Action { get; set; }

    public string? Quantity { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? PersonDrugDepOrNon { get; set; }

    public virtual RefDrugDatum? RefDrugData { get; set; }

    public virtual RefStatuteDefinition? RefstatuteDefinitionNavigation { get; set; }
}
