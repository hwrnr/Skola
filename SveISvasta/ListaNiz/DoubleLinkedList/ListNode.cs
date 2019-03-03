using System;
namespace DoubleLinkedList {
    internal class ListNode<T> {
		public T data;
		public ListNode<T> prev;
		public ListNode<T> next;

        public ListNode(T data, ListNode<T> next = null, ListNode<T> prev = null) {
			this.data = data;
			this.prev = prev;
			this.next = next;
        }

		public override string ToString() {
            return data.ToString();
        }
    }
}
