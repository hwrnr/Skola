using System;


class ClanPolinoma{
  private double koeficijent;
  private int stepen;
  public double Koeficijent { get {return koeficijent;} set{koeficijent = value;} }
  public int Stepen { get{return stepen;} set{stepen = value;} }

  public ClanPolinoma(double koeficijent, int stepen){
    this.koeficijent = koeficijent;
    this.stepen = stepen;
  }
  
  // public ClanPolinoma(ClanPolinoma other){
    // this.koeficijent =  0 + other.koeficijent;
    // this.stepen = 0 + other.stepen;
  // }

  public ClanPolinoma Kopija(){
    ClanPolinoma tmp = new ClanPolinoma(this.koeficijent, this.stepen);
    return tmp;
  }

  public bool Dodaj(ClanPolinoma sabirak){
    if(this.stepen != sabirak.stepen) return false;
    this.koeficijent += sabirak.koeficijent;
    return true;
  }

  public ClanPolinoma VratiSuprotan(){
    ClanPolinoma tmp = this.Kopija();
    tmp.koeficijent = 0 - tmp.koeficijent;
    return tmp;
  }

  public override string ToString(){
    string str = "";
    str += koeficijent + "X^" + stepen;
    return str;
  }

}
