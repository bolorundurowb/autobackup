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

        public static List<DriveInfo> GetConnectedUsbStorageDevices()
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

        public static List<DriveInfo> GetUnconfiguredDrives()
        {
            var allDrives = GetConnectedUsbStorageDevices();
            var configuredDrives = GetConfiguredDrives();
            var unconfiguredDrives = new List<DriveInfo>();
            foreach (DriveInfo drive in allDrives)
            {
                var result = configuredDrives.FirstOrDefault(x => x.Properties.Name == drive.Name);
                if (result == null)
                {
                    unconfiguredDrives.Add(drive);
                }
            }
            return unconfiguredDrives;
        }
	}
}

