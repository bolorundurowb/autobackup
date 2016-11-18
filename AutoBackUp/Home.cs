using System;
using Gtk;

public partial class Home : Gtk.Window
{
    public Home() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        var stuff = Core.Core.GetConfiguredDrives();
        System.Diagnostics.Debug.WriteLine(stuff);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
