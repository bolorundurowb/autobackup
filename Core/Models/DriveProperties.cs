namespace Core
{
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

