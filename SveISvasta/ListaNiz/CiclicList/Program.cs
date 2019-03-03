using System;
using CiclicListNameSpace;

namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			CiclicList<int> lista = new CiclicList<int>();
			lista.Add(3, 0);
			lista.AddLast(323);
          	lista.AddFirst(324);
          	lista.Add(1, 1);
          	lista.Add(3, 0);
          	lista.AddLast(323);
          	lista.AddFirst(324);
          	lista.Add(1, 1);
          	lista.Delete(0);
          	lista.DeleteFirst();
          	lista.DeleteLast();
          	lista.Pop();
          	lista.Delete(1);
            Console.WriteLine(lista);
        }
    }
}
