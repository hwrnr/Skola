using System;
namespace Sortiranje {
    public static class ArrayHelper<T> where T : IComparable, ICloneable {

        public static bool CheckIfGood(T[] array, T[] controlArray) {
            try {
                if (array.Length != controlArray.Length) return false;
                Array.Sort(controlArray); // ova metoda je proverena da radi pa je najlakse sa njom proveravati
                for (int i = 0; i < array.Length; i++) {
                    if (!array[i].Equals(controlArray[i])) {
                        return false; 
                    }
                }
                return true;
            }
            catch {
                return array == controlArray && array == null;
            }
        }

        public static T[] GetCopyOfArray(T[] array) {
            try {
                T[] copy = new T[array.Length];
                for (int i = 0; i < array.Length; ++i) {
                    copy[i] = (T)array[i].Clone();
                }
                return copy;
            }
            catch {
                return null;
            }
        }

        public static string GetString(T[] array) { //da se ne pomesa sa ToString()
            if (array == null) return "null";
            string str = String.Empty;
            for (int i = 0; i < array.Length; ++i) {
                str += array[i] + Environment.NewLine;
            }
            str += Environment.NewLine;
            return str;
        }

        public static class Sort {
            public static void Selection(T[] array){
                if (array == null) return; //sto se mene tice null je savrseno sortiran
                int min; 
                T tmp;
                for (int i = 0; i < array.Length; ++i) {
                    min = i;
                    for (int j = i + 1; j < array.Length; ++j) {
                        if (array[j].CompareTo(array[min]) < 0) {
                            min = j;
                        }
                    }
                    if (min != i) {
                        tmp = array[min];
                        array[min] = array[i];
                        array[i] = tmp;
                    }
                }
            }

            public static void Bubble(T[] array) {
                if (array == null || array.Length == 1) return; //sto se mene tice null je savrseno sortiran
                T tmp;
                for (int i = 0; i < array.Length; ++i) {
                    for (int j = 0; j < array.Length - i - 1; ++j) {
                        if (array[j + 1].CompareTo(array[j]) < 0) {
                            tmp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = tmp;
                        }
                    }
                }
            }

            public static void Insertion(T[] array) {
                if (array == null || array.Length == 1) return;
                T tmp;
                for (int i = 0; i < array.Length; ++i) {
                    for (int j = i - 1; j > 0; --j) {
                        if (array[j].CompareTo(array[j - 1]) < 0) {
                            tmp = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = tmp;
                        }
                        else {
                            break;
                        }
                    }
                }
            }

            private static int QuickChoosePivot(T[] array) {
                return array.Length / 2; //ovo treba lepse napisati
            }

            public static void Quick(T[] array) {
                if (array == null || array.Length == 1) return;
                int pivot = QuickChoosePivot(array);

                //TODO: QuickSort
            }
        }

        public static class Find {

            public static int MaxIndex(T[] array) {
                if (array == null) throw new Exception("Array is null");
                int max = 0;
                for (int i = 0; i < array.Length; i++) {
                    if (array[i].CompareTo(array[max]) > 0) {
                        max = i;
                    }
                }
                return max;
            }

            public static T MaxElement(T[] array) {
                if (array == null) throw new Exception("Array is null");
                return array[MaxIndex(array)];
            }

            public static int MinIndex(T[] array) {
                if (array == null) throw new Exception("Array is null");
                int min = 0;
                for (int i = 0; i < array.Length; i++) {
                    if (array[i].CompareTo(array[min]) < 0) {
                        min = i;
                    }
                }
                return min;
            }

            public static T MinElement(T[] array) {
                if (array == null) throw new Exception("Array is null");
                return array[MinIndex(array)];
            }
        }
    }
}
