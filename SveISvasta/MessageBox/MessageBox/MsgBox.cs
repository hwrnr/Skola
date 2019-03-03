using System;
namespace MessageBox {
    public partial class MsgBox : Gtk.Window {
        public MsgBox() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
			label4.Text = "Tekst";
        }
    }
}
