using System;
using Gtk;
using MessageBox;

public partial class MainWindow : Gtk.Window {
    public MainWindow() : base(Gtk.WindowType.Toplevel) {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
        Application.Quit();
        a.RetVal = true;
    }

	protected void button1Clicked(object sender, EventArgs e) {
		MsgBox msg = new MsgBox();
		msg.Show();
	}
}
