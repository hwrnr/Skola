using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica {
    public class Kupac {
        private List<Artikal> artikli;
        private double novac;

        public double Novac {
            set {
                novac = value;
            }
            get {
                return novac;
            }
        }

        public Kupac(double novac = 0.0) {
            artikli = new List<Artikal>();
            this.novac = novac;
        }

        public int BrojArtikala {
            get {
                return artikli.Count;
            }
        }

        public void DodajArtikal(Artikal a) {
            artikli.Add(a);
        }

        public void VratiArtikal(int index) {
            try {
                artikli.RemoveAt(index);
            }
            catch {

            }
        }

        public int Ukupno() {
            int suma = 0;
            foreach (Artikal i in artikli) {
                suma += i.Cena;
            }
            return suma;
        }

        public override string ToString() {
            string str = "Kupac:" + Environment.NewLine + "Artikli: " + Environment.NewLine;

            foreach (Artikal i in artikli) {
                str += i.ToString();
            }
            str += "Novac kupca: " + novac;
            return str;
        }
    }
}