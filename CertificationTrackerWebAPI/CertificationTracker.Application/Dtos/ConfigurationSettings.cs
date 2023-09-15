using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationTracker.Application.Dtos
{
    public class ConfigurationSettings
    {
        public bool IsInMaintenanceMode { get; set; } = false;
        public string Version { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string PublishedDate { get; set; } = string.Empty;
        public string CopyRight { get; set; } = string.Empty;
        public string AnnouncementText { get; set; } = string.Empty;
    }
}
