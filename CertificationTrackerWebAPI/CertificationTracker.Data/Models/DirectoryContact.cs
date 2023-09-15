using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class DirectoryContact
{
    public decimal DirectoryContactId { get; set; }

    public decimal? AddressDirecctoryId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? ContactTitle { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsPrimaryContact { get; set; }

    public int? ContactSeq { get; set; }

    public bool? IsAfterHourContact { get; set; }

    public bool? IsBuildingOwner { get; set; }

    public bool? IsKeyHolder { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual AddressDirecctory? AddressDirecctory { get; set; }

    public virtual ICollection<NotificationMethod> NotificationMethods { get; set; } = new List<NotificationMethod>();
}
