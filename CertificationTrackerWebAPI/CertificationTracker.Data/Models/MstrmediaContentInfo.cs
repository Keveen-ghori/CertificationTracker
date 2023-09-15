using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrmediaContentInfo
{
    public decimal MmediaInfoId { get; set; }

    public int? MediaType { get; set; }

    public int? MediaCategory { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public bool? IsConfidential { get; set; }

    public string? MediaPhysicalPath { get; set; }

    public string? MediaName { get; set; }

    public virtual RefMstrinxreferenceDatum? MediaCategoryNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? MediaTypeNavigation { get; set; }

    public virtual ICollection<MstrlocationRelatedMedium> MstrlocationRelatedMedia { get; set; } = new List<MstrlocationRelatedMedium>();

    public virtual ICollection<MstrorganizationRelatedMedium> MstrorganizationRelatedMedia { get; set; } = new List<MstrorganizationRelatedMedium>();

    public virtual ICollection<MstrpersonPhysicalFeature> MstrpersonPhysicalFeatures { get; set; } = new List<MstrpersonPhysicalFeature>();

    public virtual ICollection<MstrpersonRelatedMedium> MstrpersonRelatedMedia { get; set; } = new List<MstrpersonRelatedMedium>();

    public virtual ICollection<MstrpropertyRelatedMedium> MstrpropertyRelatedMedia { get; set; } = new List<MstrpropertyRelatedMedium>();

    public virtual ICollection<MstrvehicleRelatedMedium> MstrvehicleRelatedMedia { get; set; } = new List<MstrvehicleRelatedMedium>();
}
