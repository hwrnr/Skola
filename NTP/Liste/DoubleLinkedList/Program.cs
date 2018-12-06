using System;

namespace DoubleLinkedList {
    class MainClass {
		public static void Main(string[] args) {
			DoubleLinkedList<int> lista = new DoubleLinkedList<int>();
            int[] niz = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            for (uint i = 0; i < niz.Length; ++i){
                if(!lista.Push(niz[i])) Console.WriteLine("greska");
            }
            if (!lista.isEmpty())
                Console.WriteLine(lista);
            else
                Console.WriteLine("Greska");

            /*try {
                int tmp = lista.getByIndex(3);
                Console.WriteLine(tmp);
                while (true) Console.WriteLine(lista.Pop());
            }
            catch (System.IndexOutOfRangeException){
                Console.WriteLine("Desio se izlazak iz skupa indeksa");
            }
            catch(System.InvalidOperationException){
                Console.WriteLine("Ne moze da se radi Pop() nad praznom listom");
            }*/
            if (lista == null)
            {
                Console.WriteLine("Lista je null iz nekog razloga");
                return;
            }
            lista.AddFirst(3);
            lista.AddFirst(1);
			//lista.Add(31, 4);
            Console.WriteLine(lista);
            lista.Add(2, 1);
            lista.Add(0, 0);
            lista.Delete(1);
            Console.WriteLine(lista);
            Console.WriteLine(lista.Length);
            lista.Clear();
            Console.WriteLine(lista);
            lista.Push(1);
            Console.WriteLine(lista);


            lista.Clear();
            niz = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            for (uint i = 0; i < niz.Length; ++i) {
                if (!lista.Push(niz[i])) Console.WriteLine("greska");
            }

            Console.WriteLine(lista);
			lista.Update(31, 3);
            Console.WriteLine(lista);

            Console.WriteLine(lista.Find(3));

        }
    }
}
