using System;
namespace Stacks {
	public class StackList<T> : Stack<T>{
		StackElementList<T> top;
		int len;

        public StackList() {
			top = null;
			len = 0;
        }
        
		public override bool Push(T data){
			top = new StackElementList<T>(data, top);
			++len;
			return true;
		}

		public override bool Pop() {
			try {
				top = top.next;
				--len;
			}
			catch (NullReferenceException){
				return false;
			}
			return true;
		}

		public override T Top{
			get {
				return top.data;
			}
		}

		public override bool IsEmpty(){
			return len == 0;
		}

		public override int Size{
			get {
				return len;
			}
		}

		public override void Clear(){
			top = null;
			len = 0;
		}

		public override string ToString() {
			string[] niz = new string[len];
			string tmp = "";
			StackElementList<T> podatak = top;
			for (int i = 0; i < len; ++i){
				niz[len - i - 1] = podatak.data.ToString();
				podatak = podatak.next;
			}

			for (int i = 0; i < len; ++i) {
                tmp += niz[i];
                if (i != len - 1) {
                    tmp += ", ";
                }
            }

			return tmp;
		}
	}
}
