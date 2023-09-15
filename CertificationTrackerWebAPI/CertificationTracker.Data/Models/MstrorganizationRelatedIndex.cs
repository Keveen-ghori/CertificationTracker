using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrorganizationRelatedIndex
{
    public decimal MorelatedIndexId { get; set; }

    public decimal? RelatedPerson { get; set; }

    public decimal? RelatedVehicle { get; set; }

    public int? RelatedTypeCode { get; set; }

    public decimal? Moid { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public Guid? UniqueId { get; set; }

    public string? LnkcentralMstrorelatedIndex { get; set; }

    public DateTime? LinkedCentralOn { get; set; }

    public string? LinkedCentralName { get; set; }

    public string? OtherOrganizationDetail { get; set; }

    public string? Description { get; set; }

    public decimal? CopiedFromPrpersonMorelatedIndexId { get; set; }

    public virtual Mstrorganization? Mo { get; set; }

    public virtual Mstrperson? RelatedPersonNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? RelatedTypeCodeNavigation { get; set; }

    public virtual Mstrvehicle? RelatedVehicleNavigation { get; set; }
}
