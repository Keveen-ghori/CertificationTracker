using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptPforce2bGetAllWeaponTypeText
{
    public decimal? IncidentId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public string? WeaponTypeId { get; set; }

    public string? WeaponType { get; set; }
}
