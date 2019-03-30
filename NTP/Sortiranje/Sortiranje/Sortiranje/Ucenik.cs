using System;
using System.Collections.Generic;

namespace Sortiranje {
    public class Ucenik : IComparable, ICloneable {

        private string ime, prezime;
        private double visina, tezina, prosek;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public double Visina { get => visina; set => visina = value; }
        public double Tezina { get => tezina; set => tezina = value; }
        public double Prosek { get => prosek; set => prosek = value; }

        public Ucenik(string ime = "Marko", string prezime = "Petrovic", double visina = 185, double tezina = 80, double prosek = 5.0) {
            this.ime = ime;
            this.prezime = prezime;
            this.visina = visina;
            this.tezina = tezina;
            this.prosek = prosek;
        }

        public int CompareTo(object obj) {
            if (obj == null) {
                return 1;
            }
            if (obj is Ucenik uc) {
                //ovde treba manjati za ostala sortiranja ako koristimo List<T>.Sort();
                int status = this.visina.CompareTo(uc.visina);
                if (status == 0) {
                    return -this.tezina.CompareTo(uc.tezina); //minus jer slazem od najveceg ka najmanjem jer tako kaze zadatak
                }
                return -status; //minus jer slazem od najveceg ka najmanjem jer tako kaze zadatak
            }
            else {
                throw new ArgumentException("Object is not Ucenik");
            }
        }

        public override string ToString() {
            return ime + " " + prezime + " " + visina + " " + tezina + " " + prosek;
        }

        public override bool Equals(object obj) {
            if (obj is Ucenik uc) {
                return this.ime.Equals(uc.ime) && this.prezime.Equals(uc.prezime) && this.prosek.Equals(uc.prosek) && this.visina.Equals(uc.visina) && this.tezina.Equals(uc.tezina);
            }
            return false;

        }

        public object Clone() {
            Ucenik ucenik = new Ucenik {
                ime = (string)this.ime.Clone(),
                prezime = (string)this.prezime.Clone(),
                prosek = this.prosek,
                tezina = this.tezina,
                visina = this.visina
            };
            return ucenik;
        }

        public override int GetHashCode() {
            var hashCode = -806121333;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prezime);
            hashCode = hashCode * -1521134295 + visina.GetHashCode();
            hashCode = hashCode * -1521134295 + tezina.GetHashCode();
            hashCode = hashCode * -1521134295 + prosek.GetHashCode();
            return hashCode;
        }
    }
}
