using System.Collections.Generic;

namespace AutoBackUp.Models
{
    public class ConfiguredDrive
    {
        public DriveProperties Properties { get; set; }
        public Dictionary<string, string> Folders { get; set; }
        public ConfiguredDrive()
        {
            Folders = new Dictionary<string, string>();
        }
    }

    public class DriveProperties
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public long Size { get; set; }
        public long Used { get; set; }
        public long Free
        {
            get
            {
                return Size - Used;
            }
        }
    }
}