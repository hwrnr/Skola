using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Node
    {
        private int data;
        private Node next;

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node Next
        {
            get => next;
            set => next = value;
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }

		public override string ToString()
		{
			return data.ToString();         
		}

	}
}
