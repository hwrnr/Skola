using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLiga
{
    class Tim
    {
        private string imeTima; // Polje tipa string koje predstavlja ime tima

        public string ImeTima 
        {
            get { return imeTima; }
            set { imeTima = value; }
        }

        private int bodovi; // Polje tipa int koje predstavlja bodove koje je tim osvojio

        public int Bodovi
        {
            get { return bodovi; }
            set { bodovi = value; }
        }

        private int pobede; // Polje tipa int koje predstavlja broj pobeda koje je tim ostvario

        public int Pobede
        {
            get { return pobede; }
            set { pobede = value; }
        }

        private int neresene; // Polje tipa int koje predstavlja broj neresenih utakmica koje je tim ostvario

        public int Neresene
        {
            get { return neresene; }
            set { neresene = value; }
        }

        private int porazi; // Polje tipa int koje predstavlja broj poraza koje je tim ostvario

        public int Porazi
        {
            get { return porazi; }
            set { porazi = value; }
        }


        private Igrac[] igraci = new Igrac[6]; // Niz igraca duzine 6 (svi timovi su imali 6 igraca pa sam stavio fix vrednost)

        public Tim(string imeTima, Igrac[] igraci) // Konstruktor sa parametrima ime tima i nizom igraca
        {
            this.imeTima = imeTima;
            dodajIgrace(igraci);
        }

        private int datiGolovi; // Polje tipa int koje predstavlja broj datih golova na nivou tima u sezoni

        public int DatiGolovi
        {
            get { return datiGolovi; }
            set { datiGolovi = value; }
        }

        private int primljeniGolovi; // Polje tipa int koje predstavlja broj primljenih golova na nivou tima u sezoni

        public int PrimljeniGolovi
        {
            get { return primljeniGolovi; }
            set { primljeniGolovi = value; }
        }

        private int trenutniDati; // Polje tipa int koje predstavlja broj datih golova u poslednjoj utakmici

        public int TrenutniDati
        {
            get { return trenutniDati; }
            set { trenutniDati = value; }
        }

        private int trenutniPrimljeni; // Polje tipa int koje predstavlja broj primljenih golova u poslednjoj utakmici

        public int TrenutniPrimljeni
        {
            get { return trenutniPrimljeni; }
            set { trenutniPrimljeni = value; }
        }

        public Tim() // Konstruktor bez parametara 
        {
        }

        public void dodajIgraca(Igrac igrac) // Metod dodajIgraca(Igrac igrac) dodaje igraca u tim na prvo slobodno mesto
        {
            for (int i = 0; i < igraci.Length; i++)
            {
                if (igraci[i] == null)
                {
                    igraci[i] = igrac;
                    return;
                }
            }
                throw new Exception("Tim je pun. Ne mozete dodati igraca.");
        }

        public void dodajIgrace(Igrac[] noviIgraci) // Metod dodajIgrace dodaje niz igraca manji od 6 u tim
        {
            if (noviIgraci.Length <= 6)
            {
                for (int i = 0; i < noviIgraci.Length; i++)
                {
                    igraci[i] = noviIgraci[i];
                }
            }
            else
            {
                throw new Exception("Maksimalno mozete dodati 6 igraca u tim.");
            }
        }

        public void obrisiIgraca(int index) // Metod obrisiIgraca brise igraca sa zadatog indeksa i ostale igrace pomera za mesto u levo
        {
            if (index < 0 || index > 5)
            {
                throw new Exception("Index van opsega.");
            }
            else if(igraci[index] == null)
            { 
                throw new Exception("Na zadatoj poziciji nema igraca.");
            }
            else
            {
                for (int i = index; i < 6;  i++)
                {
                    igraci[index] = igraci[index + 1];
                }
            }
        }

        public string stringTabela() // Ispisuje  informacije o timu u tabeli (koriscen char[] radi lepseg ispisa i formatiranja)
        {
            char[] tim = new char[15];
            tim = ImeTima.ToCharArray(0, ImeTima.Length);

            char[] pobedeBr = new char[5];
            pobedeBr = Pobede.ToString().ToCharArray();

            char[] nereseneBr = new char[5];
            nereseneBr = Neresene.ToString().ToCharArray();

            char[] poraziBr = new char[5];
            poraziBr = Porazi.ToString().ToCharArray();

            char[] datiGoloviBr = new char[5];
            datiGoloviBr = DatiGolovi.ToString().ToCharArray();

            char[] primljeniGoloviBr = new char[5];
            primljeniGoloviBr = PrimljeniGolovi.ToString().ToCharArray();

            char[] golRazlika = new char[5];
            golRazlika = (datiGolovi - primljeniGolovi).ToString().ToCharArray();

            char[] bodoviBr = new char[5];
            bodoviBr = Bodovi.ToString().ToCharArray();
            
            char[] niz = new char[50];
			for (int i = 0; i < niz.Length; ++i){
				niz[i] = ' ';
			}
            tim.CopyTo(niz, 0);
            pobedeBr.CopyTo(niz, 15);
            nereseneBr.CopyTo(niz, 20);
            poraziBr.CopyTo(niz, 25);
            datiGoloviBr.CopyTo(niz, 30);
            primljeniGoloviBr.CopyTo(niz, 35);
            golRazlika.CopyTo(niz, 40);
            bodoviBr.CopyTo(niz, 45);

            string str = new string(niz);
            return str;
        }

        public override string ToString() // Ispisuje informacije o timu u dole datom formatu
        {
            string str = "Ime tima: " + imeTima + Environment.NewLine + "Igraci : " + Environment.NewLine;
            for (int i = 0; i < igraci.Count(x => x != null); i++)
            {
                str += igraci[i].ToString() + Environment.NewLine;
            }
            str += Environment.NewLine + "Dati golovi : " + DatiGolovi;
            str += Environment.NewLine + "Primljeni golovi : " + PrimljeniGolovi;
            str += Environment.NewLine + "Bodovi : " + Bodovi + Environment.NewLine;
            return str;
        }


    }
}
