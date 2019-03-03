using System;
namespace Queue {
	public class QueueArray<T> : Queue<T> {
		private uint capacity;
		private T[] array;
		private uint size = 0;
		private int index = -1;

        public QueueArray(uint capacity) {
			this.capacity = capacity;
			array = new T[capacity];
        }

		public override T First{
			get{
				if (size != 0) return array[(index + 1) % capacity];
				throw new Exception("Queue is empty");
			}
		}

		public override int Size {
			get{
				return (int)size;
			}
		}

		public override void Clear() {
			index = -1;
			size = 0;
		}

		public override bool Denqueue() {
			if (size == 0) return false;
			++index;
			if (index == capacity){
				index = -1;
			}
			if (--size == 0) this.Clear();
			return true;
		}

		public override bool Enqueue(T data) {
			if (size == capacity) return false;
			array[(index + (++size)) % capacity] = data;
			return true;
		}

		public override bool IsEmpty() {
			return size == 0;
		}

		public override string ToString() {
			string tmp = "";

			for (int i = 1; i < size; ++i){
				tmp += array[(index + i) % capacity] + ", ";
			}
			if (size != 0){
				tmp += array[(index + size) % capacity];
			}

			return tmp;
		}
	}
}
