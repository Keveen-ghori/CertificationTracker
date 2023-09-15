using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CgsmappingtoNibr
{
    public decimal CgsmappingtoNibrsid { get; set; }

    public string? StatuteCode { get; set; }

    public string? GrName { get; set; }

    public string? Statute { get; set; }

    public string? OffenseType { get; set; }

    public string? OffenseClass { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? RepealDate { get; set; }

    public string? Nibrscode { get; set; }

    public string? Ucrcode { get; set; }

    public bool? MultiNibrs { get; set; }

    public bool? MultiUcr { get; set; }
}
