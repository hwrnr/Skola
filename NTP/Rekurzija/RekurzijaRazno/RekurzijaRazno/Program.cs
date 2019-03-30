using System;

namespace RekurzijaRazno {
    class MainClass {

        public static string ObrnutoPrvihN(int n) {
            if (n < 1) {
                return "";
            }
            return n.ToString() + " " + ObrnutoPrvihN(n - 1);
        }

        public static string PrvihN(int n) {
            if (n < 1) {
                return "";
            }
            return PrvihN(n - 1) + " " + n.ToString();
        }

        public static string ObrnutoCifre(uint n) { //zanemarujem minus i cifre broja 0
            if (n == 0) {
                return "";
            }
            return (n % 10).ToString() + " " + ObrnutoCifre(n / 10);
        }

        public static string RedomCifre(uint n) { //zanemarujem minus i cifre broja 0
            if (n == 0) {
                return "";
            }
            return RedomCifre(n / 10) + " " + (n % 10).ToString();
        } 

        public static int BrojCifara(int n) { //ponovo racunam da nula nema cifri
            if (n == 0) {
                return 0;
            }
            return 1 + BrojCifara(n / 10);
        }

        public static int BrojPonavljanjaCifre(int n, int k) { //bez provere da li je k stvarno cifra, vratice 0 ako k nije cifra
            if (n == 0) return 0;
            if (n % 10 == k) {
                return 1 + BrojPonavljanjaCifre(n / 10, k);
            }
            return BrojPonavljanjaCifre(n / 10, k); // 0 + BrojPonavljanja....
        }

        public static int NajveciUNizu(int[] n) { // bez provere da li je null
            return NajveciUNizu(n, 0, n[0]);
        }

        private static int NajveciUNizu(int[] n, int index, int max) {
            if (n[index] > n[max]) {
                max = index;
            }
            if (index == n.Length - 1) return n[max];

            return NajveciUNizu(n, index + 1, max);
        }

        public static bool DaLiJeProst(int n, int k = 1) { // broj je prost samo ako se moze zapisati u obliku 6*k + 1 ili 6 * k - 1, ali ne vazi obrnuto
            if (n == 1) return false;
            if (n == 2 || n == 3) return true;
            if (n == (6 * k + 1) || n == (6 * k - 1)) return true;
            if (n % (6 * k + 1) == 0 || n % (6 * k - 1) == 0) {
                return false;
            }
            return DaLiJeProst(n, k + 1);
        }

        public static double NekaCudnaF(int n) {
            if (n == 1) return 1;
            return n + 1 / NekaCudnaF(n - 1);
        }

        public static double NekaCudnaFIterativno(int n) {
            if (n < 1) return 0; //samo za pozitivne brojeve
            double suma = 1;
            for (int i = 2; i < n + 1; ++i) {
                suma = i + 1 / suma;
            }
            return suma;
        }

        public static int BinarniUDekadni(int[] niz, int index = 0) { //bez provere da li je niz null
            if (index == niz.Length - 1) { 
                return niz[index];
            }
            return niz[index] * (int)Math.Pow(2, niz.Length - 1 - index) + BinarniUDekadni(niz, index + 1); // pretpostavljam da korisnik unosi samo 0 i 1
        }

        public static string DekadniUBinarni(uint broj) { //samo za pozitivne cele brojeve
            if (broj == 1) return "1";
            return DekadniUBinarni(broj / 2) + (broj % 2).ToString();
        }

        public static void PermutacijeOd1DoN(int n) {
            int[] niz = new int[n];
            for (int i = 0; i < n; ++i) {
                niz[i] = i + 1;
            }
            PermutacijeNiza(niz, 0, 1);
        }

