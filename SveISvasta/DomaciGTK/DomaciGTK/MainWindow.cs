using System;
using System.IO;
using Gtk;
using DomaciGTK;

public partial class MainWindow : Gtk.Window
{
	public static System.Collections.Generic.List<Skola> skole = new System.Collections.Generic.List<Skola>();
	// skole = new ListStore<Skola>();
	//int i = 0;
	//Layout layout1 = new Layout(hadjustment, vadjustment);
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
		try
		{
			textview1.Buffer.Text = System.IO.File.ReadAllText(@"Skole");
		}catch{
			
		}

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

	protected void OnUceniciClicked(object sender, EventArgs e)
	{
		DomaciGTK.Window window = new DomaciGTK.Window();
		window.Show();
	}

	protected void OnButton1Clicked(object sender, EventArgs e)
	{
		Skola tmp = new Skola(textview6.Buffer.Text, textview8.Buffer.Text, textview7.Buffer.Text);
        skole.Add(tmp);
        File.AppendAllText(@"Skole", tmp.ToString() + Environment.NewLine);
        textview1.Buffer.Text = System.IO.File.ReadAllText(@"Skole");
	}
}
