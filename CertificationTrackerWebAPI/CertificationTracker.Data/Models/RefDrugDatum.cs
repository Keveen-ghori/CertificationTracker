using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefDrugDatum
{
    public int RefDrugDataId { get; set; }

    public int? DepartmentId { get; set; }

    public string? DisplayString { get; set; }

    public string? Description { get; set; }

    public bool? IsSystemData { get; set; }

    public int? DisplaySeq { get; set; }

    public string? RefCategory { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DataValue { get; set; }

    public bool? IsDefaultToCategory { get; set; }

    public string? SubRefCategory { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public string? Rptcode { get; set; }

    public string? Rptcategory { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailDrugNames { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailTypeOfDrugCodeNavigations { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<LnkdrugStatute> LnkdrugStatutes { get; set; } = new List<LnkdrugStatute>();

    public virtual ICollection<Mstrproperty> Mstrproperties { get; set; } = new List<Mstrproperty>();

    public virtual ICollection<RefDrugDataAlternative> RefDrugDataAlternativeAltDrugData { get; set; } = new List<RefDrugDataAlternative>();

    public virtual ICollection<RefDrugDataAlternative> RefDrugDataAlternativeDrugData { get; set; } = new List<RefDrugDataAlternative>();
}
