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

        public void AddPocetak(LinkedList List, int d)
        {
            Node new_node = new Node(d);
            new_node.Next = List.head;
            List.head = new_node;
        }

        int Read(int index)
        {
            Node temp = head;
            for (int i = 0; i < index; ++i)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        int Find(int index)
        {
            int i = 0;
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data == index) break;
                ++i;
                temp = temp.Next;
            }
            if (i == Length())
            {
                return -1;
            }
            return i;
        }
        
    }
}
