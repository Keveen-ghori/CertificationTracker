using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefDispositionCode
{
    public int DispositionCodeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsGeneratedIncidentReport { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsGeneratedIncidentSupplement { get; set; }

    public bool? IsGeneratedCrash { get; set; }

    public bool? IsGeneratedCitation { get; set; }

    public bool? IsGeneratedTicket { get; set; }

    public bool? IsGeneratedBooking { get; set; }

    public int? DisplaySeq { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual ICollection<ServiceCallDisposition> ServiceCallDispositions { get; set; } = new List<ServiceCallDisposition>();
}
