using System;
namespace GUI
{
    public partial class AddDrive : Gtk.Dialog
    {
        public AddDrive()
        {
            this.Build();
        }

        protected void CloseDialog(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
