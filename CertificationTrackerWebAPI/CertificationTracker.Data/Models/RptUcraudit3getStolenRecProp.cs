using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcraudit3getStolenRecProp
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public decimal? StolenPropValue { get; set; }

    public decimal? RecoveredPropValue { get; set; }

    public int StolenVehValue { get; set; }

    public int RecoveredVehValue { get; set; }
}
