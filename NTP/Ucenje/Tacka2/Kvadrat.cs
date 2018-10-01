using System;
class Kvadrat{
  private Tacka t;
  Tacka T { get{return t;} set{t = value;}}

  private double duzina;
  double Duzina { get{return duzina;} set {duzina = value;} }

  public Kvadrat(){
    t = new Tacka();
    duzina = 0.0;
  }
  public Kvadrat(Tacka t){
    this.t = t;
    duzina = 0;
  }
  public Kvadrat(Tacka t, double duzina){
    this.t = t;
    this.duzina = duzina;
  }
  public Kvadrat(double duzina){
    this.t = new Tacka();
    this.duzina = duzina;
  }
  public Kvadrat(Tacka t1, Tacka t2){
    if (t1.X == t2.X || t1.X == t2.Y){
      Duz temp = new Duz(t1, t2);
      this.duzina = temp.Duzina();
    }
    else{
      Duz temp = new Duz(t1, t2);
      duzina = temp.Duzina()/Math.Sqrt(2);
    }
    t = new Tacka(Math.Min(t1.X, t2.X), Math.Min(t1.Y, t2.Y));
  }
  public double GetPovrsina(){
    return duzina * duzina;
  }
  public double GetObim(){
    return 4 * duzina;
  }
  public override string ToString(){
    string str = "Koordinate: " + t + new Tacka (t.X + duzina, t.Y) + new Tacka(t.X, t.Y + duzina) + new Tacka(t.X + duzina, t.Y + duzina);
    return str;
  }
  public void FlipHorizontalno(){
    t.X = -(t.X + duzina);
  }
  public void FlipVertikalno(){
    t. Y = -(t.Y + duzina);
  }
  public string Nacrtaj(){
    //crta se sa zaokruzenim vrednostima po manjoj vrednosti
    int i = 0, j = 0;
    string str = "";
    for (i = 0; i < duzina; ++i){
      str += "* ";
    }
    str += "\n";
    for (i = 1; i < duzina - 1; ++i){
      str += "* ";
      for (j = 1; j < duzina - 1; ++j){
        str += "  ";
      }
      str += "*\n";
    }
    for (i = 0; i < duzina; ++i){
      str += "* ";
    }
    return str;
  }
}
