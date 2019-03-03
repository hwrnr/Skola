using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLiga
{
    class Kolo
    {
        private int brojKola;

        public int BrojKola
        {
            get { return brojKola; }
            set { brojKola = value; }
        }



        private Utakmica[] utakmice = new Utakmica[4];

        public Utakmica[] Utakmice
        {
            get { return utakmice; }
            set { utakmice = value; }
        }


        public Kolo(Utakmica[] utakmice)
        {
            for (int i = 0; i < 4; i++)
            {
                this.utakmice[i] = utakmice[i];
            }
            brojKola++;
        }

        public override string ToString()
        {
            string str = brojKola + ". kolo : " + Environment.NewLine;
            for (int i = 0; i < 4; i++)
            {
                str += utakmice[i].ToString() + Environment.NewLine;
            }
            return str;

        }
    }
}
