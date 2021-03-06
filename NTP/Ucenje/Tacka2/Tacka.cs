
class Tacka{
  private double x;
  private double y;

  public double X { get{return x;} set{ x = value;} }
  public double Y { get{return y;} set{ y = value;} }
  
  public Tacka(){
    x = 0;
    y = 0;
  }

  public Tacka(double xx, double yy){
    x = xx;
    y = yy;
  }
  public Tacka(Tacka t){
    x = t.X;
    y = t.Y;
  }

  public void FlipHorizontalno(){
    x = -x;
  }

  public void FlipVertikalno(){
    y = -y;
  }

  public override string ToString(){
    string str = "(" + X + ", " + y + ")";
    return str;
  }
}
