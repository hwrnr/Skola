using System;
using System.Data;
using System.Data.SqlClient;

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
    }
}
