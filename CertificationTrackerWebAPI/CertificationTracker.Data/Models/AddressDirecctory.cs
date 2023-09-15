using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class AddressDirecctory
{
    public decimal AddressDirecctoryId { get; set; }

    public decimal? DirectoryLocationId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? NameOfDirectory { get; set; }

    public string? DirectoryPhoneNumber { get; set; }

    public string? ImportSource { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsActive { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<DirectoryContact> DirectoryContacts { get; set; } = new List<DirectoryContact>();

    public virtual Mstrlocation? DirectoryLocation { get; set; }

    public virtual ICollection<LnkaddressDirectoryToCategory> LnkaddressDirectoryToCategories { get; set; } = new List<LnkaddressDirectoryToCategory>();

    public virtual ICollection<TowRequest> TowRequests { get; set; } = new List<TowRequest>();
}
