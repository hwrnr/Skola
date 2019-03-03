using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
    class LinkedList {
        public Node head;

        public LinkedList() {
            head = null;
        }

		public void Add(int data) {

            Node node = new IntNode(data);
            Node temp = head;

            if (head == null) // duzina je 0
            {
                head = new Node(data);
                return;
            }
            else if (head.next == null) {
                if (node.data > head.Data) {
                    head.next = node;
                }
                else {
                    node.Next = head;
                    head = node;
                }
            }

            {
                while (data > temp.Next.Data) {
                    if (temp.Next.Next != null)
                        temp = temp.Next;
                    else
                        break;
                }
                node.Next = temp.Next;
                temp.Next = node;
                return;
            }
        }

        public bool IsEmpty() {
            if (head == null) {
                return true;
            }
            else {
                return false;
            }
        }
        public void Clear() {
            head = null;
        }
        public int Length() {
            if (head == null) {
                throw new Exception("Lista je prazna.");
            }
            int size = 1;
            for (Node n = head; n.sledeci != null; n = n.sledeci) {
                size++;

            }
            return size;
        }
        string str = "";
        public override string ToString() {
            str = "Pocetak Ispisa: \n";
            for (Node i = head;/* i.sledeci != null*/ ; i = i.sledeci) {
                str = str + "|" + i.vrednost + "|" + "\n";
                if (i.sledeci == null) {
                    break;
                }
            }
            return str;
            //return base.ToString();
        }
        public void DeletePrvi() {
            head = head.sledeci;
        }
        public void DeletePosledji() {
            Node n = this.head;
            for (int i = 0; i < Length() - 2; i++) {
                n = n.sledeci;
            }
            n.sledeci = null;
        }
        public void Delete(int index) {
            Node n = this.head;
            for (int i = 0; i < index - 1; i++) {
                n = n.sledeci;
            }
            n.sledeci = n.sledeci.sledeci;
        }
        public int Read(int index) {
            int broj = 0;
            Node n = this.head;
            for (int i = 0; i < index - 1; i++) {
                n = n.sledeci;
            }
            broj = n.vrednost;
            return broj;
        }

        public int Find(int el) {
            Node n = this.head;
            for (int i = 0; i < Length(); i++) {
                if (n.vrednost == el) {
                    return i;
                }
                n = n.sledeci;
            }
            return -1;
        }
    }
}
