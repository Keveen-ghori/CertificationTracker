using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcraudit5unionPropVeh
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public decimal? StolenPropValue { get; set; }

    public decimal? RecoveredPropValue { get; set; }

    public decimal? StolenVehValue { get; set; }

    public decimal? RecoveredVehValue { get; set; }
}
