using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefMstrinxreferenceDatum
{
    public int MstrinxreferenceDataId { get; set; }

    public int? AgencyId { get; set; }

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

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoStateIssuingIdentificationNumberNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoTrailerLicensePlateIssuingStateCodeNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailPerpetratorSexCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetailVictimSexCodeNavigations { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<MstrlocationAlert> MstrlocationAlerts { get; set; } = new List<MstrlocationAlert>();

    public virtual ICollection<MstrmediaContentInfo> MstrmediaContentInfoMediaCategoryNavigations { get; set; } = new List<MstrmediaContentInfo>();

    public virtual ICollection<MstrmediaContentInfo> MstrmediaContentInfoMediaTypeNavigations { get; set; } = new List<MstrmediaContentInfo>();

    public virtual ICollection<MstrorganizationRelatedIndex> MstrorganizationRelatedIndices { get; set; } = new List<MstrorganizationRelatedIndex>();

    public virtual ICollection<Mstrorganization> Mstrorganizations { get; set; } = new List<Mstrorganization>();

    public virtual ICollection<MstrpersonAlert> MstrpersonAlerts { get; set; } = new List<MstrpersonAlert>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicBuildCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicComplexionCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicDexterityCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicDrugInvolveCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicEducationCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicEyeColorCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicEyewearDescriptionCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicFacialHairCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicHairColorCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicHairLengthCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicHairStyleCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicIsAlcoholProblemPresentNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicIsNarcoticsProblemPresentNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicMaritalStatusCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicMobilityDisabilityCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicNoseCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicOccupationCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicPersonBirthCountryCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicPersonBirthStateCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicPersonNationalityCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicPrimaryLanguageNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicScarMarkTattooCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicSkinToneCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicSpeechDescriptionCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonCharacteristic> MstrpersonCharacteristicTeethCodeNavigations { get; set; } = new List<MstrpersonCharacteristic>();

    public virtual ICollection<MstrpersonFingerprintSet> MstrpersonFingerprintSetFingerPositionCodeNavigations { get; set; } = new List<MstrpersonFingerprintSet>();

    public virtual ICollection<MstrpersonFingerprintSet> MstrpersonFingerprintSetFingerPositionIndicatorCodeNavigations { get; set; } = new List<MstrpersonFingerprintSet>();

    public virtual ICollection<MstrpersonIdentification> MstrpersonIdentifications { get; set; } = new List<MstrpersonIdentification>();

    public virtual ICollection<MstrpersonMugShotImage> MstrpersonMugShotImages { get; set; } = new List<MstrpersonMugShotImage>();

    public virtual ICollection<MstrpersonName> MstrpersonNameNameCategoryCodeNavigations { get; set; } = new List<MstrpersonName>();

    public virtual ICollection<MstrpersonName> MstrpersonNamePersonSexCodeNavigations { get; set; } = new List<MstrpersonName>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenseDriverLicenseClassificationCodeNavigations { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenseDriverLicenseJurisdictionCodeNavigations { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenseDriverLicenseStateNavigations { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenseDriverLicenseStatusCodeNavigations { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<MstrpersonOperatorLicense> MstrpersonOperatorLicenseDrivingRestrictionCodeNavigations { get; set; } = new List<MstrpersonOperatorLicense>();

    public virtual ICollection<Mstrperson> MstrpersonPersonBloodTypeCodeNavigations { get; set; } = new List<Mstrperson>();

    public virtual ICollection<Mstrperson> MstrpersonPersonEthnicityCodeNavigations { get; set; } = new List<Mstrperson>();

    public virtual ICollection<Mstrperson> MstrpersonPersonRaceCodeNavigations { get; set; } = new List<Mstrperson>();

    public virtual ICollection<MstrpersonPhysicalFeature> MstrpersonPhysicalFeatureFeatureCodeNavigations { get; set; } = new List<MstrpersonPhysicalFeature>();

    public virtual ICollection<MstrpersonPhysicalFeature> MstrpersonPhysicalFeatureFeatureLocationCodeNavigations { get; set; } = new List<MstrpersonPhysicalFeature>();

    public virtual ICollection<MstrpersonRelation> MstrpersonRelations { get; set; } = new List<MstrpersonRelation>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailFirearmAutomaticIndicatorCodeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailFirearmCaliberCodeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailFirearmCategoryCodeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailFirearmDestroyedIndicatorCodeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailFirearmFinishCodeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailFirearmMakeCodeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailPlateRegistrationStateNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrpropertyDetail> MstrpropertyDetailPlateRegistrationTypeNavigations { get; set; } = new List<MstrpropertyDetail>();

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwnerRegStateNavigations { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual ICollection<MstrvehicleRegOwner> MstrvehicleRegOwnerRegTypeNavigations { get; set; } = new List<MstrvehicleRegOwner>();

    public virtual ICollection<MstrvehicleStatus> MstrvehicleStatuses { get; set; } = new List<MstrvehicleStatus>();

    public virtual ICollection<Mstrvehicle> Mstrvehicles { get; set; } = new List<Mstrvehicle>();

    public virtual ICollection<NonVerifiedCallPerson> NonVerifiedCallPeople { get; set; } = new List<NonVerifiedCallPerson>();

    public virtual ICollection<NotificationMethod> NotificationMethods { get; set; } = new List<NotificationMethod>();
}
