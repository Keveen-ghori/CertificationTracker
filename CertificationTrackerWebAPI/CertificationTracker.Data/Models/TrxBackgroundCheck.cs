using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TrxBackgroundCheck
{
    public decimal BackgroundCheckId { get; set; }

    public decimal? CheckedServiceCallPersonId { get; set; }

    public decimal? CheckedServiceCallVehicleId { get; set; }

    public decimal? CheckedMasterPersonId { get; set; }

    public decimal? CheckedMasterVehicleId { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestType { get; set; }

    public string? RequestXml { get; set; }

    public int? ResponseReceived { get; set; }

    public string? ParsedResponseData { get; set; }

    public string? ScreenResponseData { get; set; }

    public DateTime? ResponseDoneDateTime { get; set; }

    public string? RequestBy { get; set; }

    public decimal? CadbackgroundCheckId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual Mstrperson? CheckedMasterPerson { get; set; }

    public virtual Mstrvehicle? CheckedMasterVehicle { get; set; }

    public virtual NonVerifiedCallPerson? CheckedServiceCallPerson { get; set; }

    public virtual NonVerifiedCallVehicle? CheckedServiceCallVehicle { get; set; }

    public virtual ICollection<Mstrperson> Mstrpeople { get; set; } = new List<Mstrperson>();

    public virtual ICollection<Mstrvehicle> Mstrvehicles { get; set; } = new List<Mstrvehicle>();
}
