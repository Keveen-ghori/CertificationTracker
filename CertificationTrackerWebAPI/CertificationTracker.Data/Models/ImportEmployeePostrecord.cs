using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ImportEmployeePostrecord
{
    public int Id { get; set; }

    public string? Employee { get; set; }

    public string? Rank { get; set; }

    public decimal? PostId { get; set; }

    public DateTime? CertificationDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? ImportedSuccessfully { get; set; }

    public int? DepartmentEmployeeId { get; set; }
}
