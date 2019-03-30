using System;
using System.Data;
using System.Data.SqlClient;

//zadatak 3WC

namespace NekaJutarnjaGlupost {
    class MainClass {
        public static void Main(string[] args) {
            using (SqlConnection konekcija = new SqlConnection()) {
                konekcija.ConnectionString = "Data Source=localhost;User Id=SA;Password=P4ssword;Initial Catalog=master";
                konekcija.Open();

                /*string tekstNaredbe = "INSERT into Radnik values (99, 'Pera', 'Peric', 10, 120000, 100, CONVERT(DATETIME, '2012-05-06', 102))";

                using (SqlCommand naredba = new SqlCommand(tekstNaredbe, konekcija)) {

                                        int brojPogodnjenihRedova = naredba.ExecuteNonQuery();

                    Console.WriteLine("Uspesno je izvrsena naredba '{0}'", brojPogodnjenihRedova);
                }*/

                string tekstNaredbe = "select * from radnik";

                using (SqlCommand naredba = new SqlCommand(tekstNaredbe, konekcija)) {

                    using (SqlDataReader citac = naredba.ExecuteReader()) {
                        Console.WriteLine("{0}\t{1}", citac.GetName(0), citac.GetName(1));

                        while (citac.Read()) {
                            Console.WriteLine("{0}\t{1}", citac.GetValue(0), citac.GetValue(1));
                        }
                    }

                }
            }
        }

        /*public static double Zbir(int n) {
            double suma = 0;
            for (int i = 0; i < n; ++i) {
                suma += i + 1;
            }
            return suma;
        }

        public static double Faktorijal(int n) {
            double rez = 1;
            for (int i = 0; i < n; ++i) {
                rez *= i + 1;
            }
            return rez;
        }

        public static void Main() {
            int n = int.Parse(Console.ReadLine());
            double suma = 1;
            for (int i = 2; i < n + 1; ++i) {
                double tmp = Zbir(i) / Faktorijal(i - 1);
                if (i % 2 == 0) {
                    suma -= tmp;
                }
                else {
                    suma += tmp;
                }
            }
            Console.WriteLine(suma);
        }*/
    }
}
