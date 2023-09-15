using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrvehicleRegOwner
{
    public decimal MstrvehicleRegOwnerId { get; set; }

    public decimal? Mvid { get; set; }

    public decimal? VehicleOwnerId { get; set; }

    public int? RegState { get; set; }

    public decimal? VehicleOrgId { get; set; }

    public int? RegType { get; set; }

    public int? ApplicationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public bool? IsCurrentOwner { get; set; }

    public string? RegNum { get; set; }

    public int? RegYear { get; set; }

    public DateTime? RegExpire { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromVehicleId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public decimal? GeneratedByRmsuserQueryResultId { get; set; }

    public decimal? NonVerifiedOwnerPersonId { get; set; }

    public virtual SysrmsapplicationType? ApplicationTypeNavigation { get; set; }

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual NonVerifiedCallPerson? NonVerifiedOwnerPerson { get; set; }

    public virtual RefMstrinxreferenceDatum? RegStateNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? RegTypeNavigation { get; set; }

    public virtual Mstrorganization? VehicleOrg { get; set; }

    public virtual Mstrperson? VehicleOwner { get; set; }
}
