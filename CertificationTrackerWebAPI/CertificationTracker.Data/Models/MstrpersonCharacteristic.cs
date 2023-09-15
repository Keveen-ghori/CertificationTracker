using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class MstrpersonCharacteristic
{
    public decimal MstrpersonCharacteristicId { get; set; }

    public decimal? Mpid { get; set; }

    public int? HairStyleCode { get; set; }

    public int? EyeColorCode { get; set; }

    public int? HairColorCode { get; set; }

    public int? SkinToneCode { get; set; }

    public int? MaritalStatusCode { get; set; }

    public int? FacialHairCode { get; set; }

    public int? EyewearDescriptionCode { get; set; }

    public int? MobilityDisabilityCode { get; set; }

    public int? BuildCode { get; set; }

    public int? TeethCode { get; set; }

    public int? SpeechDescriptionCode { get; set; }

    public int? EducationCode { get; set; }

    public int? NoseCode { get; set; }

    public int? DrugInvolveCode { get; set; }

    public int? ComplexionCode { get; set; }

    public int? DexterityCode { get; set; }

    public int? PersonNationalityCode { get; set; }

    public int? OccupationCode { get; set; }

    public int? HairLengthCode { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public int? PrimaryLanguage { get; set; }

    public int? PersonBirthStateCode { get; set; }

    public int? PersonBirthCountryCode { get; set; }

    public int? HeightFrom { get; set; }

    public int? WeightFrom { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? RecordEffectedOn { get; set; }

    public DateTime? RecordExpiratedOn { get; set; }

    public int? IsAlcoholProblemPresent { get; set; }

    public int? IsNarcoticsProblemPresent { get; set; }

    public bool? IsEnglishSpeaking { get; set; }

    public bool? IsFamilyViolencePresent { get; set; }

    public string? ApplicationNumber { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Description { get; set; }

    public bool? IsCurrentRecord { get; set; }

    public string? ClothDesc { get; set; }

    public string? MotherMaidenName { get; set; }

    public bool? IsTwin { get; set; }

    public int? HeightTo { get; set; }

    public int? WeightTo { get; set; }

    public string? PersonBirthTown { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromPersonId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public decimal? CopiedFromPrpersonMstrpersonCharacteristicId { get; set; }

    public int? ScarMarkTattooCode { get; set; }

    public virtual RefMstrinxreferenceDatum? BuildCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? ComplexionCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DexterityCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? DrugInvolveCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? EducationCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? EyeColorCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? EyewearDescriptionCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? FacialHairCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? HairColorCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? HairLengthCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? HairStyleCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? IsAlcoholProblemPresentNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? IsNarcoticsProblemPresentNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? MaritalStatusCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? MobilityDisabilityCodeNavigation { get; set; }

    public virtual Mstrperson? Mp { get; set; }

    public virtual RefMstrinxreferenceDatum? NoseCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? OccupationCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonBirthCountryCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonBirthStateCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PersonNationalityCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PrimaryLanguageNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? ScarMarkTattooCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? SkinToneCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? SpeechDescriptionCodeNavigation { get; set; }

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }

    public virtual RefMstrinxreferenceDatum? TeethCodeNavigation { get; set; }
}
