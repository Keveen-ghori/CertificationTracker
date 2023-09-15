using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrvehicleStatus
{
    public decimal MstrvehicleStatusId { get; set; }

    public decimal? Mvid { get; set; }

    public decimal? StatusLocationId { get; set; }

    public int? VehicleStatusCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Description { get; set; }

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual Mstrlocation? StatusLocation { get; set; }

    public virtual RefMstrinxreferenceDatum? VehicleStatusCodeNavigation { get; set; }
}
