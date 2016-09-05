using System.Collections.Generic;

namespace Core
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
}

