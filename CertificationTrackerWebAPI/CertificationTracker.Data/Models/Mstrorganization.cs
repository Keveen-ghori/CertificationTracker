using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Mstrorganization
{
    public decimal Moid { get; set; }

    public decimal? PrimaryLocationId { get; set; }

    public decimal? SecondaryLocationId { get; set; }

    public int? AgencyId { get; set; }

    public int? OrganizationTypeCode { get; set; }

    public decimal? PrimaryOrganizationId { get; set; }

    public string Name { get; set; } = null!;

    public short? OrganizationLevel { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? OrganizationDetailXml { get; set; }

    public Guid? UniqueId { get; set; }

    public string? DayPhoneNumber { get; set; }

    public string? NightPhoneNumber { get; set; }

    public string? EmergencyPhoneNumber { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPersonName { get; set; }

    public string? Description { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromOrganizationId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public bool? IsActive { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookingAttorneyOrgNavigations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingBondCompanyNavigations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<HelpQueryOrganizationInvolvement> HelpQueryOrganizationInvolvements { get; set; } = new List<HelpQueryOrganizationInvolvement>();

    public virtual ICollection<IncidentOrganizationInvolvement> IncidentOrganizationInvolvements { get; set; } = new List<IncidentOrganizationInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<Mstrorganization> InversePrimaryOrganization { get; set; } = new List<Mstrorganization>();

    public virtual ICollection<MstrorganizationImage> MstrorganizationImages { get; set; } = new List<MstrorganizationImage>();

    public virtual ICollection<MstrorganizationRelatedIndex> MstrorganizationRelatedIndices { get; set; } = new List<MstrorganizationRelatedIndex>();

    public virtual ICollection<MstrorganizationRelatedMedium> MstrorganizationRelatedMedia { get; set; } = new List<MstrorganizationRelatedMedium>();

    public virtual ICollection<MstrpropertyOwner> MstrpropertyOwners { get; set; } = new List<MstrpropertyOwner>();

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwners { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPeople { get; set; } = new List<NibrsreportPerson>();

    public virtual RefMstrinxreferenceDatum? OrganizationTypeCodeNavigation { get; set; }

    public virtual Mstrlocation? PrimaryLocation { get; set; }

    public virtual Mstrorganization? PrimaryOrganization { get; set; }

    public virtual Mstrlocation? SecondaryLocation { get; set; }

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();
}
