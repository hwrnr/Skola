
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label4;

	private global::Gtk.TextView textview6;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label5;

	private global::Gtk.TextView textview7;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Label label6;

	private global::Gtk.TextView textview8;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Button button1;

	private global::Gtk.Button Ucenici;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Skole");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Ime skole");
		this.hbox1.Add(this.label4);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label4]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.textview6 = new global::Gtk.TextView();
		this.textview6.CanFocus = true;
		this.textview6.Name = "textview6";
		this.textview6.AcceptsTab = false;
		this.hbox1.Add(this.textview6);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.textview6]));
		w2.Position = 1;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Mesto skole");
		this.hbox2.Add(this.label5);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label5]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.textview7 = new global::Gtk.TextView();
		this.textview7.CanFocus = true;
		this.textview7.Name = "textview7";
		this.textview7.AcceptsTab = false;
		this.hbox2.Add(this.textview7);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.textview7]));
		w5.Position = 1;
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Adresa skole");
		this.hbox3.Add(this.label6);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label6]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.textview8 = new global::Gtk.TextView();
		this.textview8.CanFocus = true;
		this.textview8.Name = "textview8";
		this.textview8.AcceptsTab = false;
		this.hbox3.Add(this.textview8);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.textview8]));
		w8.Position = 1;
		this.vbox2.Add(this.hbox3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.CursorVisible = false;
		this.textview1.AcceptsTab = false;
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox2.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
		w11.PackType = ((global::Gtk.PackType)(1));
		w11.Position = 3;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Dodaj");
		this.hbox5.Add(this.button1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.button1]));
		w12.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.Ucenici = new global::Gtk.Button();
		this.Ucenici.CanFocus = true;
		this.Ucenici.Name = "Ucenici";
		this.Ucenici.UseUnderline = true;
		this.Ucenici.Label = global::Mono.Unix.Catalog.GetString("Ucenici");
		this.hbox5.Add(this.Ucenici);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.Ucenici]));
		w13.Position = 1;
		this.vbox2.Add(this.hbox5);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
		w14.PackType = ((global::Gtk.PackType)(1));
		w14.Position = 4;
		w14.Expand = false;
		w14.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 869;
		this.DefaultHeight = 729;
		this.Show();
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		this.Ucenici.Clicked += new global::System.EventHandler(this.OnUceniciClicked);
	}
}
