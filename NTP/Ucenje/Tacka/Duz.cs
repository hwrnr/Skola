using System;
class Duz{
  private Tacka t1;
  private Tacka t2;
  public Tacka T1 { get{return t1;} set{t1.X = value.X; t1.Y = value.Y;} }
  public Tacka T2 { get{return t2;} set{t2.X = value.X; t2.Y = value.Y;} }

  public Duz(){
    t1 = new Tacka();
    t2 = new Tacka();
  }

  public Duz(Tacka tacka1, Tacka tacka2){
    t1 = tacka1;
    t2 = tacka2;
  }

  public Duz(double x1, double y1, double x2, double y2){
    t1.X = x1;
    t1.Y = y1;
    t2.X = x2;
    t2.Y = y2;
  }

  public double Duzina(){
    return Math.Sqrt(Math.Sqrt(Math.Pow(t1.X - t2.X, 2) + Math.Pow(t1.Y - t2.Y, 2)));
  }

  public override string ToString(){
    string str = "|" + t1 + ", " + t2 + "|";
    return str;
  }

  public void FlipHorizontalno(){
    t1.FlipHorizontalno();
    t2.FlipHorizontalno();
  }

  public void FlipVertikalno(){
    t1.FlipVertikalno();
    t2.FlipVertikalno();
  }
}
