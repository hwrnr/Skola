using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public int Length()
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                Node temp = head;
                int b;
                b = 1;
                while (temp.Next != null)
                {
                    b++;
                    temp = temp.Next;
                }
                return b;
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public void AddPocetak(int d)
        {
            Node new_node = new Node(d);
            new_node.Next = this.head;
            this.head = new_node;
        }

        public int Read(int index)
        {
            Node temp = head;
            for (int i = 0; i < index; ++i)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        public int Find(int elementToFind)
        {
            int i = 0;
            Node temp = head;
            while (temp != null)
            {
				if (temp.Data == elementToFind) break;
                ++i;
                temp = temp.Next;
            }
            if (i == Length())
            {
                return -1;
            }
            return i;
        }

		public void DeleteFirst(){
			if (head != null)
			    head = head.Next;
		}

		public void DeleteLast(){
			Node tmp = head;
			if (head == null) return;
			else if (head.Next == null) head = null;
			while (tmp.Next.Next != null) tmp = tmp.Next;
			tmp.Next = null;
		}

		public bool Delete(int index){
			if (index > Length() - 1 || index < 0) return false;
            if (Length() == 1)
            {
                head = null;
                return true;
            }
            Node tmp = head;
            uint i = 0;
            if (index == 0)
            {
                head = head.Next;
                return true;
            }
            while (i < index - 1)
            {
                ++i;
                tmp = tmp.Next;
            }
            tmp.Next = tmp.Next.Next;
            return true;
		}

		public override string ToString()
        {
            string str = String.Empty;
            Node tmp = head;
            for (; tmp != null; tmp = tmp.Next)
            {
                str += tmp + " ";
            }
            return str;
        }
        
    }
}
