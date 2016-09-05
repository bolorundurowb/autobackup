using Gtk;

namespace AutoBackUp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			Home home = new Home();
			home.Show();
			Application.Run();
		}
	}
}
