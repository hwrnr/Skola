using System;
namespace Stacks {
	internal class StackElementList<T> {
		public T data;
		public StackElementList<T> next;
		public StackElementList(T data, StackElementList<T> next) {
			this.data = data;
			this.next = next;
        }

		public StackElementList(T data){
			this.data = data;
			this.next = null;
		}

		public StackElementList(){
			this.next = null;
		}
    }
}
