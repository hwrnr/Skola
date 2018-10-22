using System;

namespace Cas {
  class Program {
    static void Main(string[] args)  {
      int[] niz = new int []{1, 2, 3, 4, 5};
      for (int i = 0; i < niz.Length; ++i){
        Console.WriteLine(niz[i]);
      }
      RotirajNiz(niz, -2);
      Console.WriteLine("\n\n");
      for (int i = 0; i < niz.Length; ++i){
        Console.WriteLine(niz[i]);
      }
      //dovde sam uradio na casu
      int[] niz1 = new int []{1, 2, 3, 4};
      Console.WriteLine("\n\n\nSaberi: ");
      int[] niz2 = SaberiNizove(niz, niz1);
      for (int i = 0; i < niz2.Length; ++i){
        Console.WriteLine(niz2[i]);
      } 
      Console.WriteLine("\n\n\nDodaj: ");
      int[] niz4 = new int []{1, 2, 3, 4, 5};
      int[] niz3 = DodajNizove(niz, niz4);
      for (int i = 0; i < niz3.Length; ++i){
        Console.WriteLine(niz3[i]);
      }
    }
    /// <summary>
    /// Rotira niz udesno za odrenjen broj koraka
    /// </summary>
    /// <param name="niz"> niz koji se rotira </param>
    /// <param name="brojRotacija"> Za koliko mesta ce se pomeriti svaki element </param>
    /// <returns> Nista </returns>
    static void RotirajNiz(int[] niz, int brojRotacija){
      if (niz == null) return;
      int[] tmp = new int[niz.Length];
      int i;
      int pomeraj = niz.Length - brojRotacija%niz.Length;
      for (i = 0; i < niz.Length; ++i){
        tmp[i] = niz[ (pomeraj + i ) % niz.Length]; // za dugacke nizove koji trebaju da se okrenu mnogo puta 
      }
      for (i = 0; i < niz.Length; ++i){
        // niz[i] = tmp[niz.Length - 1 - i];
        niz[i] = tmp[i];
      }
    }

    /// <summary>
    /// Sabira clanove niza redom
    /// </summary>
    /// <param name="niz1"> prvi niz koji se sabira</param>
    /// <param name="niz2"> drugi niz koji se sabira</param>
    /// <returns> Zbir nizova</returns>
    static int[] SaberiNizove(int[] niz1, int[] niz2){
      if (niz1 == null || niz2 == null) return null;
      int[] tmp = new int[Math.Max(niz1.Length, niz2.Length)];
      int i;
      for (i = 0; i < Math.Min(niz1.Length, niz2.Length); ++i){
        tmp[i] = niz1[i] + niz2[i];
      }
      int[] tmp1;
      if(niz1.Length > niz2.Length)  tmp1 = niz1;
      else  tmp1 = niz2;
      for (; i < tmp1.Length; ++i){
        tmp[i] = tmp1[i];
      }
      return tmp;
    }

    /// <summary>
    /// Dodaje niz na drugi 
    /// </summary>
    /// <param name="niz1"> niz na koji se dodaje</param>
    /// <param name="niz2"> niz koji se dodaje</param>
    /// <returns> Spoejene nizove</returns>
    static int[] DodajNizove(int[] niz1, int[] niz2){
      if (niz1 == null) return niz2;
      if (niz2 == null) return niz1;
      int[] tmp = new int[niz1.Length + niz2.Length];
      int i;
      for (i = 0; i < niz1.Length; ++i){
        tmp[i] = niz1[i];
      }
      for (i = niz1.Length; i < niz2.Length + niz1.Length; ++i){
        tmp[i] = niz2[i - niz1.Length];
      }
      return tmp;
    } 
  }
}
