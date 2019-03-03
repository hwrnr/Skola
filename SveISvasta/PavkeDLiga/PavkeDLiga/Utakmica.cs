using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLiga
{
    class Utakmica
    {
        private Tim tim1; // Polje koje predstavlja tim domacina

        public Tim Tim1 
        {
            get { return tim1; }
            set { tim1 = value; }
        }

        private Tim tim2; // Polje koje predstavlja tim gosta

        public Tim Tim2
        {
            get { return tim2; }
            set { tim2 = value; }
        }


        private int goloviTim1; // Golovi domacina postignuti na utakmici

        public int GoloviTim1
        {
            get { return goloviTim1; }
            set { goloviTim1 = value; }
        }

        private int goloviTim2; // Golovi gosta postignuti na utakmici

        public int GoloviTim2
        {
            get { return goloviTim2; }
            set { goloviTim2 = value; }
        }

        public Utakmica(Tim tim1, Tim tim2, int goloviTim1, int goloviTim2)
        {
            this.tim1 = tim1;
            this.tim2 = tim2;
            this.goloviTim1 = goloviTim1;
            this.goloviTim2 = goloviTim2;
            tim1.DatiGolovi += goloviTim1;
            tim1.PrimljeniGolovi += goloviTim2;
            tim2.DatiGolovi += goloviTim2;
            tim2.PrimljeniGolovi += GoloviTim1;
            tim1.TrenutniDati = goloviTim1;
            tim1.TrenutniPrimljeni = goloviTim2;
            tim2.TrenutniDati = goloviTim2;
            tim2.TrenutniPrimljeni = goloviTim1;
        }

        public Utakmica(Tim tim1, Tim tim2)
        {
            this.tim1 = tim1;
            this.tim2 = tim2;
 
        }



        public int brojGolova()
        {
            int brojGolova = goloviTim1 + goloviTim2;
            return brojGolova;
        }

        public string stringUtakmica()
        {
            char[] tim1 = new char[15];
            tim1 = Tim1.ImeTima.ToCharArray(0, Tim1.ImeTima.Length);

            char[] tim2 = new char[15];
            tim2 = Tim2.ImeTima.ToCharArray(0, Tim2.ImeTima.Length);

            char[] rezultat = new char[6];
            string strRezultat = "  -  ";
            rezultat = strRezultat.ToCharArray(0, strRezultat.Length);

            char[] niz = new char[45];
            tim1.CopyTo(niz, 0);
            rezultat.CopyTo(niz, 15);
            tim2.CopyTo(niz, 30);

            string str = new string(niz);

            return str;
        }

        public override string ToString()
        {
            char[] tim1 = new char[15];
            tim1 = Tim1.ImeTima.ToCharArray(0, Tim1.ImeTima.Length);

            char[] tim2 = new char[15];
            tim2 = Tim2.ImeTima.ToCharArray(0, Tim2.ImeTima.Length);

            char[] rezultat = new char[6];
            string strRezultat = GoloviTim1 + " : " + GoloviTim2;
            rezultat = strRezultat.ToCharArray(0, strRezultat.Length);

            char[] niz = new char[45];
            tim1.CopyTo(niz, 0);
            rezultat.CopyTo(niz, 15);
            tim2.CopyTo(niz, 30);

            string str = new string(niz);

            return str;
        }
    }
}
