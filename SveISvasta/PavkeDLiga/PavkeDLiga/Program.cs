using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLiga
{
    class Program
    {
        public static void GenerisiKola1(Tim[] timovi) // Generise prvu polovinu svih kola u ligi
        {
            Utakmica[] utakmice = new Utakmica[100];
            int brojUtakmica = 0;
            for (int runda = 0; runda < timovi.Length - 1; runda++)
            {
                Console.WriteLine((runda + 1) + ". kolo : " + Environment.NewLine);
                for (int utakmica = 0; utakmica < timovi.Length / 2; utakmica++)
                {
                    if (utakmica % 4 == 0)
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(runda + utakmica) % (timovi.Length)], timovi[(timovi.Length - utakmica + runda + 4) % (timovi.Length)]);
                    }
                    else
                    { 
                        utakmice[brojUtakmica] = new Utakmica(timovi[(runda + utakmica) % (timovi.Length)], timovi[(timovi.Length - utakmica + runda) % (timovi.Length)]);
                    }
                    Console.WriteLine(utakmice[brojUtakmica].stringUtakmica());
                    brojUtakmica++;
                }
                Console.WriteLine(Environment.NewLine + Environment.NewLine);
            }
        }

        public static void GenerisiKola2(Tim[] timovi) // Generise drugu polovinu svih kola u ligi
        {
            Utakmica[] utakmice = new Utakmica[100];
            int brojUtakmica = 0;
            for (int runda = 0; runda < timovi.Length - 1; runda++)
            {
                Console.WriteLine((runda + 8) + ". kolo : " + Environment.NewLine);
                for (int utakmica = 0; utakmica < timovi.Length / 2; utakmica++)
                {
                    if (utakmica % 4 == 0)
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(timovi.Length - utakmica + runda + 4) % (timovi.Length)], timovi[(runda + utakmica) % (timovi.Length)]);
                    }
                    else
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(timovi.Length - utakmica + runda) % (timovi.Length)], timovi[(runda + utakmica) % (timovi.Length)]);
                    }
                    Console.WriteLine(utakmice[brojUtakmica].stringUtakmica());
                    brojUtakmica++;
                }
                Console.WriteLine(Environment.NewLine + Environment.NewLine);
            }
        }

        public static void GenerisiKola(Tim[] timovi) // Generise sva kola u ligi
        {
            GenerisiKola1(timovi);
            GenerisiKola2(timovi);
        }

        public static void GenerisiKoloRezultat(Tim[] timovi, int kolo) // Trazi od korisnika da za svaku utakmicu u datom kolu unese rezultat i dati rezultat belezi u klasama timova
        {
            Utakmica[] utakmice = new Utakmica[100];
            int brojUtakmica = 0;
            int domacinGolovi, gostGolovi;
            int runda = kolo - 1;
                Console.WriteLine((runda + 1) + ". kolo : " + Environment.NewLine);
                for (int utakmica = 0; utakmica < timovi.Length / 2; utakmica++)
                {
                    if (utakmica % 4 == 0)
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(runda + utakmica) % (timovi.Length)], timovi[(timovi.Length - utakmica + runda + 4) % (timovi.Length)]);
                    }
                    else
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(runda + utakmica) % (timovi.Length)], timovi[(timovi.Length - utakmica + runda) % (timovi.Length)]);
                    }
                    Console.WriteLine(utakmice[brojUtakmica].stringUtakmica() + Environment.NewLine + Environment.NewLine);
                    Console.WriteLine("Unesite broj golova domaceg tima : ");
                    domacinGolovi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Unesite broj golova gostujuceg tima : ");
                    gostGolovi = Convert.ToInt32(Console.ReadLine());

                    if (utakmica % 4 == 0)
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(runda + utakmica) % (timovi.Length)], timovi[(timovi.Length - utakmica + runda + 4) % (timovi.Length)], domacinGolovi, gostGolovi);
                    }
                    else
                    {
                        utakmice[brojUtakmica] = new Utakmica(timovi[(runda + utakmica) % (timovi.Length)], timovi[(timovi.Length - utakmica + runda) % (timovi.Length)], domacinGolovi, gostGolovi);
                    }
                brojUtakmica++;
                Console.WriteLine(Environment.NewLine + Environment.NewLine);
                }
            Console.WriteLine(kolo + ". kolo : " + Environment.NewLine);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(utakmice[i]);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < timovi.Length; i++)
            {
                if(timovi[i].TrenutniDati > timovi[i].TrenutniPrimljeni)
                {
                    timovi[i].Bodovi += 3;
                    timovi[i].Pobede++;
                }
                else if (timovi[i].TrenutniDati == timovi[i].TrenutniPrimljeni)
                {
                    timovi[i].Bodovi++;
                    timovi[i].Neresene++;
                }
                else
                {
                    timovi[i].Bodovi = timovi[i].Bodovi;
                    timovi[i].Porazi++;
                }
            }

        }

        public static void SortBodovi(Tim[] timovi) // Sortira timove na osnovu osvojenih bodova
        {
            Tim temp = timovi[0];
            for (int i = 0; i < timovi.Length; i++)
            {
                for (int j = 0; j < (timovi.Length - 1); j++)
                {
                    if(timovi[j].Bodovi < timovi[j + 1].Bodovi)
                    {
                        temp = timovi[j + 1];
                        timovi[j + 1] = timovi[j];
                        timovi[j] = temp;
                    }
                }
            }
        }

        public static int Meni() // Ispisuje prvi meni koji se prikazuje na konzoli
        {
            Console.WriteLine("Meni : ");
            Console.WriteLine("1. Tabela");
            Console.WriteLine("2. Raspored kola");
            Console.WriteLine("3. Unesite rezultate prvog neodigranog kola");
            Console.WriteLine("4. Informacije o timovima");
            Console.WriteLine("5. Kraj Programa");
            Console.WriteLine("Unesite zeljenu opciju : ");
            char opcija = Convert.ToChar(Console.ReadLine());
            if (opcija == '1' || opcija == '2' || opcija == '3' || opcija == '4')
            {

                return Convert.ToInt32(opcija - '0');
            }
            else
            {
                Console.WriteLine("Niste uneli validnu opciju, unesite ponovo : " + Environment.NewLine);
                Meni();
                return 0;
            }

        }

        public static int SpisakTimova(Tim[] timovi) // Ispisuje sve timove na konzolu
        {
            Console.WriteLine("Informacije o timovima :");
            for (int i = 0; i < timovi.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + timovi[i].ImeTima);
            }
            Console.WriteLine("9. Povratak na meni");
            Console.WriteLine("Unesite zeljenu opciju : ");
            char opcija = Convert.ToChar(Console.ReadLine());
            if (opcija == '1' || opcija == '2' || opcija == '3' || opcija == '4' || opcija == '5' || opcija == '6' || opcija == '7' || opcija == '8' || opcija == '9')
            {
                return Convert.ToInt32(opcija - '0');
            }
            else
            {
                Console.WriteLine("Niste uneli validnu opciju, unesite ponovo : " + Environment.NewLine);
                SpisakTimova(timovi);
                return 0;
            }
        }

        static void Main(string[] args)
        {
			// Deklaracija i inicijalizacija svih igraca u ligi

			//test
			char[] test = new char[2];
            Console.WriteLine((int)test[0]);

			for (int i = 0; i < 9999999; ++i){
				Console.Write(char.MinValue);
			}

			Igrac igrac1 = new Igrac("Aleksa", "Zubic", Igrac.EnumPozicija.Golman);
            Igrac igrac2 = new Igrac("Nikola", "Sehovac", Igrac.EnumPozicija.Odbrana);
            Igrac igrac3 = new Igrac("Aleksa", "Simonovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac4 = new Igrac("Nikola", "Jaksic", Igrac.EnumPozicija.Vezni);
            Igrac igrac5 = new Igrac("Nikola", "Uvacek", Igrac.EnumPozicija.Napad);
            Igrac igrac6 = new Igrac("Stefan", "Janovic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci1 = new Igrac[] { igrac1, igrac2, igrac3, igrac4, igrac5, igrac6 };

            Igrac igrac7 = new Igrac("Nemanja", "Pandurica", Igrac.EnumPozicija.Golman);
            Igrac igrac8 = new Igrac("Borislav", "Tosic", Igrac.EnumPozicija.Odbrana);
            Igrac igrac9 = new Igrac("Alan", "Bojovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac10 = new Igrac("Bosko", "Vujanovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac11 = new Igrac("Ognjen", "Stjepanovic", Igrac.EnumPozicija.Napad);
            Igrac igrac12 = new Igrac("David", "Joksimovic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci2 = new Igrac[] { igrac7, igrac8, igrac9, igrac10, igrac11, igrac12 };

            Igrac igrac13 = new Igrac("Stefan", "Topalov", Igrac.EnumPozicija.Golman);
            Igrac igrac14 = new Igrac("Stefan", "Dragicevic", Igrac.EnumPozicija.Odbrana);
            Igrac igrac15 = new Igrac("Radivoje", "Tomasevic", Igrac.EnumPozicija.Vezni);
            Igrac igrac16 = new Igrac("Danilo", "Milovanovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac17 = new Igrac("Marko", "Kockar", Igrac.EnumPozicija.Napad);
            Igrac igrac18 = new Igrac("Djordje", "Vajagic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci3 = new Igrac[] { igrac13, igrac14, igrac15, igrac16, igrac17, igrac18 };

            Igrac igrac19 = new Igrac("Nikola", "Milojevic", Igrac.EnumPozicija.Golman);
            Igrac igrac20 = new Igrac("Dimitrije", "Svilakovic", Igrac.EnumPozicija.Odbrana);
            Igrac igrac21 = new Igrac("Veljko", "Jovancevic", Igrac.EnumPozicija.Vezni);
            Igrac igrac22 = new Igrac("Luka", "Ivanovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac23 = new Igrac("Rastko", "Acimov", Igrac.EnumPozicija.Napad);
            Igrac igrac24 = new Igrac("Jovan", "Jokic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci4 = new Igrac[] { igrac19, igrac20, igrac21, igrac22, igrac23, igrac24 };

            Igrac igrac25 = new Igrac("Marko", "Gavrilovic", Igrac.EnumPozicija.Golman);
            Igrac igrac26 = new Igrac("Luka", "Savkov", Igrac.EnumPozicija.Odbrana);
            Igrac igrac27 = new Igrac("Jovan", "Zivanovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac28 = new Igrac("Stefan", "Pekic", Igrac.EnumPozicija.Vezni);
            Igrac igrac29 = new Igrac("Marko", "Braovic", Igrac.EnumPozicija.Napad);
            Igrac igrac30 = new Igrac("Aleksa", "Djukic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci5 = new Igrac[] { igrac25, igrac26, igrac27, igrac28, igrac29, igrac30 };

            Igrac igrac31 = new Igrac("Stevan", "Misic", Igrac.EnumPozicija.Golman);
            Igrac igrac32 = new Igrac("Jovan", "Radulovic", Igrac.EnumPozicija.Odbrana);
            Igrac igrac33 = new Igrac("Ognjen", "Palackovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac34 = new Igrac("Vojin", "Minic", Igrac.EnumPozicija.Vezni);
            Igrac igrac35 = new Igrac("Milos", "Brkic", Igrac.EnumPozicija.Napad);
            Igrac igrac36 = new Igrac("Kristijan", "Bajic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci6 = new Igrac[] { igrac31, igrac32, igrac33, igrac34, igrac35, igrac36 };

            Igrac igrac37 = new Igrac("Luka", "Stavric", Igrac.EnumPozicija.Golman);
            Igrac igrac38 = new Igrac("Nikola", "Kozomoric", Igrac.EnumPozicija.Odbrana);
            Igrac igrac39 = new Igrac("Aleksandar", "Kalapati", Igrac.EnumPozicija.Vezni);
            Igrac igrac40 = new Igrac("Nemanja", "Stanic", Igrac.EnumPozicija.Vezni);
            Igrac igrac41 = new Igrac("Lazar", "Maricikic", Igrac.EnumPozicija.Napad);
            Igrac igrac42 = new Igrac("Dusan", "Janjetovic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci7 = new Igrac[] { igrac37, igrac38, igrac39, igrac40, igrac41, igrac42 };

            Igrac igrac43 = new Igrac("Dragan", "Bican", Igrac.EnumPozicija.Golman);
            Igrac igrac44 = new Igrac("Novica", "Nikolic", Igrac.EnumPozicija.Odbrana);
            Igrac igrac45 = new Igrac("David", "Salatic", Igrac.EnumPozicija.Vezni);
            Igrac igrac46 = new Igrac("Igor", "Radovanovic", Igrac.EnumPozicija.Vezni);
            Igrac igrac47 = new Igrac("Danilo", "Ursino", Igrac.EnumPozicija.Napad);
            Igrac igrac48 = new Igrac("Srdjan", "Alicic", Igrac.EnumPozicija.Napad);
            Igrac[] igraci8 = new Igrac[] { igrac43, igrac44, igrac45, igrac46, igrac47, igrac48 };

            // Deklaracija i inicijalizacija svih timova u ligi

            Tim sarani = new Tim("Sarani", igraci1);
            Tim bunker = new Tim("Bunker", igraci2);
            Tim tautorogija = new Tim("Tautorogija", igraci3);
            Tim brondby = new Tim("Brondby", igraci4);
            Tim vijetnam = new Tim("Vijetnam", igraci5);
            Tim prazanStan = new Tim("Prazan Stan", igraci6);
            Tim budisava = new Tim("Budisava", igraci7);
            Tim srpskiKojoti = new Tim("Srpski Kojoti", igraci8);

            Tim[] timovi = new Tim[] { sarani, bunker, tautorogija, brondby, vijetnam, prazanStan, budisava, srpskiKojoti };

            bool petlja = true; // Kako bismo znali kada treba da izadjemo iz petlje
            int brojac = 0; // Broji koliko kola je odigrano i onemogucava prekomeran broj kola
            while (petlja == true)
            {
                switch (Meni()) // Biramo opciju iz menija i imamo case-ove
                {
                    case 1: // Ispisivanje tabele
                        Console.WriteLine(Environment.NewLine + Environment.NewLine);
                        SortBodovi(timovi);
                        Console.WriteLine("IME TIMA         POB  NER  POR  DG   PG   GR   BOD");
                        Console.WriteLine("**************************************************");
                        for (int i = 0; i < timovi.Length; i++)
                        {
                            Console.WriteLine( (i + 1) + ". " + timovi[i].stringTabela());
                        }
                        Console.WriteLine(Environment.NewLine + Environment.NewLine);
                        break;
                    case 2: // Generisanje rasporeda kola
                        Console.WriteLine(Environment.NewLine + "Raspored kola : " + Environment.NewLine + Environment.NewLine);
                        GenerisiKola(timovi);
                        break;
                    case 3: // Unos zeljenog prvog neodigranog kola
                        brojac++;
                        if(brojac > 14)
                        {
                            Console.WriteLine(Environment.NewLine + "Sva kola su  vec odigrana, izaberite drugu opciju : " + Environment.NewLine);
                            break;
                        }
                        else
                        {
                            GenerisiKoloRezultat(timovi, brojac);
                            break;
                        }
                    case 4: // Ispisuje sve timove i daje izbor o kom zelimo informacije
                        Console.WriteLine(Environment.NewLine);
                        bool petlja2 = true; // Ponovo da znamo kada je kraj petlje
                        while (petlja2 == true)
                        {
                            switch (SpisakTimova(timovi))
                            {
                                case 1:
                                    Console.WriteLine(timovi[0]);
                                    break;
                                case 2:
                                    Console.WriteLine(timovi[1]);
                                    break;
                                case 3:
                                    Console.WriteLine(timovi[2]);
                                    break;
                                case 4:
                                    Console.WriteLine(timovi[3]);
                                    break;
                                case 5:
                                    Console.WriteLine(timovi[4]);
                                    break;
                                case 6:
                                    Console.WriteLine(timovi[5]);
                                    break;
                                case 7:
                                    Console.WriteLine(timovi[6]);
                                    break;
                                case 8:
                                    Console.WriteLine(timovi[7]);
                                    break;
                                case 9:
                                    petlja2 = false; // kraj petlje
                                    break;
                            }
                        }
                        break;
                    case 5:
                        petlja = false; // kraj petlje
                        break;
                }
            }



        }
    }
}
