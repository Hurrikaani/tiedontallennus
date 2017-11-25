using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouluharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpätila = 0;

            Console.WriteLine("Anna uusi lämpätila");
            String Syöte = Console.ReadLine();
            lämpätila = int.Parse(Syöte);

            //Tiedostoon kirjoittaminen
            String tiedosto = @"C:\Koodailua\Lämpötila.txt";
            File.WriteAllText(tiedosto, lämpätila.ToString());
            Console.WriteLine("Lämpötila on tallennettu");

            Console.ReadLine();
        }
    }
}
