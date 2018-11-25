using System;

//za varijantu jedan samo obrisati enum i delove koda koji su vezani za DESC sortiranje liste
//razlika je u znaku, da li koristimo > ili < za proveru pri dodavanju elemnta

//metode poput Swap bi unistile smisao stalno sortirane liste jer onda ne bi bila stalno sortirana
//Metode AddFirst AddLast i slicno ne mogu da postoje iz istog razloga

//sve metode su pozvane, samo sto nisu sve pozvane iz Main(), nego je pozvana metoda koja je pozvala neku drugu metodu ili su vec ispitane u LinkedList a nista se nije menjalo za njen rad u odnosu na LinkedList (isEmpty, Lenght,...)

namespace SortedList1 {
    class MainClass {
        public static void Main(string[] args) {
            SortedList list = new SortedList();
            list.Add(12);
            list.Add(13);
            list.Add(43);
            list.Add(1);
            list.Add(0);
            list.Add(123);
            list.Add(221);
            list.Add(112);
            list.Add(7);
            list.Add(423);
            list.Add(17);
            list.Add(10);
            list.Add(1123);
            list.Add(32);
            Console.WriteLine(list);
            list.Sort = Sorted.DESC;
            Console.WriteLine(list);
            list.DeleteFirst();
            list.DeleteLast();
            list.Delete(2);
            list.Delete(9);
            list.Delete(5);
            Console.WriteLine(list);
			SortedList helpingList = new SortedList();
			helpingList.Add(1);
			helpingList.Add(31);
			list.Add(helpingList);
            Console.WriteLine(list);
        }
    }
}
