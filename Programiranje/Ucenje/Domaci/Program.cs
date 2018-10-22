using System;

namespace Domaci{
  class Program{
    static void Main(string[] args){
      Console.WriteLine("Upisite broj redova i kolona");
      int n = int.Parse(Console.ReadLine());
      int m = int.Parse(Console.ReadLine());
      int[,] matrica = new int [n, m];
      for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j)
        {
          matrica[i,j] = int.Parse(Console.ReadLine());
        }
      }
      Console.WriteLine("Koje dve kolone zelite da zamenite?");
      int x = int.Parse(Console.ReadLine()) + 1;
      int y = int.Parse(Console.ReadLine()) + 1;
      for (int i = 0; i < m; ++i){
        int tmp = matrica[i,x];
        matrica[i,x] = matrica[i,y];
        matrica[i,y] = tmp;
      }
      for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j)
        {
          Console.Write(matrica[i,j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
