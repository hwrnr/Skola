using System;
namespace SortedList1 {
    class ListNode {
        private int data;
        public ListNode next;

        public int Data {
            get { return data; }
            set { data = value; }
        }

        public ListNode() {
            next = null;
        }

        public ListNode(int data) {
            next = null;
            this.data = data;
        }

        public ListNode(int data, ListNode next) {
            this.data = data;
            this.next = next;
        }

        public override string ToString() {
            return data.ToString();
        }
    }
}
