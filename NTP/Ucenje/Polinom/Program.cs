using System;

namespace Polinomi {
  class Program {
    static void Main(string[] args) {
      ClanPolinoma prvi = new ClanPolinoma(3, 2);
      ClanPolinoma drugi = new ClanPolinoma(1, 2);
      ClanPolinoma treci = drugi.Kopija();
      Console.WriteLine(prvi);
      Console.WriteLine(drugi);
      Console.WriteLine(treci);

      Console.WriteLine(Environment.NewLine);

      Console.WriteLine(prvi.VratiSuprotan());
      treci.Koeficijent = 4;
      Console.WriteLine(drugi.VratiSuprotan());
      Console.WriteLine(treci.VratiSuprotan());

      if (prvi.Dodaj(drugi))  Console.WriteLine(prvi);
      else Console.WriteLine("Greska");
      
      Console.WriteLine("Polinom: " + Environment.NewLine);

      ClanPolinoma[] clanovi1 = new ClanPolinoma[2];
      drugi.Stepen = 3;
      clanovi1[0] = prvi;
      clanovi1[1] = drugi;

      treci.Stepen = 4;
      ClanPolinoma[] clanovi2 = new ClanPolinoma[2];
      clanovi2[0] = drugi.Kopija();
      clanovi2[1] = treci;

      
      Console.WriteLine(treci);
      Console.WriteLine(Environment.NewLine);

      Polinom p1 = new Polinom(clanovi1);
      Polinom p2 = new Polinom(clanovi2);

      Console.Write("p1: ");
      Console.WriteLine(p1);

      Console.Write("p2: ");
      Console.WriteLine(p2);


      Console.WriteLine("Dodaj p1 i treci");
      p1.Dodaj(treci);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Oduzmi p1 i treci");
      p1.Oduzmi(treci);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Dodaj p1 i p2");
      p1.Dodaj(p2);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Oduzmi p1 i p2");
      p1.Oduzmi(p2);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Pomnozi p1 i 3");
      p1.Pomnozi(3);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Podeli p1 i 3");
      p1.Podeli(3);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Pomnozi p1 i treci");
      p1.Pomnozi(treci);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Podeli p1 i treci");
      p1.Podeli(treci);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine("Pomnozi p1 i p2");
      p1.Pomnozi(p2);
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      // Console.WriteLine("Podeli p1 i p2");
      // p1.Podeli(p2);
      // Console.WriteLine(p1);
      // Console.WriteLine(p2);

      Console.WriteLine("Izracunaj p1 za x=3");
      Console.WriteLine(p1.Izracunaj(3));
    }
  }
}
