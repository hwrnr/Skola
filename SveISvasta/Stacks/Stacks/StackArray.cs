using System;
namespace Stacks {
	public class StackArray<T> : Stack<T> {
		T[] niz;
		int top;

		public StackArray(uint capacity) {
			niz = new T[capacity];
			top = -1;
		}

		public override bool Push(T data) {
			if (top + 1 >= niz.Length) {
				return false;
			}
			top += 1;
			niz[top] = data;
			return true;
		}

		public override bool Pop() {
			if (top == -1) return false;
			top -= 1;
			return true;
		}

		public override T Top {
			get {
				try {
					return niz[top];
				}
				catch (IndexOutOfRangeException) {
					throw new IndexOutOfRangeException("Can't top from empty stack");
				}
			}
		}

		public override void Clear() {
			top = -1;
		}
        
		public override int Size {
			get {
				return top + 1;
			}
		}

		public override bool IsEmpty() {
			return top == -1;
		}

		public override string ToString() {

			String tmp = "";

			for (int i = 0; i < top + 1; ++i) {
				tmp += niz[i];
				if (i != top){
					tmp += ", ";
				}
			}

			return tmp;
		}
	}
}
