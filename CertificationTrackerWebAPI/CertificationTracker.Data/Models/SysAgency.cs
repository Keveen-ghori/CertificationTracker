using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysAgency
{
    public int AgencyId { get; set; }

    public string? Name { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Mstrlocation> Mstrlocations { get; set; } = new List<Mstrlocation>();

    public virtual ICollection<Mstrorganization> Mstrorganizations { get; set; } = new List<Mstrorganization>();

    public virtual ICollection<Mstrperson> Mstrpeople { get; set; } = new List<Mstrperson>();

    public virtual ICollection<Mstrproperty> Mstrproperties { get; set; } = new List<Mstrproperty>();

    public virtual ICollection<Mstrvehicle> Mstrvehicles { get; set; } = new List<Mstrvehicle>();

    public virtual ICollection<RefCallForServiceDefinition> RefCallForServiceDefinitions { get; set; } = new List<RefCallForServiceDefinition>();

    public virtual ICollection<RefCallPriority> RefCallPriorities { get; set; } = new List<RefCallPriority>();

    public virtual ICollection<RefCrashReferenceDatum> RefCrashReferenceData { get; set; } = new List<RefCrashReferenceDatum>();

    public virtual ICollection<RefDispositionCode> RefDispositionCodes { get; set; } = new List<RefDispositionCode>();

    public virtual ICollection<RefIncidentReferenceDatum> RefIncidentReferenceData { get; set; } = new List<RefIncidentReferenceDatum>();

    public virtual ICollection<RefMiscReferenceDatum> RefMiscReferenceData { get; set; } = new List<RefMiscReferenceDatum>();

    public virtual ICollection<RefMstrinxreferenceDatum> RefMstrinxreferenceData { get; set; } = new List<RefMstrinxreferenceDatum>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplates { get; set; } = new List<RefNarrativeTemplate>();

    public virtual ICollection<RefNibrscodeDefinition> RefNibrscodeDefinitions { get; set; } = new List<RefNibrscodeDefinition>();

    public virtual ICollection<RefOffenseCodeDefinition> RefOffenseCodeDefinitions { get; set; } = new List<RefOffenseCodeDefinition>();

    public virtual ICollection<RefStatuteDefinition> RefStatuteDefinitions { get; set; } = new List<RefStatuteDefinition>();

    public virtual ICollection<RefTrafficStopTicketReferenceDatum> RefTrafficStopTicketReferenceData { get; set; } = new List<RefTrafficStopTicketReferenceDatum>();

    public virtual ICollection<RefUcrcodeDefinition> RefUcrcodeDefinitions { get; set; } = new List<RefUcrcodeDefinition>();

    public virtual ICollection<RefViolation> RefViolations { get; set; } = new List<RefViolation>();

    public virtual ICollection<SecurityObject> SecurityObjects { get; set; } = new List<SecurityObject>();

    public virtual ICollection<SysImage> SysImages { get; set; } = new List<SysImage>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
