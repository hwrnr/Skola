using System;

namespace Zad_Tacka
{
    class Program
    {
        static void Main(string[] args)
        {
           Tacka a1 = new Tacka(1, 2);
           Tacka a2 = new Tacka(3, 4);
           Duz d = new Duz(a1, a2);
          
           a2.X = 5;
           a2.Y = 6;

           Console.WriteLine(d);

           //Zato sto polja u duzi pokazuju na originalna polja; Tako sto cemo u konstruktoru napraviti novo polje tacke; Zavisi od slucaja do slucaja;
           //Mozemo napraviti objekat klase duz, sa istim tackama, i ta duz ce imati duzinu 0;
           //Imacemo isti slucaj kao prethodno
        }
    }
}
