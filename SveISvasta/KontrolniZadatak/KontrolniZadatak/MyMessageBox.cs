using System;
namespace KontrolniZadatak {
    public partial class MyMessageBox : Gtk.Window {
        public MyMessageBox(string Message) :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
			this.textview2.Buffer.Text = Message;
        }
    }
}
