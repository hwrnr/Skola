using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
			LinkedList list = new LinkedList();
			list.AddPocetak(2);
            Console.WriteLine(list.Read(0));
			list.AddPocetak(12);
			list.AddPocetak(132);
            Console.WriteLine(list.Read(list.Find(12)));
            Console.WriteLine(list);
			list.DeleteLast();
            Console.WriteLine(list);
			list.DeleteFirst();
            Console.WriteLine(list);
			list.AddPocetak(112);
            list.AddPocetak(132);
            Console.WriteLine();
            Console.WriteLine(list);
			list.Delete(1);
            Console.WriteLine(list);

		}
    }
}
