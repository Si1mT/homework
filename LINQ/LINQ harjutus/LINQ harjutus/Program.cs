using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_harjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 13.03.2018
            ////uus array
            //int[] minuArvud = new int[5];
            //minuArvud[0] = 15;
            //minuArvud[1] = 155;
            //minuArvud[2] = 1555;
            //minuArvud[3] = 156;
            //minuArvud[4] = 157;

            //////uus list
            ////var minuArvudListis = new List<int>();
            ////minuArvudListis.Add(1);
            ////minuArvudListis.Add(2);
            ////minuArvudListis.Add(3);
            ////minuArvudListis.Add(4);
            ////minuArvudListis.Add(5);
            ////minuArvudListis.Add(6);
            ////minuArvudListis.Add(26);
            ////minuArvudListis.Add(8);
            ////või
            //List<int> minuArvudListis = new List<int>(
            //    new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            ////teen stringide listi
            //List<string> minuTekstidListis = new List<string>(
            //    new string[] { "abc", "bca", "cba" });
            ////veel üks stringide list
            //List<string> minuInimesedListis = new List<string>();
            ////teen objekti classist Inimene
            //Inimene esimeneInimene = new Inimene() { Nimi = "Siim", Vanus = 17 };
            ////või
            ////{
            ////    Nimi = "siim",
            ////    Vanus = 17
            ////};
            ////või
            ////esimeneInimene.Nimi = "siim";
            ////esimeneInimene.Vanus = 17;

            //List<Inimene> MinuInimesedListis2 = new List<Inimene> { new Inimene { Nimi = "Siim", Vanus = 17 } };
            ////lisan uue objekti inimeste listi
            //MinuInimesedListis2.Add(new Inimene { Nimi = "virko", Vanus = 16 });
            //MinuInimesedListis2.Add(new Inimene { Nimi = "dab", Vanus = 2 });
            //MinuInimesedListis2.Add(new Inimene { Nimi = "dab", Vanus = 5});


            ////loen läbi MinuInimesedListis2
            //foreach (Inimene inimene in MinuInimesedListis2)
            //{
            //    //Console.WriteLine("inimese nimi on: "+inimene.Nimi+" ja vanus on "+inimene.Vanus);
            //    Console.WriteLine("inimese nimi on {0} ja vanus on {1}",inimene.Nimi,inimene.Vanus);
            //}
            //Console.WriteLine();

            ////var inimesedKelleVanusOnKaks = MinuInimesedListis2.Where(x => x.Vanus == 2);
            //var inimesedKelleVanusOnKaks = from inimene in MinuInimesedListis2
            //                               orderby inimene.Vanus
            //                               where inimene.Nimi.Contains("i")
            //                               select inimene;

            //var mituInimest = MinuInimesedListis2.Count();
            //var mituErinevat = MinuInimesedListis2.Distinct(x=>);
            //Console.WriteLine("listis on {0} inimest",mituErinevat);
            //foreach (Inimene inimene in inimesedKelleVanusOnKaks)
            //{
            //    Console.WriteLine("inimese nimi on {0} ja vanus on {1}",inimene.Nimi,inimene.Vanus);
            //}

            //////lisan array elemendid listi lõppu
            ////minuArvudListis.AddRange(minuArvud);

            ////teen uue arvu
            //int uusInt = 12;
            ////lisan uusInt listis 7. koha taha
            //minuArvudListis.Insert(7, uusInt);
            ////loen välja kõik arvud listis
            //foreach(int arv in minuArvudListis)
            //{
            //    Console.WriteLine(arv);
            //}
            //Console.ReadLine();
            //////arvutan listi arvude keskmise
            ////double kesk=minuArvudListis.Average();
            //Console.WriteLine();
            ////Console.WriteLine(kesk);
            #endregion

            #region LINQ Kordamine
            //var humans1 = new List<Human>
            //{
            //    new Human(){Name="Siim",Age=17},
            //    new Human(){Name="Meelis",Age=18},
            //    new Human(){Name="Oliver",Age=17},
            //    new Human(){Name="Saimon",Age=15},
            //    new Human(){Name="Miisu",Age=15},
            //    new Human(){Name="Bom",Age=15},
            //    new Human(){Name="Barel",Age=15},

            //};

            //int[] numbers = new int[8] { 0, 1, 2, 3, 4, 5, 6, 5 };

            //var groups = from human in humans1
            //              group human by human.Age into newGroup
            //              select newGroup;

            //foreach(var group in groups)
            //{
            //    Console.WriteLine("uus grupp: ");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item.Age+" "+item.Name);
            //    }

            //}

            //var firstLetterGroup = from human in humans1
            //                       group human by human.Name[0];//<== [0] grupitab nime esimese tähe järgi

            //foreach (var humanGroup in firstLetterGroup)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Key: "+humanGroup.Key);

            //    foreach (var human in humanGroup)
            //    {
            //        Console.WriteLine(human.Name+" "+human.Age);
            //    }
            //}
            #endregion

            #region Harjutus
            
            //eesnimede loetelu
            var humans1 = new List<Human>
            {
                new Human(){Name="Siim",Age=17},
                new Human(){Name="Meelis",Age=18},
                new Human(){Name="Oliver",Age=17},
                new Human(){Name="Saimon",Age=12},
                new Human(){Name="Miisu",Age=20},
                new Human(){Name="Bom",Age=13},
                new Human(){Name="Barel",Age=12},
                new Human(){Name="Tom",Age=20},
                new Human(){Name="Ats",Age=15},
                new Human(){Name="Ash",Age=30},
            };

            //grupeerin nimed pikkuse järgi
            var groups1 = from human in humans1
                         group human by human.Name.Length;

             //kirjutan välja need nimed ja mitu nime on grupis             
            foreach (var group in groups1)
            {
                Console.WriteLine();
                Console.WriteLine("uus grupp: ");
                Console.WriteLine("nimede arv: "+group.Count());
                foreach (var item in group)
                {
                    Console.WriteLine(item.Name+" "+item.Age);
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
