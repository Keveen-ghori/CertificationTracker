using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Mstrproperty
{
    public decimal Mppid { get; set; }

    public int? AgencyId { get; set; }

    public int? PropertyCategoryId { get; set; }

    public int? PropertyNameId { get; set; }

    public int? DrugDataId { get; set; }

    public string? PrimaryColor { get; set; }

    public string? BrandName { get; set; }

    public string? MakerName { get; set; }

    public string? ModelName { get; set; }

    public int? ModelYearDate { get; set; }

    public short? Quantity { get; set; }

    public string? Style { get; set; }

    public decimal? PropertyValue { get; set; }

    public string? PropertyBarCode { get; set; }

    public string? PropertySerialId { get; set; }

    public string? PropertyFederalIdentification { get; set; }

    public string? PropertyNcicidentification { get; set; }

    public string? QuantityUnit { get; set; }

    public string? Measurement { get; set; }

    public string? MeasurementUnit { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public string? PropertyDetailXml { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Comment { get; set; }

    public bool? IsIncludingPackage { get; set; }

    public string? CollectMessageNumber { get; set; }

    public bool? IsSerialnumberobliterated { get; set; }

    public string? Status { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromPropertyId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public bool? IsActive { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<CrashPropertyInvolvement> CrashPropertyInvolvements { get; set; } = new List<CrashPropertyInvolvement>();

    public virtual RefDrugDatum? DrugData { get; set; }

    public virtual ICollection<HelpQueryPropertyInvolvement> HelpQueryPropertyInvolvements { get; set; } = new List<HelpQueryPropertyInvolvement>();

    public virtual ICollection<IncidentForceInvolvement> IncidentForceInvolvements { get; set; } = new List<IncidentForceInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetails { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyImage> MstrpropertyImages { get; set; } = new List<MstrpropertyImage>();

    public virtual ICollection<MstrpropertyOwner> MstrpropertyOwners { get; set; } = new List<MstrpropertyOwner>();

    public virtual ICollection<MstrpropertyRelatedMedium> MstrpropertyRelatedMedia { get; set; } = new List<MstrpropertyRelatedMedium>();

    public virtual RefPropertyDatum? PropertyCategory { get; set; }

    public virtual RefPropertyDatum? PropertyName { get; set; }

    public virtual ICollection<PropertyRoomItem> PropertyRoomItems { get; set; } = new List<PropertyRoomItem>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();
}
