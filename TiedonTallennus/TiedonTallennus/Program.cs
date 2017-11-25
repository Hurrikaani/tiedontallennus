using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {

            String tiedosto = @"C:\Koodailua\Lämpötila.txt";

            if (File.Exists(tiedosto))
            {
                String Aiempiarvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiempi arvo oli " + Aiempiarvo + "Astetta");

            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }
            Console.ReadLine();
            
        }
    }
}
