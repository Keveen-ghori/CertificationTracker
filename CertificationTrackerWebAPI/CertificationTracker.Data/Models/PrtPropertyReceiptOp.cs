using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PrtPropertyReceiptOp
{
    public int? DepartmentId { get; set; }

    public decimal? IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public int? IncidentStatusId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? IncidentLocation { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public decimal? CashValue { get; set; }

    public decimal? Mppid { get; set; }

    public int? PropertyCategoryId { get; set; }

    public int? PropertyNameId { get; set; }

    public int? DrugDataId { get; set; }

    public string? MakerName { get; set; }

    public string? ModelName { get; set; }

    public string? PropertyComment { get; set; }

    public string? MakeModelDesc { get; set; }

    public int? ModelYearDate { get; set; }

    public short? Quantity { get; set; }

    public decimal? PropertyValue { get; set; }

    public string? PropertyBarCode { get; set; }

    public string? PropertySerialId { get; set; }

    public string? PropertyCategory { get; set; }

    public string? PropertyName { get; set; }

    public string? DrugDesc { get; set; }

    public string? DrugCategory { get; set; }

    public string? DrugName { get; set; }

    public string? DrugType { get; set; }

    public string? BrandStampMarking { get; set; }

    public string? DrugQuantity { get; set; }

    public string? Weight { get; set; }

    public string? WeightUnit { get; set; }

    public string? ContainerType { get; set; }

    public string? DrugManuf { get; set; }

    public string? DrugDescription { get; set; }

    public bool? IsFieldTested { get; set; }

    public int? DrugNameId { get; set; }

    public int? TypeOfDrugCode { get; set; }

    public int? UcrcodeId { get; set; }

    public int? ReportDefinitionId { get; set; }

    public string? ReportCategory { get; set; }

    public decimal? OwnerPersonId { get; set; }

    public decimal? OwnerOrgId { get; set; }

    public int? Abandoned { get; set; }

    public int? Evidence { get; set; }

    public int? Found { get; set; }

    public int? Hold { get; set; }

    public int? Recovered { get; set; }

    public int? Safekeep { get; set; }

    public int? Surrendered { get; set; }

    public string? AbandonedLoc { get; set; }

    public string? FoundLoc { get; set; }

    public string? RecoveredLoc { get; set; }

    public string? SeizedLoc { get; set; }

    public DateTime? SeizedDateTime { get; set; }

    public int? StatusCode { get; set; }

    public string? Status { get; set; }

    public int? ActionDoneBy { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public string? ReceivedFromName { get; set; }

    public int? CheckOutReason { get; set; }

    public string? Comment { get; set; }

    public string? CustodyActionBy { get; set; }

    public string? RecovFrom { get; set; }
}
