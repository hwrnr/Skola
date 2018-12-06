using System;
namespace DoubleLinkedList {
    public class DoubleLinkedList<T> {
		ListNode<T> HEAD;
		ListNode<T> TAIL;
        uint length;

        public DoubleLinkedList() {
            length = 0;
            HEAD = null;
			TAIL = null;
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
			TAIL = null;
            length = 0;
        }

        public bool Add(T data, uint index) {
            if (index > length) return false;
            if (length == 0) {
                HEAD = new ListNode<T>(data);
				TAIL = HEAD;
            }
            else {
				if (index < length / 2) {
					ListNode<T> tmp = HEAD;
					uint i = 0;
					if (index == 0) {
						HEAD = new ListNode<T>(data, HEAD);
					}
					else {
						while (i != index - 1) {
							++i;
							tmp = tmp.next;
						}
						tmp.next = new ListNode<T>(data, tmp.next, tmp);
					}
					if (index == length) {
						TAIL = tmp.next;
					}
				}
				else{
					index = length - index;
					ListNode<T> tmp = TAIL;
                    uint i = 0;
                    if (index == 0) {
                        TAIL = new ListNode<T>(data, null, TAIL);
						TAIL.prev.next = TAIL;
                    }
                    else {
                        while (i != index + 1) {
                            ++i;
                            tmp = tmp.prev;
                        }
                        tmp.prev = new ListNode<T>(data, tmp, tmp.prev);
                    }
				}
            }
            ++length;
            return true;
        }

        public bool AddLast(T data) {
            return this.Add(data, length);
        }

        public bool AddFirst(T data) {
            return this.Add(data, 0);
        }

        public bool Push(T data) {
            return this.AddLast(data);
        }

        public bool Delete(uint index) {
            if (index > length - 1) return false;
            if (length == 1) {
                HEAD = null;
                length = 0;
                return true;
            }
            ListNode<T> tmp = HEAD;
            uint i = 0;
            if (index == 0) {
                HEAD = HEAD.next;
				HEAD.prev = null;
                --length;
                return true;
            }
			else if (1==0 && index == length - 1){
				TAIL = TAIL.prev;
				TAIL.next = null;
				--length;
				return true;
			}
            while (i < index - 1) {
                ++i;
                tmp = tmp.next;
            }
            if (tmp.next != null)  
				tmp.next = tmp.next.next;
			if (tmp.next != null) tmp.next.prev = tmp;
			else TAIL = tmp;
            --length;
            return true;
        }

        public bool DeleteFirst() {
            return this.Delete(0);
        }

        public bool DeleteLast() {
            return this.Delete(length - 1);
        }

        public T getByIndex(uint index) {
            if (index > length - 1) throw new System.IndexOutOfRangeException();
            ListNode<T> tmp = HEAD;
            uint i = 0;
            while (i < index) {
                tmp = tmp.next;
                ++i;
            }
            return tmp.data;
        }

        public T Read(uint index) {
            return this.getByIndex(index);
        }

		public bool Update(T data, uint index){
			if (index > length - 1) return false;
			if (index < length / 2){
				ListNode<T> tmp = HEAD;
				uint i = 0;
				while (i < index){
					tmp = tmp.next;
					++i;
				}
				tmp.data = data;
			}
			else {
				ListNode<T> tmp = TAIL;
				uint i = length - 1;
				while (i > index){
					tmp = tmp.prev;
					++i;
				}
                tmp.data = data;
			}
			return true;
		}


        public bool Add(DoubleLinkedList<T> other) {
            if (other == null) return false;
            ListNode<T> tmp = HEAD;
            if (this.length == 0) {
                HEAD = other.HEAD;
                this.length = other.length;
                return true;
            }
            uint i = 0;
            while (i < length - 1) {
                ++i;
                tmp = tmp.next;
            }
            tmp.next = other.HEAD;
			other.HEAD.prev = tmp;
            length = length + other.length;
            return true;
        }

		public bool Merge(DoubleLinkedList<T> ListToMerge) {
            return this.Add(ListToMerge);
        }

        public bool Swap(uint index1, uint index2) {
            if (index1 == index2) return true; //uradili smo swap, ali je ostalo sve kako je bilo
            if (index1 > length - 1 || index2 > length - 1) return false;
            T tmp1 = this.getByIndex(index1);
            T tmp2 = this.getByIndex(index2);
            this.Delete(index1);
			this.Add(tmp2, index1);
            this.Delete(index2);
            this.Add(tmp1, index2);
            return true;
        }
        
        public int Find(T elementToFind) {
            ListNode<T> tmp = HEAD;
            for (int i = 0; i < length; ++i) {
                if (tmp.data.Equals(elementToFind)) return i;
                tmp = tmp.next;
            }
            return -1;
        }

        public override string ToString() {
            string str = String.Empty;
            ListNode<T> tmp = HEAD;
            for (uint i = 0; i < length; ++i) {
				//Console.WriteLine(tmp);
                str += tmp + " ";
                tmp = tmp.next;
            }
            return str;
        }

    }
}
