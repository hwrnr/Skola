using System;
namespace CiclicListNameSpace
{
    class ListNode<T>
    {
        private T data;
        public ListNode<T> next;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public ListNode()
        {
            next = null;
        }

        public ListNode(T data)
        {
            next = null;
            this.data = data;
        }

        public ListNode(T data, ListNode<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
