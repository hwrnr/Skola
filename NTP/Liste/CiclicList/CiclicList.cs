using System;
namespace CiclicListNameSpace
{
    public class CiclicList<T>
    {
        ListNode<T> HEAD;
        uint length;

        public CiclicList()
        {
            length = 0;
            HEAD = null;
        }

        public uint Length
        {
            get
            {
                return length;
            }
        }

        public bool isEmpty()
        {
            return length == 0;
        }

        public void Clear()
        {
            HEAD = null;
            length = 0;
        }

        public bool Add(T data, uint index)
        {
            if (index > length) return false;
            if (length == 0)
            {
                HEAD = new ListNode<T>(data);
                HEAD.next = HEAD;
            }
            else
            {
                ListNode<T> tmp = HEAD;
                uint i = 0;
                if (index == 0)
                {
                    HEAD = new ListNode<T>(data, HEAD);
                    while (i != length - 1)
                    {
                        ++i;
                        tmp = tmp.next;
                    }
                    tmp.next = HEAD;
                }
                else
                {
                    while (i != index - 1)
                    {
                        ++i;
                        tmp = tmp.next;
                    }
                    tmp.next = new ListNode<T>(data, tmp.next);
                }
            }
            ++length;
            return true;
        }

        public bool AddLast(T data)
        {
            return this.Add(data, length);
        }

        public bool AddFirst(T data)
        {
            return this.Add(data, 0);
        }

        public bool Push(T data)
        {
            return this.AddLast(data);
        }

        public bool Delete(uint index)
        {
            if (index > length - 1) return false;
            if (length == 1)
            {
                HEAD = null;
                length = 0;
                return true;
            }
            ListNode<T> tmp = HEAD;
            uint i = 0;
            if (index == 0)
            {
                HEAD = HEAD.next;
                --length;
                while (i != length - 1)
                {
                    ++i;
                    tmp = tmp.next;
                }
                tmp.next = HEAD;
                return true;
            }
            while (i < index - 1)
            {
                ++i;
                tmp = tmp.next;
            }
            tmp.next = tmp.next.next;
            --length;
            return true;
        }

        public bool DeleteFirst()
        {
            return this.Delete(0);
        }

        public bool DeleteLast()
        {
            return this.Delete(length - 1);
        }

        public T getByIndex(uint index)
        {
            if (index > length - 1) throw new System.IndexOutOfRangeException();
            ListNode<T> tmp = HEAD;
            uint i = 0;
            while (i < index)
            {
                tmp = tmp.next;
                ++i;
            }
            return tmp.Data;
        }

        public T Pop()
        {
            if (length == 0) throw new System.InvalidOperationException("Can't pop from empty list");
            try
            {
                T tmp = this.getByIndex(length - 1);
                this.Delete(length - 1);
                return tmp;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Add(CiclicList<T> other)
        {
            if (other == null) return false;
            ListNode<T> tmp = HEAD;
            if (this.length == 0)
            {
                HEAD = other.HEAD;
                this.length = other.length;
                return true;
            }
            uint i = 0;
            while (i < length - 1)
            {
                ++i;
                tmp = tmp.next;
            }
            tmp.next = other.HEAD;
            length = length + other.length;
            return true;
        }

        public bool Merge(CiclicList<T> ListToMerge)
        {
            return this.Add(ListToMerge);
        }
        /*
        public void Reverse()
        { //ovo je sve samo ne optimizovano
            CiclicList<T> newList = new CiclicList<T>();
            try
            {
                while (true)
                    newList.Push(this.Pop());
            }
            catch (System.InvalidOperationException)
            {

            }
            this.HEAD = newList.HEAD;
            this.length = newList.length;
        }*/
        /*
        public bool Swap(uint index1, uint index2)
        {
            if (index1 == index2) return true; //uradili smo swap, ali je ostalo sve kako je bilo
            if (index1 > length - 1 || index2 > length - 1) return false;
            T tmp1 = this.getByIndex(index1);
            T tmp2 = this.getByIndex(index2);
            this.Delete(index1);
            this.Add(tmp2, index1);
            this.Delete(index2);
            this.Add(tmp1, index2);
            return true;
        }*/

        public override string ToString()
        {
            string str = String.Empty;
            ListNode<T> tmp = HEAD;
            for (uint i = 0; i < length; ++i)
            {
                str += tmp + " ";
                tmp = tmp.next;
            }
            return str;
        }

    }
}
