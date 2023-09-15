using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpropertyDetail
{
    public decimal MstrpropertyDetailId { get; set; }

    public decimal? Mppid { get; set; }

    public int? FirearmCategoryCode { get; set; }

    public int? FirearmMakeCode { get; set; }

    public int? FirearmCaliberCode { get; set; }

    public int? FirearmFinishCode { get; set; }

    public int? FirearmAutomaticIndicatorCode { get; set; }

    public int? FirearmDestroyedIndicatorCode { get; set; }

    public int? PlateRegistrationState { get; set; }

    public int? PlateRegistrationType { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? FirearmBarrelLength { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PlateRegistrationNumber { get; set; }

    public virtual RefMstrinxreferenceDatum? FirearmAutomaticIndicatorCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FirearmCaliberCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FirearmCategoryCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FirearmDestroyedIndicatorCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FirearmFinishCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FirearmMakeCodeNavigation { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual RefMstrinxreferenceDatum? PlateRegistrationStateNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PlateRegistrationTypeNavigation { get; set; }
}
