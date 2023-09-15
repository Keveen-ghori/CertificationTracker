using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptRpsexRace
{
    public int? DepartmentId { get; set; }

    public decimal TrafficStopId { get; set; }

    public DateTime? TrafficStopDateTime { get; set; }

    public string? ResultofStop { get; set; }

    public string? Sex { get; set; }

    public string? Race { get; set; }

    public int? PersonEthnicityCode { get; set; }

    public string? Ethnicity { get; set; }
}
