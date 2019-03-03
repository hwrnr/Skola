using System;

namespace Queue {
    class MainClass {
        public static void Main(string[] args) {
			Queue<int> queue = new QueueArray<int>(5);

			queue.Enqueue(2);
			queue.Enqueue(3);
            Console.WriteLine(queue.First);
			queue.Denqueue();
            Console.WriteLine(queue.First);

			queue.Clear();
			if (queue.IsEmpty()){
				queue.Enqueue(31);
			}

            Console.WriteLine(queue.Size);

			queue.Enqueue(123);
            Console.WriteLine(queue);

			queue.Denqueue();
            Console.WriteLine(queue);
			queue.Denqueue();
			try{
				Console.WriteLine(queue.First);
			}
			catch(Exception){
				Console.WriteLine("Queue is empty");
			}
            Console.WriteLine(queue);

			queue.Enqueue(12);
			queue.Enqueue(12);
			queue.Enqueue(12);
			queue.Enqueue(12);
			queue.Enqueue(12);
            queue.Enqueue(12);
			queue.Denqueue();
			queue.Denqueue();
			queue.Denqueue();
			queue.Enqueue(13);
			queue.Enqueue(13);
			queue.Denqueue();
            Console.WriteLine(queue);
        }
    }
}
