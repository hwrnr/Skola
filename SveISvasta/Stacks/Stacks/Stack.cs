using System;
namespace Stacks {
    public abstract class Stack<T> {
      
		public abstract bool Push(T data);
		public abstract bool Pop();
		public abstract T Top { get; }
		public abstract bool IsEmpty();
		public abstract void Clear();
		public abstract int Size { get; }

        
    }
}
