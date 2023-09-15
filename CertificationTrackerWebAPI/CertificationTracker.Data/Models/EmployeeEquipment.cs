using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EmployeeEquipment
{
    public decimal EmployeeEquipmentId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? EquipmentTypeCode { get; set; }

    public int? EquipmentConditionCode { get; set; }

    public string? SerialNum { get; set; }

    public string? InventoryNum { get; set; }

    public DateTime? DateAssigned { get; set; }

    public DateTime? DateReturned { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Comment { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual RefMiscReferenceDatum? EquipmentConditionCodeNavigation { get; set; }

    public virtual RefMiscReferenceDatum? EquipmentTypeCodeNavigation { get; set; }
}
