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
            //uus array
            int[] minuArvud = new int[5];
            minuArvud[0] = 15;
            minuArvud[1] = 155;
            minuArvud[2] = 1555;
            minuArvud[3] = 156;
            minuArvud[4] = 157;

            ////uus list
            //var minuArvudListis = new List<int>();
            //minuArvudListis.Add(1);
            //minuArvudListis.Add(2);
            //minuArvudListis.Add(3);
            //minuArvudListis.Add(4);
            //minuArvudListis.Add(5);
            //minuArvudListis.Add(6);
            //minuArvudListis.Add(26);
            //minuArvudListis.Add(8);
            //või
            List<int> minuArvudListis = new List<int>(
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            //teen stringide listi
            List<string> minuTekstidListis = new List<string>(
                new string[] { "abc", "bca", "cba" });
            //veel üks stringide list
            List<string> minuInimesedListis = new List<string>();
            //teen objekti classist Inimene
            Inimene esimeneInimene = new Inimene() { Nimi = "Siim", Vanus = 17 };
            //või
            //{
            //    Nimi = "siim",
            //    Vanus = 17
            //};
            //või
            //esimeneInimene.Nimi = "siim";
            //esimeneInimene.Vanus = 17;

            List<Inimene> MinuInimesedListis2 = new List<Inimene> { new Inimene { Nimi = "Siim", Vanus = 17 } };

            foreach (Inimene inimene in MinuInimesedListis2)
            {
                //Console.WriteLine("inimese nimi on: "+inimene.Nimi+" ja vanus on "+inimene.Vanus);
                Console.WriteLine("inimese nimi on {0} ja vanus on {1}",inimene.Nimi,inimene.Vanus);
            }

            ////lisan array elemendid listi lõppu
            //minuArvudListis.AddRange(minuArvud);

            //teen uue arvu
            int uusInt = 12;
            //lisan uusInt listis 7. koha taha
            minuArvudListis.Insert(7, uusInt);
            //loen välja kõik arvud listis
            foreach(int arv in minuArvudListis)
            {
                Console.WriteLine(arv);
            }
            Console.ReadLine();
            //arvutan listi arvude keskmise
            double kesk=minuArvudListis.Average();
            Console.WriteLine();
            Console.WriteLine(kesk);
            Console.ReadLine();
        }
    }
}
