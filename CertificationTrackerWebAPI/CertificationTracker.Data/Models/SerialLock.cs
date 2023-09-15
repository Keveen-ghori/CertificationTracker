using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SerialLock
{
    public int Id { get; set; }

    public string ResourceName { get; set; } = null!;

    public bool IsSet { get; set; }

    public Guid? OwnerId { get; set; }
}
