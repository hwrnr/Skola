using System;

namespace Prodavnica {
    class MainClass {
        public static void Main(string[] args) {
            Artikal artikal = new Artikal("Mleveno meso", 12, 2);
            Kupac kupac = new Kupac(12);
            kupac.DodajArtikal(artikal);

            Univer univer = new Univer(2, 1);

            univer.IzaberiIDodajKupcaNaKasu(kupac);

            univer.UsluziKupcaNaKasi(0);
            Console.WriteLine(univer);
            univer.GenerisiIzvestaj();
        }
    }
}
