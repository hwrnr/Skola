using System;

namespace Rekurzija {
    class MainClass {

        public static int Stepen(int osnova, uint stepen) { //samo za cele brojeve osnova, a prirodne sa nulom za stepen
            if (stepen == 0) {
                return 1;
            }
            return osnova * Stepen(osnova, stepen - 1);
        }

        public static bool DaLiJePalindrom(string provera, int index = 0) { // moram poceti odnekud
            if (provera.Length / 2 <= index) {
                return true;
            }
            if (provera[index] != provera[provera.Length - 1 - index]) {
                return false;
            }
            return DaLiJePalindrom(provera, index + 1);
        }

        public static void Main(string[] args) {
            Console.WriteLine(Stepen(4, 0));
            Console.WriteLine(Stepen(4, 2));
            Console.WriteLine(Stepen(3, 3));
            Console.WriteLine(Stepen(8, 2));
            Console.WriteLine(Stepen(2, 10));

            Console.WriteLine(DaLiJePalindrom("anavolimilovana"));
            Console.WriteLine(DaLiJePalindrom("anavodaradovana"));
            Console.WriteLine(DaLiJePalindrom("aibohphobia")); //Aibohphobia (fear of palindromes)
            Console.WriteLine(DaLiJePalindrom("petarpannijepojeorucak"));
            Console.WriteLine(DaLiJePalindrom("nemamidejuzapalindrome"));
            Console.WriteLine(DaLiJePalindrom(""));
        }
    }
}