        private static void PermutacijeNiza(int[] niz, int i, int j) { //ne ispise sve, ali je dosta blizu, fali mu samo kada je n prvi broj, tu ispise samo jedan slucaj
            if (j == niz.Length) {
                for (int k = 0; k < niz.Length; ++k) {
                    Console.Write(niz[k] + " ");
                }
                Console.WriteLine();
                return;
            }
            int tmp = niz[i];
            niz[i] = niz[j];
            niz[j] = tmp;
            PermutacijeNiza(niz, i, j + 1);
            tmp = niz[j];
            niz[j] = niz[i];
            niz[i] = tmp;
            if (i < niz.Length - 1) {
                PermutacijeNiza(niz, i + 1, i + 2);
            }
        }


        public static void Main(string[] args) {



            Console.WriteLine(ObrnutoPrvihN(4));
            Console.WriteLine(ObrnutoPrvihN(-1));
            Console.WriteLine(PrvihN(4));
            Console.WriteLine(PrvihN(-4));

            Console.WriteLine(ObrnutoCifre(1234));
            Console.WriteLine(ObrnutoCifre(0)); //nula ,,nema cifre''

            Console.WriteLine(RedomCifre(1234));
            Console.WriteLine(RedomCifre(0)); // nula ,,nema cifre''

            Console.WriteLine(BrojCifara(22701));
            Console.WriteLine(BrojCifara(-22701));

            Console.WriteLine(BrojPonavljanjaCifre(22852, 2));
            Console.WriteLine(BrojPonavljanjaCifre(1234, 4));
            Console.WriteLine(BrojPonavljanjaCifre(1234, 5));


            int[] niz = new int[] { 1, 2, 3, 13, 21, 3, 6 };
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine(NajveciUNizu(niz));

            Console.WriteLine(DaLiJeProst(1));
            Console.WriteLine(DaLiJeProst(2));
            Console.WriteLine(DaLiJeProst(1));
            Console.WriteLine(DaLiJeProst(5));
            Console.WriteLine(DaLiJeProst(22));
            Console.WriteLine(DaLiJeProst(23));
            Console.WriteLine(DaLiJeProst(937)); // true kaze internet
            Console.WriteLine(DaLiJeProst(7823)); // true kaze internet
            Console.WriteLine(DaLiJeProst(7821)); //false kaze internet

            Console.WriteLine("Cudne F");
            Console.WriteLine(NekaCudnaF(1));
            Console.WriteLine(NekaCudnaFIterativno(1));
            Console.WriteLine(NekaCudnaF(2));
            Console.WriteLine(NekaCudnaFIterativno(2));
            Console.WriteLine(NekaCudnaF(3));
            Console.WriteLine(NekaCudnaFIterativno(3));
            Console.WriteLine(NekaCudnaF(4));
            Console.WriteLine(NekaCudnaFIterativno(4));
            Console.WriteLine(NekaCudnaF(5));
            Console.WriteLine(NekaCudnaFIterativno(5));

            Console.WriteLine("Binarni u dekadni");

            int[] binarniNiz = { 1, 0, 1 };
            Console.WriteLine(BinarniUDekadni(binarniNiz));
            binarniNiz = new int[] { 1, 0, 1, 0, 1 };
            Console.WriteLine(BinarniUDekadni(binarniNiz));
            binarniNiz = new int[] { 1, 0, 1, 0 };
            Console.WriteLine(BinarniUDekadni(binarniNiz));
            binarniNiz = new int[] { 1, 1 };
            Console.WriteLine(BinarniUDekadni(binarniNiz));

            Console.WriteLine("Dekadni u binarni");

            Console.WriteLine(DekadniUBinarni(10));
            Console.WriteLine(DekadniUBinarni(3));
            Console.WriteLine(DekadniUBinarni(21));

            Console.WriteLine(Environment.NewLine + "Permutacije");
            PermutacijeOd1DoN(2);
            Console.WriteLine();
            PermutacijeOd1DoN(3);
            Console.WriteLine();
            PermutacijeOd1DoN(4);
        }
    }
}
