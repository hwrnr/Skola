using System;
using LinkedListNameSpace;

namespace Sortiranje {
    public static class ListHelper {
        public static LinkedList<int> GetNullList() {
            return null;
        }

        public static LinkedList<int> GetRandomList() {
            Random rand = new Random();
            LinkedList<int> list = new LinkedList<int>();
            int length = rand.Next(22, 40);
            for (int i = 0; i < length; ++i) {
                list.AddLast(rand.Next(1000));
            }
            return list;
        }

        public static LinkedList<int> GetSortedList(uint length) {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < length; ++i) {
                list.AddLast(i + 1);
            }
            return list;
        }

        public static LinkedList<int> GetReversedList(uint length) {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < length; ++i) {
                list.AddLast((int)(length - i));
            }
            return list;
        }

        public static LinkedList<int> GetWithDuplicatesList(uint length) {
            LinkedList<int> list = new LinkedList<int>();
            Random rand = new Random();
            int add;
            for (int i = 0; i < length; ++i) {
                add = rand.Next(1000);
                list.AddLast(add);
                if (rand.Next(1000) % (length / 4 + 1) == 0 && i + 1 != length) {
                    ++i;
                    list.AddLast(add);
                }
            }
            return list;
        }

        public static bool CheckIfGood(LinkedList<int> list, LinkedList<int> controlList) {
            try {
                if (list.Length != controlList.Length) return false;
                int[] controlArray = new int[controlList.Length];
                for (int i = 0; i < controlArray.Length; ++i) {
                    controlArray[i] = controlList.Read((uint)i);
                }
                Array.Sort(controlArray); // ova metoda je proverena da radi pa je najlakse sa njom proveravati
                for (int i = 0; i < controlArray.Length; ++i) {
                    if (controlArray[i] != list.Read((uint)i)) return false;
                }
                return true;
            }
            catch {
                return list == controlList && list == null;
            }
        }

        public static LinkedList<int> GetCopyOfList(LinkedList<int> list) {
            try {
                LinkedList<int> copy = new LinkedList<int>();
                for (int i = 0; i < list.Length; ++i) {
                    copy.AddLast(list.Read((uint)i));
                }
                return copy;
            }
            catch {
                return null;
            }
        }

        public static string GetString(LinkedList<int> list) { //da se ne pomesa sa ToString()
            return list.ToString();
        }


        public static class Sort {
            public static void Selection(LinkedList<int> list) {
                if (list == null || list.Length == 1) return; //sto se mene tice null je savrseno sortiran
                int min;
                for (int i = 0; i < list.Length; ++i) {
                    min = i;
                    for (int j = i + 1; j < list.Length; ++j) {
                        if (list.Read((uint)j) < list.Read((uint) min)) {
                            min = j;
                        }
                    }
                    if (min != i) {
                        list.Swap((uint)min, (uint) i);
                    }
                }
            }

            public static void Bubble(LinkedList<int> list) {
                if (list == null || list.Length == 1) return; //sto se mene tice null je savrseno sortiran
                for (int i = 0; i < list.Length; ++i) {
                    for (int j = 0; j < list.Length - i - 1; ++j) {
                        if (list.Read((uint)j + 1) < list.Read((uint) j)){
                            list.Swap((uint)j, (uint)j + 1);
                        }
                    }
                }
            }

            public static void Insertion(LinkedList<int> list) {
                if (list == null || list.Length == 1) return;
                for (int i = 0; i < list.Length; ++i) {
                    for (int j = i - 1; j > 0; --j) {
                        if (list.Read((uint)j) < list.Read((uint) j - 1)) {
                            list.Swap((uint) j, (uint) j - 1);
                        }
                        else {
                            break;
                        }
                    }
                }
            }
        }

        public static class Find {

            public static int MaxIndex(LinkedList<int> list) {
                if (list == null) throw new Exception("Array is null");
                int max = 0;
                for (int i = 0; i < list.Length; i++) {
                    if (list.Read((uint) i) > list.Read((uint)max)) {
                        max = i;
                    }
                }
                return max;
            }

            public static int MaxElement(LinkedList<int> list) {
                if (list == null) throw new Exception("Array is null");
                return list.Read((uint)MaxIndex(list));
            }

            public static int MinIndex(LinkedList<int> list) {
                if (list == null) throw new Exception("Array is null");
                int min = 0;
                for (int i = 0; i < list.Length; i++) {
                    if (list.Read((uint)i) < list.Read((uint)min)) {
                        min = i;
                    }
                }
                return min;
            }

            public static int MinElement(LinkedList<int> list) {
                if (list == null) throw new Exception("Array is null");
                return list.Read((uint)MinIndex(list));
            }
        }

    }
}
