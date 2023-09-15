using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? DepartmentEmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? UserEmail { get; set; }

    public string? SignaturePassword { get; set; }

    public DateTime? PasswordExpiry { get; set; }

    public string? ChallengeQuestion1 { get; set; }

    public string? ChallengeAnswer1 { get; set; }

    public string? ChallengeQuestion2 { get; set; }

    public string? ChallengeAnswer2 { get; set; }

    public string? ChallengeQuestion3 { get; set; }

    public string? ChallengeAnswer3 { get; set; }

    public string? UserProfileXml { get; set; }

    public bool? IsTerminated { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DirectoryId { get; set; }

    public bool? IsDemoUser { get; set; }

    public byte[]? SignatureStroke { get; set; }

    public string? CriminalJusticeAccessUserName { get; set; }

    public string? CriminalJusticeAccessPassword { get; set; }

    public string? CriminalJusticeAccessExpiry { get; set; }

    public string? CriminalJusticeAccessCertNum { get; set; }

    public string? SecurePassword { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual Department? Department { get; set; }

    public virtual DepartmentEmployee? DepartmentEmployee { get; set; }

    public virtual ICollection<SecurityObjectTouserRole> SecurityObjectTouserRoles { get; set; } = new List<SecurityObjectTouserRole>();

    public virtual ICollection<SecurityRoleToUser> SecurityRoleToUsers { get; set; } = new List<SecurityRoleToUser>();

    public virtual ICollection<UserToken> UserTokens { get; set; } = new List<UserToken>();
}
