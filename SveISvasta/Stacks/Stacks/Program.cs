using System;
using Stacks;

namespace Main {
	class MainClass {

		public static bool SwapTop<T>(Stack<T> stack){
			if (stack.Size < 2) return false;
			T first = stack.Top;
			stack.Pop();
			T second = stack.Top;
			stack.Pop();
			stack.Push(first);
			stack.Push(second);
			return true;
		}

		public static bool IspisiStekObrnuto<T>(Stack<T> stack){
			//posto mi vec ToString() ispisuje Top na kraju, sad ce ga ispisati prvog. Ovo nema smisla, jer ne mogu da procitam nista sem TOP na steku, pa moram da obrisem ceo stek i ponovo ga napravim.
			StackArray<T> tmp = new StackArray<T>((uint) stack.Size);
			int len = stack.Size;
			for (int i = 0; i < len; ++i){
				tmp.Push(stack.Top);
				stack.Pop();
			}
            Console.WriteLine(tmp);
			for (int i = 0; i < len; ++i) {
                stack.Push(tmp.Top);
                tmp.Pop();
            }
			return true;
		}

		public static bool Rotate<T>(Stack<T> stack, int n) {
			if (n > stack.Size) return false;

			T[] tmp = new T[n];

			for (int i = 0; i < n; ++i) {
				tmp[i] = stack.Top;
				stack.Pop();
			}
			stack.Push(tmp[0]);
			for (int i = n - 1; i > 0; --i){
				stack.Push(tmp[i]);
			}

			return true;
		}
        
		public static double ProveriMatematickiIzrazIliStaVec(string test){
			StackList<string> stack = new StackList<string>();
			int i = 0;
			try {
				for (i = 0; i < test.Length; ++i) {
					if (test[i] == ')') {
						double drugi = Double.Parse(stack.Top);
						stack.Pop();
						char operacija = stack.Top[0];
						stack.Pop();
						double prvi = Double.Parse(stack.Top);
						stack.Pop();
                        stack.Pop();
						stack.Push(izracunaj(prvi, drugi, operacija).ToString());
					}
					else{
						stack.Push("" + test[i]);
					}
				}
			}
			catch (Exception e) {throw e; }
            return Double.Parse(stack.Top);
		}

		public static double izracunaj(double prvi, double drugi, char operacija){
			switch(operacija){
				case '+': return prvi + drugi;
				case '-': return prvi - drugi;
				case '*': return prvi * drugi;
				case '/': return prvi / drugi;
			}
			return 0.0;
		}

        public static void Main(string[] args) {
            Console.WriteLine("Hello World!");
			Stacks.StackList<int> stack = new StackList<int>();
			stack.Push(12);
			stack.Push(13);
			stack.Push(14);

            Console.WriteLine(stack + Environment.NewLine);

			Console.WriteLine(stack.Top);
			stack.Pop();
            if (!stack.Pop()) Console.WriteLine("Prazna je lista bila");

			Stacks.StackArray<int> stackArray = new StackArray<int>(2);

			stackArray.Push(12);
			stackArray.Push(13);
			stackArray.Push(14); //StackArray<T> nece automatski promeniti velicinu

            Console.WriteLine(stackArray + Environment.NewLine);

			Console.WriteLine(stackArray.Top);

			Console.WriteLine("#Swap top");
			SwapTop(stackArray);
            Console.WriteLine(stackArray);

			stack.Push(14);
			stack.Push(15);
            stack.Push(16);

            Console.Write("#ispisi obrnuto ");
			IspisiStekObrnuto(stack);
            Console.WriteLine("#normalan ispis " + stack);

			stackArray.Clear();

			stack.Clear();

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			stack.Push(5);
            stack.Push(6);

			Rotate(stack, 3);
            Console.WriteLine(stack);

			try {
				Console.WriteLine(stackArray.Top);
			}
			catch (Exception){
				Console.WriteLine("List was empty");
			}

			Console.WriteLine(ProveriMatematickiIzrazIliStaVec("(3*(3+3))"));

            Console.WriteLine(ProveriMatematickiIzrazIliStaVec("(3+(4*3))"));
        }
    }
}
