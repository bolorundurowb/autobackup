using System;
using Gtk;
using GUI;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void AddNewDrive(object sender, EventArgs e)
    {
        AddDrive addDrive = new AddDrive();
        addDrive.ShowAll();
    }
}
