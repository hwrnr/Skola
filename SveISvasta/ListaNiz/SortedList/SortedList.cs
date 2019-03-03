using System;
namespace SortedList1 {
    public enum Sorted {
        ASC,
        DESC
    };
	public class SortedList { //ne moze da bude genericka klasa, jer neki tipovi podataka nemaju operatore <, > (na primer string ili bilo koja nasa klasa)
        ListNode HEAD;
        uint length;
        private Sorted sorted;

        public Sorted Sort {
            get {
                return sorted;
            }
            set {
                if (value != sorted) {
                    this.Reverse();
                    sorted = value;
                }
            }
        }

        public SortedList() {
            length = 0;
            HEAD = null;
            sorted = Sorted.ASC;
        }

        public SortedList(Sorted sorted) {
            length = 0;
            HEAD = null;
            this.sorted = sorted;
        }

        public uint Length {
            get {
                return length;
            }
        }

        public bool isEmpty() {
            return length == 0;
        }

        public void Clear() {
            HEAD = null;
            length = 0;
        }

        public bool Add(int data) {
            if (length == 0) return this.Add(data, 0);
            if (length == 1) {
                if (sorted == Sorted.ASC) {
                    if (data > HEAD.Data) {
                        return this.Add(data, 1);
                    }
                    else return this.Add(data, 0);
                }
                else {
                    if (data > HEAD.Data) {
                        return this.Add(data, 0);
                    }
                    else return this.Add(data, 1);
                }
            }
            ListNode tmp = HEAD;
            uint i = 0;
            if (sorted == Sorted.ASC) {
                if (data > HEAD.Data) {
                    while (data > tmp.Data) {
                        tmp = tmp.next;
                        ++i;
                        if (tmp == null) break;
                    }
                }
            }
            else {
                if (data < HEAD.Data) {
                    while (data < tmp.Data) {
                        tmp = tmp.next;
                        ++i;
                        if (tmp == null) break;
                    }
                }
            }

            return this.Add(data, i);
        }

        private bool Add(int data, uint index) {
            if (index > length) return false;
            if (length == 0) {
                HEAD = new ListNode(data);
            }
            else {
                ListNode tmp = HEAD;
                uint i = 0;
                if (index == 0) {
                    HEAD = new ListNode(data, HEAD);
                }
                else {
                    while (i != index - 1) {
                        ++i;
                        tmp = tmp.next;
                    }
                    tmp.next = new ListNode(data, tmp.next);
                }
            }
            ++length;
            return true;
        }

        public bool Delete(uint index) {
            if (index > length - 1) return false;
            if (length == 1) {
                HEAD = null;
                length = 0;
                return true;
            }
            ListNode tmp = HEAD;
            uint i = 0;
            if (index == 0) {
                HEAD = HEAD.next;
                --length;
                return true;
            }
            while (i < index - 1) {
                ++i;
                tmp = tmp.next;
            }
            tmp.next = tmp.next.next;
            --length;
            return true;
        }

        public bool DeleteFirst() {
            return this.Delete(0);
        }

        public bool DeleteLast() {
            return this.Delete(length - 1);
        }

		public bool Add(SortedList list){
			try {
				while (true){
					this.Add(list.Pop());
				}
			}
			catch {
				return true;
			}
		}

        public int getByIndex(uint index) {
            if (index > length - 1) throw new System.IndexOutOfRangeException();
            ListNode tmp = HEAD;
            uint i = 0;
            while (i < index) {
                tmp = tmp.next;
                ++i;
            }
            return tmp.Data;
        }

        public int Read(uint index) {
            return this.getByIndex(index);
        }

        public int Pop() {
            if (length == 0) throw new System.InvalidOperationException("Can't pop from empty list");
            try {
                int tmp = this.getByIndex(length - 1);
                this.Delete(length - 1);
                return tmp;
            }
            catch (Exception e) {
                throw e;
            }
        }

        private void Reverse() { //ovo je sve samo ne optimizovano
            SortedList newList = new SortedList();
            try {
                while (true)
                    newList.Add(this.Pop(), newList.Length);
            }
            catch (System.InvalidOperationException) {

            }
            this.HEAD = newList.HEAD;
            this.length = newList.length;
        }

        public int Find(int elementintoFind) {
            ListNode tmp = HEAD;
            for (int i = 0; i < length; ++i) {
                if (tmp.Data.Equals(elementintoFind)) return i;
                tmp = tmp.next;
            }
            return -1;
        }

        public override string ToString() {
            string str = String.Empty;
            ListNode tmp = HEAD;
            for (uint i = 0; i < length; ++i) {
                str += tmp + " ";
                tmp = tmp.next;
            }
            return str;
        }

    }
}
