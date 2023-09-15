using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefNarrativeTemplate
{
    public int MstrnarrativeTemplateId { get; set; }

    public int? DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public int? TemplateTypeCode { get; set; }

    public int? EmployeeSpecify { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public string? TemplateName { get; set; }

    public string? Template { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public string? Description { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public int? AddedById { get; set; }

    public int? EditedById { get; set; }

    public virtual DepartmentEmployee? AddedBy { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookings { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<Crash> Crashes { get; set; } = new List<Crash>();

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? EditedBy { get; set; }

    public virtual DepartmentEmployee? EmployeeSpecifyNavigation { get; set; }

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }

    public virtual RefMiscReferenceDatum? TemplateTypeCodeNavigation { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();

    public virtual ICollection<Warrant> Warrants { get; set; } = new List<Warrant>();
}
