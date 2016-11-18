using System.Collections.Generic;
using System.IO;
using LiteDB;

namespace Core
{
	public class ConfiguredDrive
	{
        public ObjectId Id { get; set; }
		public DriveInfo Properties { get; set; }
		public Dictionary<string, string> Folders { get; set; }

		public ConfiguredDrive()
		{
			Folders = new Dictionary<string, string>();
		}
	}
}

