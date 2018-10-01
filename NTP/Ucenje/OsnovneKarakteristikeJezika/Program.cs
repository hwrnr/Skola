using System;

//radio sam sve u jednom zadatku, nece se promeniti kada se t.X prosledi u promeniDouble
namespace OsnovneKarakteristikeJezika{
class Program
{
static void Main(string[] args)
{
A a = new A();
Console.WriteLine(a.X);
}
}

class A
{
private int x;

public int X
{
get { return x; }
set { x = value; }
}
}
}

// namespace OsnovneKarakteristikeJezika
// {
    // class Program
    // {
        // static void PromeniDouble(double x){
          // x = 17;
        // }
        // static void Main(string[] args)
        // {
          // Console.WriteLine("Jednakost objekata");
          // Tacka a = new Tacka(3, 5);
          // Tacka b = new Tacka(3, 5);
          // if (a == b)
            // Console.WriteLine("jednaki");
          // else
            // Console.WriteLine("razliciti");
          // Console.WriteLine("*****************\n\n");
//
//
          // Console.WriteLine("Jednakost objekata 2");
          // Tacka c = new Tacka(3, 5);
          // Tacka d = c;
          // d.X = 100;
          // if (c == d)
            // Console.WriteLine("jednaki");
          // else
            // Console.WriteLine("razliciti");
          // Console.WriteLine("*****************\n\n");
//
//
          // Console.WriteLine("Jednakost stringova");
          // string str1 = "Vuk";
          // string str2 = "Vuk";
          // if (str1 == str2)
            // Console.WriteLine("jednaki");
          // else
            // Console.WriteLine("razliciti");
          // Console.WriteLine("*****************\n\n");
//
//
          // Console.WriteLine("Jednakost stringova 2");
          // string str3 = "Vuk";
          // string str4 = str3;
          // str4 = "Todorovic";
          // if (str3 == str4)
            // Console.WriteLine("jednaki");
          // else
            // Console.WriteLine("razliciti");
          // Console.WriteLine("*****************\n\n");
//
//
          // Console.WriteLine("Provera nacina rada");
          // Tacka t = new Tacka(3, 4);
          // PromeniDouble(t.X);
          // Console.WriteLine(t);
        // }
    // }
// }
