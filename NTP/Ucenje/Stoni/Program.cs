using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args){
            int X = new int();
            // X = Convert.ToInt32(Console.ReadLine());
            X = 12;
            if (X % 2 == 1) Console.WriteLine("{0} je neparan", X);
            else Console.WriteLine("{0} je paran", X);
        }
    }
}
