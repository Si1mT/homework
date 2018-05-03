using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XMLHarjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            var paljuTooteid = new List<Toode>();
            var toode1 = new Toode() { Nimi = "Banaan", Hind = "12" };
            var toode2 = new Toode() { Nimi = "Leib", Hind = "2" };
            var toode3 = new Toode() { Nimi = "Sai", Hind = "42" };
            var toode4 = new Toode() { Nimi = "Fanta", Hind = "52" };
            var toode5 = new Toode() { Nimi = "Pastakas", Hind = "222" };
            paljuTooteid.Add(toode1);
            paljuTooteid.Add(toode2);
            paljuTooteid.Add(toode3);
            paljuTooteid.Add(toode4);
            paljuTooteid.Add(toode5);

            //var serializer = new XmlSerializer(paljuTooteid.GetType());
            //using (var writer = XmlWriter.Create("tooted.xml"))
            //{
            //    serializer.Serialize(writer, paljuTooteid);
            //}

            var tooted = new List<Toode>();
            var serializer = new XmlSerializer(typeof(Toode));
            Console.ReadLine();
        }
    }
}
