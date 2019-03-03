using System;
namespace Prodavnica {
    public class Artikal {
        private string ime;
        private int cena;
        private int kolicina;

        public Artikal(string ime, int cena, int kolicina = 1){
            this.ime = ime;
            this.cena = cena;
            this.kolicina = kolicina;
        }

        public int Cena {
            get {
                return cena;
            }
            set {
                cena = value;
            }
        }

        public string Ime {
            set {
                ime = value;
            }
            get {
                return ime;
            }
        }

        public int Kolicina { 
                get {
                    return kolicina;
                } 
                set {
                    kolicina = value; 
                }
            }

        public override string ToString() {
            string str = "";
            str = str + "Ime artikla: " + ime + " cena: " + cena + Environment.NewLine;
            return str;
        }
    }
}
