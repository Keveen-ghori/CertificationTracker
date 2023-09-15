using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrasrjuvDrugTotalM
{
    public int? DepartmentId { get; set; }

    public DateTime? ArrestDate { get; set; }

    public string? OffenseClass { get; set; }

    public string? Gender { get; set; }

    public int? Under10 { get; set; }

    public int? _1012 { get; set; }

    public int? _1314 { get; set; }

    public int? _15 { get; set; }

    public int? _16 { get; set; }

    public int? _17 { get; set; }

    public int? White { get; set; }

    public int? Black { get; set; }

    public int? AmericanIndianAknative { get; set; }

    public int? AsianPacificIslander { get; set; }

    public int? OtherUnknown { get; set; }

    public int? MiddleEastern { get; set; }

    public int? Hispanic { get; set; }

    public int? Na { get; set; }

    public string SoP { get; set; } = null!;
}
