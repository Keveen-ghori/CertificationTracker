using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashVehicleCommericalInfo
{
    public decimal CrashVehicleInvolvementId { get; set; }

    public int? CommercialOrNoncommercial { get; set; }

    public int? GrossVehicleWeightRating { get; set; }

    public int? VehicleConfiguration { get; set; }

    public int? HazardousMaterialsPlacardDisplay { get; set; }

    public int? CargoBodyType { get; set; }

    public int? WereHazardousMaterialsReleased { get; set; }

    public decimal? PowerUnitInformationOwnerAddress { get; set; }

    public decimal? CarrierAddress { get; set; }

    public decimal? TrailerInformationInformationOwnerAddress { get; set; }

    public int? StateIssuingIdentificationNumber { get; set; }

    public int? TrailerLicensePlateIssuingStateCode { get; set; }

    public string? Usdotnumber { get; set; }

    public string? StateIssuedIdentificationNumber { get; set; }

    public string? CarrierName { get; set; }

    public bool? PowerUnitInformationInformationSameAsCarrier { get; set; }

    public string? PowerUnitInformationOwnerName { get; set; }

    public bool? TrailerInformationInformationSameAsOtherTrailer { get; set; }

    public bool? TrailerInformationInformationSameAsPowerUnit { get; set; }

    public bool? TrailerInformationInformationSameAsCarrier { get; set; }

    public string? TrailerInformationOwnerName { get; set; }

    public string? TrailerLicensePlateNumber { get; set; }

    public bool? TrailerLicensePlateWasExpired { get; set; }

    public bool? TrailerLicensePlateWasMissing { get; set; }

    public string? TrailerVehicleIdentificationNumber { get; set; }

    public string? HazardousMaterialsPlacardNumber { get; set; }

    public string? HazardousMaterialsPlacardClassNumber { get; set; }

    public string? HazardousMaterialsDescription { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual RefCrashReferenceDatum? CargoBodyTypeNavigation { get; set; }

    public virtual Mstrlocation? CarrierAddressNavigation { get; set; }

    public virtual RefCrashReferenceDatum? CommercialOrNoncommercialNavigation { get; set; }

    public virtual CrashVehicleInvolvement CrashVehicleInvolvement { get; set; } = null!;

    public virtual RefCrashReferenceDatum? GrossVehicleWeightRatingNavigation { get; set; }

    public virtual RefCrashReferenceDatum? HazardousMaterialsPlacardDisplayNavigation { get; set; }

    public virtual Mstrlocation? PowerUnitInformationOwnerAddressNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? StateIssuingIdentificationNumberNavigation { get; set; }

    public virtual Mstrlocation? TrailerInformationInformationOwnerAddressNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? TrailerLicensePlateIssuingStateCodeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? VehicleConfigurationNavigation { get; set; }

    public virtual RefCrashReferenceDatum? WereHazardousMaterialsReleasedNavigation { get; set; }
}
