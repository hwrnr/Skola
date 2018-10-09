using System;

class Polinom{
  private ClanPolinoma[] clanovi;
  public ClanPolinoma[] Clanovi { get{return clanovi;} set{ clanovi = value;} }


  public Polinom(ClanPolinoma[] clanovi){
    this.clanovi = clanovi;
  }

  public Polinom(){
    this.clanovi = new ClanPolinoma[0];
  }

  public Polinom(Polinom other){
    clanovi = new ClanPolinoma[other.clanovi.Length];
    Array.Copy(other.clanovi, this.clanovi, other.clanovi.Length);
  }

  //Dodaj(ClanPolinoma)
  //Dodaj(Polinom)
  //Oduzmi(ClanPolinoma)
  //Oduzmi(Polinom)
  //Izracunaj(double)
  //Pomnozi(double)
  //Pomnozi(ClanPolinoma)
  //Pomnozi(Polinom)
  //Podeli(double)
  //Podeli(ClanPolinoma)
  //Podeli(Polinom)

  public void Dodaj(ClanPolinoma sabirak){
    foreach(ClanPolinoma clan in clanovi){
      if (clan.Stepen == sabirak.Stepen){
        clan.Dodaj(sabirak);
        return;
      }
    }
    // ClanPolinoma[] tmp = this.clanovi;
    ClanPolinoma[] tmp = new ClanPolinoma[this.clanovi.Length];
    Array.Copy(this.clanovi, tmp, clanovi.Length);
    this.clanovi = new ClanPolinoma[tmp.Length + 1];
    Array.Copy(tmp, this.clanovi, tmp.Length);
    clanovi[clanovi.Length - 1] = sabirak.Kopija();
  }

  public void Dodaj(Polinom sabirak){
    foreach(ClanPolinoma clan in sabirak.Clanovi){
      this.Dodaj(clan);
    }
  }

  public void Oduzmi(ClanPolinoma umanjilac){
    this.Dodaj(umanjilac.VratiSuprotan());
  }

  public void Oduzmi(Polinom umanjilac){
    foreach (ClanPolinoma clan in umanjilac.clanovi) {
      this.Oduzmi(clan);
    }
  }

  // public Polinom VratiSuprotan(){
    // Polinom tmp = new Polinom(this);
    // for (int i = 0; i < tmp.clanovi.Length; ++i) {
      // tmp.clanovi[i] = tmp.clanovi[i].VratiSuprotan();
    // }
    // return tmp;
  // }

  public void Pomnozi(double m){
    foreach (ClanPolinoma clan in clanovi) {
      clan.Koeficijent = m * clan.Koeficijent;
    }
  }

  public void Pomnozi(ClanPolinoma m){
    foreach (ClanPolinoma clan in clanovi) {
      clan.Koeficijent = clan.Koeficijent * m.Koeficijent;
      clan.Stepen = clan.Stepen + m.Stepen;
    }
  }

  public void Pomnozi(Polinom other){ //za popraviti celu logiku ...
    Polinom tmp;
    Polinom tmp1 = new Polinom();
    foreach (ClanPolinoma clan in other.clanovi) {
      tmp = new Polinom();
      tmp.Dodaj(this);
      tmp.Pomnozi(clan);
      tmp1.Dodaj(tmp);
    }
    this.clanovi = tmp1.clanovi;
  }

  public double Izracunaj(double x){
    double rezultat = 0;
    foreach (ClanPolinoma clan in clanovi) {
      rezultat += clan.Koeficijent * Math.Pow(x, clan.Stepen);
    }
    return rezultat;
  }

  public void Podeli(double m){
    m = 1/m;
    this.Pomnozi(m);
  }

  public void Podeli(ClanPolinoma deljenik){
    ClanPolinoma tmp = deljenik.Kopija();
    tmp.Koeficijent = 1/tmp.Koeficijent;
    tmp.Stepen = -tmp.Stepen;
    this.Pomnozi(tmp);
  }

  /// Deljenje mi nije islo, trenutan problem je sto nije celobrojno deljenje, a redom sam nailazio na jos par problema (ne moze ko kod ostalih primera da se uradio mnozenje sa reciprocnom vrednoscu), a ne znam ni na papiru da podelim polinom koriscenjem decimalnih brojeva
  // public void Podeli(Polinom delilac){ //ni ovo nema smisla
    // Polinom rezultat = new Polinom();
    // Polinom deljenik = new Polinom();
    // deljenik.Dodaj(this);
    // foreach (ClanPolinoma clan in this.clanovi) {
      // Polinom tmp = new Polinom();
      // tmp.Dodaj(deljenik);
      // tmp.Podeli(delilac.VratiNajveciStepen());
      // rezultat.Dodaj(tmp);
      // Console.WriteLine(rezultat);
      // tmp.Pomnozi(delilac);
      // deljenik.Oduzmi(tmp);
    // }
    // this.clanovi = deljenik.clanovi;
  // }

  public override string ToString(){
    string str = "";
    foreach (ClanPolinoma clan in clanovi) {
      str += clan.ToString() + " ";
    }
    return str;
  }

  public ClanPolinoma VratiNajveciStepen(){
    ClanPolinoma tmp = this.clanovi[0];
    foreach (ClanPolinoma clan in this.clanovi) {
      if (tmp.Stepen < clan.Stepen) tmp = clan;
    }
    Console.WriteLine(tmp);
    return tmp;
  }


}
