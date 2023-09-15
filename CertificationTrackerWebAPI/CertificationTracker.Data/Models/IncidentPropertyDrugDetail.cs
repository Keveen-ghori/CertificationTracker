using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPropertyDrugDetail
{
    public decimal IncidentPropertyDrugDetailId { get; set; }

    public decimal? IncidentPropertyInvolvementId { get; set; }

    public int? DrugNameId { get; set; }

    public int? TypeOfDrugCode { get; set; }

    public int? SuspectArsonByUcr { get; set; }

    public int? DrugWeightUnitsCode { get; set; }

    public int? ContainersCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsWith1500ftofSchoolDayCare { get; set; }

    public Guid? UniqueId { get; set; }

    public string? DrugInvolvementCode { get; set; }

    public string? BrandStampMarking { get; set; }

    public string? Weight { get; set; }

    public string? Quantity { get; set; }

    public string? Manufacture { get; set; }

    public string? Description { get; set; }

    public bool? IsFieldTested { get; set; }

    public int? NibrsdrugTypeCode { get; set; }

    public decimal? NibrsdrugQuantity { get; set; }

    public int? NibrsdrugMeasure { get; set; }

    public virtual RefIncidentReferenceDatum? ContainersCodeNavigation { get; set; }

    public virtual RefDrugDatum? DrugName { get; set; }

    public virtual RefIncidentReferenceDatum? DrugWeightUnitsCodeNavigation { get; set; }

    public virtual IncidentPropertyInvolvement? IncidentPropertyInvolvement { get; set; }

    public virtual NibrsreferenceDatum? NibrsdrugMeasureNavigation { get; set; }

    public virtual NibrsreferenceDatum? NibrsdrugTypeCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? SuspectArsonByUcrNavigation { get; set; }

    public virtual RefDrugDatum? TypeOfDrugCodeNavigation { get; set; }
}
