using System;
namespace Queue {
    public abstract class Queue<T> {
        public Queue() {
        }

		public abstract bool IsEmpty();
		public abstract bool Enqueue(T data);
		public abstract bool Denqueue();
		public abstract void Clear();
		public abstract T First { get; }
		public abstract int Size { get; }
    }
}
