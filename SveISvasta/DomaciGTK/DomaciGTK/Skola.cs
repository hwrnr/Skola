using System;
namespace DomaciGTK
{
    public class Skola
    {
		string naziv, adresa, mesto;
        public Skola(string naziv, string adresa, string mesto)
        {
			this.naziv = naziv;
			this.adresa = adresa;
			this.mesto = mesto;
        }
		public override string ToString()
		{
			return naziv + " " + adresa + " " + mesto;
		}
	}
}
