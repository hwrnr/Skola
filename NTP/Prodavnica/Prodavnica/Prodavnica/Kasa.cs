using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica {
    public class Kasa {
        private const int vremePoArtiklu = 10;
        public const int maxKupaca = 10;
        private Queue<Kupac> red;

        private int brojKupaca;
        private int novacUKasi;
        private int ukupnoVreme;

        public int UkupnoVreme {
            get {
                return ukupnoVreme;
            }
        }

        public int DuzinaReda {
            get {
                return red.Count;
            }
        }

        public int BrojKupaca { get => brojKupaca; set => brojKupaca = value; }
        public int NovacUKasi { get => novacUKasi; set => novacUKasi = value; }

        public Kasa() {
            red = new Queue<Kupac>(10);
            novacUKasi = 0;
            ukupnoVreme = 0;
            brojKupaca = 0;
        }


        public void DodajKupca(Kupac k) {
            if (red.Count > maxKupaca) throw new Exception("Nema mesta u redu");
            red.Enqueue(k);
            return;
        }

        public void UsluziKupca() {
            if (red.Count == 0) throw new Exception("Nema kupaca u redu");
            Kupac tmp = red.First();
            if (tmp.Novac < tmp.Ukupno()) { throw new Exception("Kupac nema dovoljno sredstava, obezbedjenje ce ga izbaciti"); }
            tmp.Novac -= tmp.Ukupno();
            this.NovacUKasi += tmp.Ukupno();
            this.ukupnoVreme += tmp.BrojArtikala * vremePoArtiklu;
            ++brojKupaca;
            red.Dequeue();
        }

        public override string ToString() {
            string str = "";
            str += "Kasa: " + Environment.NewLine;
            str += "Usluzeno kupaca: " + brojKupaca + Environment.NewLine;
            str += "Ukupno vreme: " + ukupnoVreme + Environment.NewLine;
            str += "Novac u kasi: " + novacUKasi + Environment.NewLine;
            if (red.Count != 0) {
                str += "Red: " + Environment.NewLine;
                foreach (Kupac kupac in red) {
                    str += kupac;
                }
            }
            else {
                str += "Niko ne ceka na kasi";
            }
            return str + Environment.NewLine;
        }

        public Kupac IzbaciPoslednjegKupca() {
            red.Reverse();
            red.Dequeue();
            Kupac kupac = red.First();
            red.Reverse();
            return kupac;
        }
    }
}