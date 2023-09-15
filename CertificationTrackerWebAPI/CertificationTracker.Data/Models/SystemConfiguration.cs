using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SystemConfiguration
{
    public int SystemConfigurationId { get; set; }

    public string? ConfigurationName { get; set; }

    public string? ConfigurationValue { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }
}
