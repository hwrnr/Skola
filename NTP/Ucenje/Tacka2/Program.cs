using System;

namespace Tacka2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tacka T1, T2;
            Tacka T1 = new Tacka(3, 4);
            Tacka T2 = new Tacka(5, 6);
            Console.WriteLine("Pre flip:\n\tT1: " + T1 + "\n\tT2: " + T2);
            T1.FlipHorizontalno();
            T1.FlipVertikalno();
            Console.WriteLine("Posle flip:\n\tT1: " + T1 + "\n\tT2: " + T2);

            Duz D1 = new Duz(T1, T2);
            Console.WriteLine("Duz: " + D1);
            D1.FlipHorizontalno();
            D1.FlipVertikalno();
            Console.WriteLine("Duz posle flip: " + D1);
            Console.WriteLine("Tacke posle flip duz: " + T1 + T2);

            double d = new Double();
            d = 12;
            Kvadrat k1 = new Kvadrat(); 
            Kvadrat k2 = new Kvadrat(T1, d);
            Kvadrat k3 = new Kvadrat (T1);
            Kvadrat k4 = new Kvadrat(d);
            Kvadrat k5 = new Kvadrat(T1, T2);
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            k2.FlipHorizontalno();
            k2.FlipVertikalno();
            Console.WriteLine(k2);
            Console.WriteLine(k3);
            Console.WriteLine(k4);
            Console.WriteLine(k5);
            Console.WriteLine(k2.GetPovrsina());
            Console.WriteLine(k2.GetObim());
            Console.WriteLine(k2.Nacrtaj());
        }
    }
}
