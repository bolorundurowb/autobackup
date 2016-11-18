
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action AddAction;

	private global::Gtk.Action EditAction;

	private global::Gtk.Action RemoveAction;

	private global::Gtk.Action ManageAction;

	private global::Gtk.Action addAction;

	private global::Gtk.Action editAction;

	private global::Gtk.Action cancelAction;

	private global::Gtk.VBox vbox2;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.HPaned hpaned1;

	private global::Gtk.VPaned vpaned1;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.Label GtkLabel1;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.Label GtkLabel2;

	private global::Gtk.VBox vbox3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.NodeView nodeview1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.AddAction = new global::Gtk.Action("AddAction", global::Mono.Unix.Catalog.GetString("Add"), null, null);
		this.AddAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Add");
		w1.Add(this.AddAction, null);
		this.EditAction = new global::Gtk.Action("EditAction", global::Mono.Unix.Catalog.GetString("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Edit");
		w1.Add(this.EditAction, null);
		this.RemoveAction = new global::Gtk.Action("RemoveAction", global::Mono.Unix.Catalog.GetString("Remove"), null, null);
		this.RemoveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Remove");
		w1.Add(this.RemoveAction, null);
		this.ManageAction = new global::Gtk.Action("ManageAction", global::Mono.Unix.Catalog.GetString("Manage"), null, null);
		this.ManageAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Manage");
		w1.Add(this.ManageAction, null);
		this.addAction = new global::Gtk.Action("addAction", global::Mono.Unix.Catalog.GetString("Add"), null, "gtk-add");
		this.addAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Add");
		w1.Add(this.addAction, null);
		this.editAction = new global::Gtk.Action("editAction", global::Mono.Unix.Catalog.GetString("_Edit"), null, "gtk-edit");
		this.editAction.ShortLabel = global::Mono.Unix.Catalog.GetString("_Edit");
		w1.Add(this.editAction, null);
		this.cancelAction = new global::Gtk.Action("cancelAction", global::Mono.Unix.Catalog.GetString("_Cancel"), null, "gtk-cancel");
		this.cancelAction.ShortLabel = global::Mono.Unix.Catalog.GetString("_Cancel");
		w1.Add(this.cancelAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='ManageAction' action='ManageAction'><menuitem name='addAction' action='addAction'/><menuitem name='editAction' action='editAction'/><menuitem name='cancelAction' action='cancelAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox2.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 233;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vpaned1 = new global::Gtk.VPaned();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 168;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		this.frame1.Add(this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Configured Drives</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel1;
		this.vpaned1.Add(this.frame1);
		global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.frame1]));
		w4.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		this.frame2.Add(this.GtkAlignment1);
		this.GtkLabel2 = new global::Gtk.Label();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Drive Details</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel2;
		this.vpaned1.Add(this.frame2);
		this.hpaned1.Add(this.vpaned1);
		global::Gtk.Paned.PanedChild w7 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.vpaned1]));
		w7.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.nodeview1 = new global::Gtk.NodeView();
		this.nodeview1.CanFocus = true;
		this.nodeview1.Name = "nodeview1";
		this.GtkScrolledWindow.Add(this.nodeview1);
		this.vbox3.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
		w9.Position = 0;
		this.hpaned1.Add(this.vbox3);
		this.vbox2.Add(this.hpaned1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hpaned1]));
		w11.Position = 1;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 593;
		this.DefaultHeight = 382;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}