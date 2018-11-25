using System;

namespace ListaNiz1
{
  class Program{
    static void Main(string[] args){
      ListaNiz<int> list = new ListaNiz<int>();
      // ListaNiz<double> list = new ListaNiz<double>();
      list.Add(2, 0);
      try {
        Console.WriteLine(list.Pop());
      }
      catch (System.InvalidOperationException){
        Console.WriteLine("Doslo je do izuzetka jer je pokusan Pop() iz prazne liste");
      }
      try {
        Console.WriteLine(list.Pop());
      }
      catch (System.InvalidOperationException){
        Console.WriteLine("Doslo je do izuzetka jer je pokusan Pop() iz prazne liste");
      }
      Console.WriteLine(list);
      list.Push(2);
      list.Push(1);
      Console.WriteLine(list + Environment.NewLine + "Krecu list.Add");
      if (!list.Add(22, 1)){
        Console.WriteLine("Greska pri ubacivanju");
      }
      if (!list.Add(22, 2)){
        Console.WriteLine("Greska pri ubacivanju");
      }
      Console.WriteLine(list);
      Console.WriteLine(Environment.NewLine);
      if (!list.Add(22, 111)){
        Console.WriteLine("Greska pri ubacivanju");
      }
      if (!list.Delete(0)){
        Console.WriteLine("Greska pri izbacivanju");
      }
      if (!list.Delete(120)){
        Console.WriteLine("Greska pri izbacivanju");
      }
      int[] niz = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7};
      for(int i = 0; i < niz.Length; ++i){
        list.Push(niz[i]);
      }
      Console.WriteLine(list);
      if (!list.isEmpty()){
        list.Clear();
      }
      Console.WriteLine("Posle brisanja: " + list);

      Console.WriteLine("String");
      ListaNiz<string> liststring = new ListaNiz<string>();
      liststring.Add("test", 0);
      try {
        Console.WriteLine(liststring.Pop());
      }
      catch (System.InvalidOperationException){
        Console.WriteLine("Doslo je do izuzetka jer je pokusan Pop() iz prazne liststringe");
      }
      try {
        Console.WriteLine(liststring.Pop());
      }
      catch (System.InvalidOperationException){
        Console.WriteLine("Doslo je do izuzetka jer je pokusan Pop() iz prazne liststringe");
      }
      Console.WriteLine(liststring);
      liststring.Push("string 2");
      liststring.Push("string 1");
      Console.WriteLine(liststring + Environment.NewLine + "Krecu liststring.Add");
      if (!liststring.Add("test", 1)){
        Console.WriteLine("Greska pri ubacivanju");
      }
      if (!liststring.Add("test", 2)){
        Console.WriteLine("Greska pri ubacivanju");
      }
      Console.WriteLine(liststring);
      Console.WriteLine(Environment.NewLine);
      if (!liststring.Add("test", 111)){
        Console.WriteLine("Greska pri ubacivanju");
      }
      if (!liststring.Delete(0)){
        Console.WriteLine("Greska pri izbacivanju");
      }
      if (!liststring.Delete(120)){
        Console.WriteLine("Greska pri izbacivanju");
      }
      
      string[] nizstring = new string[] {"testing", "bla bla", "1234", "jos malo", "treba", "mi", "bar", "8", "komada"};
      for(int i = 0; i < nizstring.Length; ++i){
        liststring.Push(nizstring[i]);
      }
      Console.WriteLine(liststring);
      if (!liststring.isEmpty()){
        liststring.Clear();
      }
      Console.WriteLine("Posle brisanja: " + liststring);


    }
  }
}
