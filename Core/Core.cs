using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;
using LiteDB;

namespace Core
{
	public class Core
	{
        private static string DBPATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AutoBackUp" + Path.PathSeparator + "DataStore.db");

        public List<DriveInfo> GetConnectedUSBStorageDevices()
        {
            return DriveInfo.GetDrives().Where(s => s.DriveType == DriveType.Removable && s.IsReady).ToList();
        }

        public static bool SaveDriveConfig(ConfiguredDrive configuredDrive)
        {
            try
            {
                var db = new LiteDatabase(DBPATH);
                var driveCollection = db.GetCollection<ConfiguredDrive>("drives");
                driveCollection.Insert(configuredDrive);
                driveCollection.EnsureIndex(x => x.Properties.Name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<ConfiguredDrive> GetConfiguredDrives()
        {
            try
            {
                var db = new LiteDatabase(DBPATH);
                var driveCollection = db.GetCollection<ConfiguredDrive>("drives");
                return driveCollection.FindAll().ToList();
            }
            catch (Exception)
            {
                return new List<ConfiguredDrive>();
            }
        }
	}
}

