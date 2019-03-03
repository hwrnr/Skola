using System;
namespace DomaciGTK
{
    public class Ucenik
    {
		string ime, prezime, skola, razred;
        public Ucenik(string ime, string prezime, string skola, string razred)
        {
			this.ime = ime;
			this.prezime = prezime;
			this.razred = razred;
			this.skola = skola;
        }
		public override string ToString()
		{
			return ime + " " + prezime + ", " + skola + ", " + razred;
		}
	}
}
