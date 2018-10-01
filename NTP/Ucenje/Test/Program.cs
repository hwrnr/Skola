using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
          int x = new int();
          x = Convert.ToInt32(Console.ReadLine());
          if (x % 2 == 1) Console.WriteLine("{0} je neparan", x);
          else Console.WriteLine("{0} je paran", x);
        }
    }
}
