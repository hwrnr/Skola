using System;
using Gtk;
using KontrolniZadatak;
using System.IO;

public partial class MainWindow : Gtk.Window {
    public MainWindow() : base(Gtk.WindowType.Toplevel) {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
        Application.Quit();
        a.RetVal = true;
    }

	protected void dodajUcenika(object sender, EventArgs e) {
		/*
        public int brojIndex;
        public string ime;
        public string prezime;
        public DateTime datumRodjenja;
        public string imeRoditelja;
        public int godinaStudija;
        public Pol pol;
        public Smer smer;
        */
		if (tbrojIndex.Buffer.Text == ""){
			MyMessageBox my = new MyMessageBox("Fali broj index");
			return;
		}
		if (tIme.Buffer.Text == "") {
            MyMessageBox my = new MyMessageBox("Fali ime");
			return;
        }
		if (tprezime.Buffer.Text == "") {
            MyMessageBox my = new MyMessageBox("Fali prezime");
			return;
        }
		if (timeRoditelja.Buffer.Text == ""){
			MyMessageBox my = new MyMessageBox("Fali ime roditelja");
            return;
		}
		if (combobox1.ActiveText == ""){
			MyMessageBox my = new MyMessageBox("Fali smer");
            return;
		}
		if (tgodina.Buffer.Text == ""){
			MyMessageBox my = new MyMessageBox("Fali godina0");
            return;
		}

		try {
			Pol poll;
			if (radiobutton2.Active){
				poll = KontrolniZadatak.Pol.PolMuski;
			}
			else{
				poll = KontrolniZadatak.Pol.PolZenski;
			}
			String smerr = combobox1.ActiveText;
			Student s = new Student(int.Parse(tbrojIndex.Buffer.Text), tIme.Buffer.Text, tprezime.Buffer.Text, calendar.Day.ToString() + " " + calendar.Month.ToString() + " " + calendar.Year.ToString(), timeRoditelja.Buffer.Text, int.Parse(tgodina.Buffer.Text), poll, smerr);
			File.AppendAllText(@"Studenti", s.ToString() + Environment.NewLine); 
			tbrojIndex.Buffer.Text = "";
			tIme.Buffer.Text = "";
			tprezime.Buffer.Text = "";
			timeRoditelja.Buffer.Text = "";
			tgodina.Buffer.Text = "";
			combobox1.Active = -1;
		}
		catch (Exception){
			MyMessageBox my = new MyMessageBox("Greska pri dodavanju D:");
		}
	}

	protected void Studenti(object sender, EventArgs e) {
		try {
			MyMessageBox my = new MyMessageBox(File.ReadAllText(@"Studenti"));
        }
		catch (Exception){
			MyMessageBox my = new MyMessageBox("Trenutno nema baze sa studentima, dodajte novog studenta");
		}
	}
}
