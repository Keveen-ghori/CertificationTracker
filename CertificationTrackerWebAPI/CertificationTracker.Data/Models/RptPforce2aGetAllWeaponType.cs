using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce2aGetAllWeaponType
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? WeaponType { get; set; }
}
