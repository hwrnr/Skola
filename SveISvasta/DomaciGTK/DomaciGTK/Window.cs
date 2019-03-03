using System;
namespace DomaciGTK
{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
			foreach (Skola skola in MainWindow.skole)
            {
                combobox1.AppendText(skola.ToString());
            }
			try
			{
				Fajl.Buffer.Text = System.IO.File.ReadAllText(@"Ucenici");
			}catch{
				
			}
        }

		protected void OnDodajUcenikaClicked(object sender, EventArgs e)
		{
			Ucenik tmp = new Ucenik(Imet.Buffer.Text, Prezimet.Buffer.Text, combobox1.ActiveText, Razredt.Buffer.Text);
            System.IO.File.AppendAllText(@"Ucenici", tmp.ToString() + Environment.NewLine);
            Fajl.Buffer.Text = System.IO.File.ReadAllText(@"Ucenici");
		}
	}
}
