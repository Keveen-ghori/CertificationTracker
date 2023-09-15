using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsreportAdmin
{
    public decimal NibrsreportAdminId { get; set; }

    public bool? CargoTheft { get; set; }

    public DateTime? ExportDate { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public int? ClearanceCode { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? BypassedErrors { get; set; }

    public DateTime? LastExportDate { get; set; }

    public virtual NibrsreferenceDatum? ClearanceCodeNavigation { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual ICollection<NibrsreportOffense> NibrsreportOffenses { get; set; } = new List<NibrsreportOffense>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPeople { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportProperty> NibrsreportProperties { get; set; } = new List<NibrsreportProperty>();

    public virtual Incident? PrimaryIncident { get; set; }
}
