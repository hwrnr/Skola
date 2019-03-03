using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistracijaStudenata
{
    static class Program
    {
        public static List<Ucenik> spisakUcenika = new List<Ucenik>();
        public static List<Skola> spisakSkola = new List<Skola>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }

    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string Razred { get; set; }

        public Ucenik(string ime,string prezime, string datum, string razred)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datum;
            Razred = razred;

        }
    }

    public class Skola
    {
        public string ImeSkole { get; set; }
        public string AdresaSkole { get; set; }
        public string GradSkole { get; set; }

        public Skola(string ImeSkole, string AdresaSkole, string GradSkole)
        {
            this.ImeSkole = ImeSkole;
            this.AdresaSkole = AdresaSkole;
            this.GradSkole = GradSkole;
        }
    }
}
