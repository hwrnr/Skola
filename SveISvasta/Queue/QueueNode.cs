using System;
namespace Queue {
    public class QueueNode<T> {
		public T data;
		public QueueNode<T> next;
        public QueueNode(T data, QueueNode<T> next = null) {
			this.data = data;
			this.next = next;
        }
    }
}
