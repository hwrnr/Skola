using System;
namespace Queue {
	public class QueueList<T> : Queue<T> {

		private int size;

		private QueueNode<T> head;
		private QueueNode<T> tail;

        public QueueList() {
			head = null;
			tail = null;
        }
        
		public override int Size => size;

		public override T First {
			get{
				if (head != null){
					return head.data;
				}
				throw new Exception("Queue is empty");
			}
		}
        
		public override void Clear() {
			head = null;
			tail = null;
			size = 0;
		}

		public override bool Denqueue() {
			if (head != null){
				head = head.next;
				--size;
			}
			else {
				return false;
			}
			return true;
		}

		public override bool Enqueue(T data) {
			QueueNode<T> tmp = tail;
			tail = new QueueNode<T>(data);
			if (tmp != null) {
				tmp.next = tail;
			}
			else{
				head = tail;
			}
			++size;         
			return true;
		}

		public override bool IsEmpty() {
			return size == 0;
		}

		public override string ToString() {
			String str = "";
			if (size == 0) return str;
			QueueNode<T> tmp = head;
			while (tmp.next != null){
				str += tmp.data + ", ";
				tmp = tmp.next;
			}
			if (tmp != null){
				str += tmp.data;
			}
			return str;
		}
	}
}
