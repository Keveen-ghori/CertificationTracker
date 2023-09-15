using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class NibrsreferenceDatum
{
    public int NibrsreferenceDataId { get; set; }

    public string? DataElement { get; set; }

    public string? DataValue { get; set; }

    public string? DisplayString { get; set; }

    public string? Segment { get; set; }

    public string? RefCategory { get; set; }

    public string? SubCategory { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Description { get; set; }

    public bool? IsDefaultToCategory { get; set; }

    public virtual ICollection<IncidentGeneralCategory> IncidentGeneralCategories { get; set; } = new List<IncidentGeneralCategory>();

    public virtual ICollection<IncidentNibrsoffenseBase> IncidentNibrsoffenseBaseEntryMethodNavigations { get; set; } = new List<IncidentNibrsoffenseBase>();

    public virtual ICollection<IncidentNibrsoffenseBase> IncidentNibrsoffenseBaseLocationTypeCodeNavigations { get; set; } = new List<IncidentNibrsoffenseBase>();

    public virtual ICollection<IncidentNibrsoffenseBase> IncidentNibrsoffenseBaseOffenseAcNavigations { get; set; } = new List<IncidentNibrsoffenseBase>();

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvementLeokaactivityNavigations { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvementLeokaassignmentNavigations { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailNibrsdrugMeasureNavigations { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetailNibrsdrugTypeCodeNavigations { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<Mstrvehicle> Mstrvehicles { get; set; } = new List<Mstrvehicle>();

    public virtual ICollection<NibrsreportAdmin> NibrsreportAdmins { get; set; } = new List<NibrsreportAdmin>();

    public virtual ICollection<NibrsreportOffense> NibrsreportOffenseEntryMethodNavigations { get; set; } = new List<NibrsreportOffense>();

    public virtual ICollection<NibrsreportOffense> NibrsreportOffenseLocationTypeCodeNavigations { get; set; } = new List<NibrsreportOffense>();

    public virtual ICollection<NibrsreportOffense> NibrsreportOffenseOffenseAcNavigations { get; set; } = new List<NibrsreportOffense>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonAdispositionNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonAmultipleArrestNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonAtypeNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonEthnicityCodeNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonRaceCodeNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonResidentStatusCodeNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonSexCodeNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonVcircumstancesAdditionalNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonVofficerActivityNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonVofficerAssignmentNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportPerson> NibrsreportPersonVtypeNavigations { get; set; } = new List<NibrsreportPerson>();

    public virtual ICollection<NibrsreportProperty> NibrsreportProperties { get; set; } = new List<NibrsreportProperty>();

    public virtual ICollection<NibrsreportPropertyDetail> NibrsreportPropertyDetails { get; set; } = new List<NibrsreportPropertyDetail>();

    public virtual ICollection<RefPropertyDatum> RefPropertyData { get; set; } = new List<RefPropertyDatum>();
}
