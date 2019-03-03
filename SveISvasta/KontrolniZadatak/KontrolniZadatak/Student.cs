using System;

namespace KontrolniZadatak {
public enum Pol {
	PolMuski,
	PolZenski
}
public enum Smer {
	SmerE1,
	SmerE2,
    SmerE3

}
    public class Student {
		public int brojIndex;
		public string ime;
		public string prezime;
		public String datumRodjenja;
		public string imeRoditelja;
		public int godinaStudija;
		public Pol pol;
		public String smer;

		public Student(int brojIndex,string ime,
        string prezime,
        String datumRodjenja,
        string imeRoditelja,
        int godinaStudija, Pol pol, String smer) {
			this.brojIndex = brojIndex;
			this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.imeRoditelja = imeRoditelja;
            this.godinaStudija = godinaStudija;
            this.pol = pol;
            this.smer = smer;
        }
        
		public override string ToString() {
			string str = "";
			str += brojIndex + " " + ime + " " + prezime + " " + datumRodjenja + " " + imeRoditelja + " " + godinaStudija + " " + pol + " " + smer;
			return str;
		}
	}
}
