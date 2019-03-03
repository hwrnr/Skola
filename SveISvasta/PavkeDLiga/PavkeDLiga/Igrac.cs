using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLiga
{
    class Igrac
    {   

        public enum EnumPozicija // Enumeracija koja predstavlja poziciju igraca
        {
            Golman,
            Odbrana,
            Vezni,
            Napad
        };

        private string ime; // Polje tipa string koje predstavlja ime igraca

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime; // Polje tipa string koje predstavlja prezime igraca

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private EnumPozicija pozicija; // Polje tipa gore navecene enumeracije EnumPozicija koje predstavlja poziciju igraca

        public EnumPozicija Pozicija
        {
            get { return pozicija; }
            set { pozicija = value; }
        }

        private int brojGolova; // Polje tipa int koje predstavlja broj golova koje je igrac dao (jos nisam pravio listu strelaca ali planiram)

        public int BrojGolova
        {
            get { return brojGolova; }
            set { brojGolova = value; }
        }

        public Igrac(string ime, string prezime, EnumPozicija pozicija) // Konstruktor sa parametrima ime, prezime i pozicija
        {
            this.ime = ime;
            this.prezime = prezime;
            this.pozicija = pozicija;
        }

        public override string ToString() // Metoda ToString() koja ispisuje igraca u dole navedenom formatu
        {
            string str = "     Ime: " + ime + Environment.NewLine;
            str += "     Prezime: " + prezime + Environment.NewLine;
            str += "     Pozicija: " + pozicija + Environment.NewLine;
            return str;
        }


    }
}
