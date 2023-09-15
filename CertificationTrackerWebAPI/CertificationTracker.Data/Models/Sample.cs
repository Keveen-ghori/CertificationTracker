using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Sample
{
    public int Id { get; set; }

    public byte[]? Drawing { get; set; }

    public string? Drawingstring { get; set; }
}
