using System;
using System.Diagnostics;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	void OnBtnAddDriveActivated(object sender, EventArgs e)
	{
		Debug.Write ("Hello from add");
	}

	void OnBtnEditDrivesActivated(object sender, EventArgs e)
	{
		Debug.Write ("Hello from edit");
	}

	void OnBtnRemoveDrivesActivated(object sender, EventArgs e)
	{
		Debug.Write ("Hello from remove");
	}

	void OnShown(object sender, EventArgs e)
	{
		Debug.Write ("Hello from shown");
	}

	void OnFocused(object sender, EventArgs e)
	{
		Debug.Write ("Hello from focused");
	}
}
