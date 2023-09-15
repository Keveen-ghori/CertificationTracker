using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcraudit4getStolenRecVeh
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public int StolenPropValue { get; set; }

    public int RecoveredPropValue { get; set; }

    public decimal? StolenVehValue { get; set; }

    public decimal? RecoveredVehValue { get; set; }
}
