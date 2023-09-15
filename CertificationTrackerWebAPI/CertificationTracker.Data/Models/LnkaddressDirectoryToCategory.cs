using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class LnkaddressDirectoryToCategory
{
    public decimal LnkaddressDirectoryToCategoryId { get; set; }

    public decimal? AddressDirecctoryId { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual AddressDirecctory? AddressDirecctory { get; set; }

    public virtual RefDirectoryCategory? Category { get; set; }
}
