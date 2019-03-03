using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Prodavnica {
    public class Univer {
        private List<Kasa> kase;
        private int ogranak; // za potrebe razlikovanja pojedinacnih lokala
        private List<string> log;
        public Univer(uint brojKasa, int ogranak) {
            if (brojKasa == 0) throw new Exception("Kako radnja bez kase");
            kase = new List<Kasa>((int)brojKasa);
            for (int i = 0; i < brojKasa; ++i) {
                kase.Add(new Kasa());
            }
            this.ogranak = ogranak;
            this.log = new List<string>();
            this.log.Add("Otvorio se Univer");
        }

        public int Ogranak { get => ogranak;}

        public bool IzaberiIDodajKupcaNaKasu(Kupac kupac) {
            Kasa kasaNaKojuDodajem = kase[0];
            foreach (Kasa kasa in kase) {
                if (kasaNaKojuDodajem.DuzinaReda > kasa.DuzinaReda && kasa.DuzinaReda != Kasa.maxKupaca) {
                    kasaNaKojuDodajem = kasa;
                }
                if (kasaNaKojuDodajem.DuzinaReda == Kasa.maxKupaca && kasa.DuzinaReda != Kasa.maxKupaca) {
                    kasaNaKojuDodajem = kasa;
                }
            }
            try {
                kasaNaKojuDodajem.DodajKupca(kupac);
            }catch(Exception e) {
                if (e.ToString().Equals("Nema mesta u redu")) {
                    return false;
                }
            }
            log.Add("Dodan je kupac u red");
            return true;
        }

        public void PrebaciNaDruguKasu(int kasa1, int kasa2, int n) { //pretpostavljam da je sa pocetka da se prebaci na kraj, jer je u pitanju Queue
            if (kasa1 > kase.Capacity || kasa2 > kase.Capacity || kasa1 < 0 || kasa2 < 0) {
                return;
            }
            Kasa k1 = kase[kasa1];
            Kasa k2 = kase[kasa2];
            while (n > 0 && k1.DuzinaReda != 0 && k2.DuzinaReda != Kasa.maxKupaca) {
                --n;
                k2.DodajKupca(k1.IzbaciPoslednjegKupca());
                log.Add("Kupac je premesten sa jedne kase na drugu");
            }
        }

        public void GenerisiIzvestaj(string fileName = "izvestaj.txt") {
            string str = "";
            double ukupno = 0.0;
            foreach (var kasa in kase) {
                ukupno += kasa.NovacUKasi;
            }
            str += "Univer ogranak " + ogranak + Environment.NewLine;
            str += "Ukupan novac u kasi: " + ukupno + Environment.NewLine + Environment.NewLine;

            str += this.ToString() + Environment.NewLine + "Log:" + Environment.NewLine;
            foreach (string l in log) {
                str += l + Environment.NewLine;
            }
            File.WriteAllText(fileName, str);
        }

        public override string ToString() {
            string str = "";
            foreach (var kasa in kase) {
                str += kasa + Environment.NewLine;
            }
            str += "Ogranak: " + ogranak + Environment.NewLine;
            return str;
        }

        public void UsluziKupcaNaKasi(int brojKase) {
            try {
                kase[brojKase].UsluziKupca();
                log.Add("Usluzen je kupac na kasi " + brojKase);
            }
            catch {
            }
        }
    }
}
