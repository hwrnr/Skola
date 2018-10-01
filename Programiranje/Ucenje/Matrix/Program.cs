using System;

namespace Matrix{
  class Program{
    static void Main(string[] args){
      int x, y;
      Console.WriteLine("Upisite velicine matrice");
      x = int.Parse(Console.ReadLine());
      y = int.Parse(Console.ReadLine());
      int[,] matrix = new int[x, y];
      for (int i = 0; i < x; ++i) {
        for (int j = 0; j < y ; ++j) {
          Console.Write("Matrix[{0}, {1}] = ", i, j);
          matrix[i, j] = int.Parse(Console.ReadLine());
        }
      }
      for (int i = 0; i < x; ++i) {
        for (int j = 0; j < y; ++j) {
          Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
      }
    }
  }
}
