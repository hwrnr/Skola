using System;
using LinkedListNameSpace;

namespace Sortiranje {
    class MainClass {
        public static void Main(string[] args) {
            /*int[] array;
            int[] copy;
            //Console.WriteLine(ArrayHelper.GetString(array));

            //Selection sort
            array = ArrayHelper.GetRandomArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Selection(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }


            array = ArrayHelper.GetNullArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Selection(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetSortedArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Selection(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetReversedArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Selection(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetWithDuplicatesArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Selection(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            //Bubble sort

            array = ArrayHelper.GetRandomArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }


            array = ArrayHelper.GetNullArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetSortedArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetReversedArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetWithDuplicatesArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            //insertion

            array = ArrayHelper.GetRandomArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }


            array = ArrayHelper.GetNullArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetSortedArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetReversedArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            array = ArrayHelper.GetWithDuplicatesArray(24);
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Bubble(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            if (!ArrayHelper.CheckIfGood(array, copy)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            Console.WriteLine("Sva sortiranja rade na zadatim testovima");

            for (int i = 0; i < 100; i++) {
                array = ArrayHelper.GetRandomArray();
                if (array[ArrayHelper.Find.MaxIndex(array)] != ArrayHelper.Find.MaxElement(array)) {
                    Console.WriteLine("Vrednost elementa na osnovu indeksa nije jednaka maksimalnom");
                    return;
                }
                ArrayHelper.Sort.Selection(array);
                if (array[ArrayHelper.Find.MaxIndex(array)] != array[array.Length - 1]) {
                    Console.WriteLine("Vrednost elementa na prvom mestu u sortiranom nizu nije maksimum");
                    return;
                }
            }

            for (int i = 0; i < 100; i++) {
                array = ArrayHelper.GetRandomArray();
                if (array[ArrayHelper.Find.MinIndex(array)] != ArrayHelper.Find.MinElement(array)) {
                    Console.WriteLine("Vrednost elementa na osnovu indeksa nije jednaka minimalnom");
                    return;
                }
                ArrayHelper.Sort.Selection(array);
                if (ArrayHelper.Find.MinIndex(array) != 0) {
                    Console.WriteLine("Vrednost elementa na prvom mestu u sortiranom nizu nije minimum");
                    return;
                }
            }

            Console.WriteLine("Vrednosti minalnih i maksimalnih na osnovu indeksa jesu dobri");

            Console.WriteLine("Lista");

            LinkedList<int> list;
            LinkedList<int> copyList;
            //Console.WriteLine(ListHelper.GetString(list));

            //Selection sort
            list = ListHelper.GetRandomList();
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Selection(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList) ){
                Console.WriteLine("Sort ne radi");
                return;
            }


            list = ListHelper.GetNullList();
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Selection(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetSortedList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Selection(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetReversedList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Selection(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetWithDuplicatesList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Selection(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            //Bubble sort

            list = ListHelper.GetRandomList();
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }


            list = ListHelper.GetNullList();
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetSortedList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetReversedList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetWithDuplicatesList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            //insertion

            list = ListHelper.GetRandomList();
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }


            list = ListHelper.GetNullList();
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetSortedList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetReversedList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            list = ListHelper.GetWithDuplicatesList(24);
            copyList = ListHelper.GetCopyOfList(list);
            ListHelper.Sort.Bubble(list);
            //Console.WriteLine(ListHelper.GetString(list));
            if (!ListHelper.CheckIfGood(list, copyList)) {
                Console.WriteLine("Sort ne radi");
                return;
            }

            Console.WriteLine("Sva sortiranja rade na zadatim testovima");

            for (int i = 0; i < 100; i++) {
                list = ListHelper.GetRandomList();
                if (list.Read((uint)ListHelper.Find.MaxIndex(list)) != ListHelper.Find.MaxElement(list)) {
                    Console.WriteLine("Vrednost elementa na osnovu indeksa nije jednaka maksimalnom");
                    return;
                }
                ListHelper.Sort.Selection(list);
                if (list.Read((uint)ListHelper.Find.MaxIndex(list)) != list.Read((uint)list.Length - 1)) {
                    Console.WriteLine("Vrednost elementa na prvom mestu u sortiranom nizu nije maksimum");
                    return;
                }
            }

            for (int i = 0; i < 100; i++) {
                list = ListHelper.GetRandomList();
                if (list.Read((uint)ListHelper.Find.MinIndex(list)) != ListHelper.Find.MinElement(list)) {
                    Console.WriteLine("Vrednost elementa na osnovu indeksa nije jednaka minimalnom");
                    return;
                }
                ListHelper.Sort.Selection(list);
                if (ListHelper.Find.MinIndex(list) != 0) {
                    Console.WriteLine("Vrednost elementa na prvom mestu u sortiranom nizu nije minimum");
                    return;
                }
            }

            Console.WriteLine("Vrednosti minalnih i maksimalnih na osnovu indeksa jesu dobri");

            array = ArrayHelper.GetRandomArray();
            copy = ArrayHelper.GetCopyOfArray(array);
            ArrayHelper.Sort.Insertion(array);
            //Console.WriteLine(ArrayHelper.GetString(array));
            //Console.WriteLine(ArrayHelper.CheckIfGood(array, copy));
            */

            Ucenik uc1 = new Ucenik(tezina: 12);
            Console.WriteLine(uc1);

            Ucenik[] ucenici = new Ucenik[] { new Ucenik(ime: "Petar", prezime: "Spasic"), new Ucenik() };
            //foreach (Ucenik ucenik in ucenici) {
            //    Console.WriteLine(ucenik);
            //}

            Ucenik[] ucenici1 = new Ucenik[5];
            ucenici1[0] = ucenici[1];
            ucenici1[1] = uc1;
            Console.WriteLine(ucenici1[3]); //ispisace isto sto i Console.WriteLine(); (samo novi red)

            ucenici = new Ucenik[40];
            Random rand = new Random();

            for (int i = 0; i < ucenici.Length; ++i) {
                ucenici[i] = new Ucenik(visina: Math.Round(rand.NextDouble() * 50 + 150, 2), tezina: Math.Round(rand.NextDouble() * 50 + 50, 2), prosek: Math.Round(rand.NextDouble() * 4 + 1, 2));
            }

            ucenici[0] = new Ucenik(visina: 140, tezina: 50); //uzeo sam ekstremnu visine, da bi lako nasao
            ucenici[34] = new Ucenik(visina: 140, tezina: 49);

            ucenici[20] = new Ucenik(visina: 201, tezina: Math.Round(rand.NextDouble() * 50 + 50, 2));
            ucenici[21] = new Ucenik(visina: 201, tezina: Math.Round(rand.NextDouble() * 50 + 50, 2));

            //foreach(Ucenik ucenik in ucenici) {
            //    Console.WriteLine(ucenik);
            //}

            System.Collections.Generic.List<Ucenik> listaUcenika = new System.Collections.Generic.List<Ucenik>(ucenici);

            listaUcenika.Sort((x, y) => x.Prosek.CompareTo(y.Prosek)); //sortiranje po proseku
            // gore mozemo po bilo cemu drugom sortirati

            foreach (Ucenik ucenik in listaUcenika) {
                Console.WriteLine(ucenik);
            }

            Ucenik[] kopija = ArrayHelper<Ucenik>.GetCopyOfArray(ucenici);
            ArrayHelper<Ucenik>.Sort.Selection(ucenici);

            Console.WriteLine("Moj sort");
            Console.WriteLine(ArrayHelper<Ucenik>.GetString(ucenici));
            if (!ArrayHelper<Ucenik>.CheckIfGood(ucenici, kopija)) {
                Console.WriteLine("Sort ne radi");
            }


        }
    }
}
