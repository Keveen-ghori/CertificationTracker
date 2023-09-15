using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefDrugDataAlternative
{
    public decimal RefDrugDataAlternativeId { get; set; }

    public int? DrugDataId { get; set; }

    public int? AltDrugDataId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual RefDrugDatum? AltDrugData { get; set; }

    public virtual RefDrugDatum? DrugData { get; set; }
}
