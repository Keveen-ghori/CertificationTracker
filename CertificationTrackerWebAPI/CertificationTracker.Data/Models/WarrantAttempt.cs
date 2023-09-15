using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class WarrantAttempt
{
    public decimal WarrantAttemptId { get; set; }

    public decimal? WarrantId { get; set; }

    public decimal? LocationId { get; set; }

    public int? AttemptOfficerName { get; set; }

    public int? AttemptTypeCode { get; set; }

    public DateTime? AttemptDate { get; set; }

    public string? AttemptStatus { get; set; }

    public string? Comments { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual DepartmentEmployee? AttemptOfficerNameNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? AttemptTypeCodeNavigation { get; set; }

    public virtual Mstrlocation? Location { get; set; }

    public virtual Warrant? Warrant { get; set; }
}
