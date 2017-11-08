using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interface_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Abgeleitet a1 = new Abgeleitet();
            ((IAnzeige)a1).Anzeige("Ich habe implementiert");       // cast auf a1 geht! a1.IAnzeige.Anzeige funktioniert nicht

            ReadLine();

            AbgeleitetVonAbgeleitet aVona = new AbgeleitetVonAbgeleitet();
            ((IAbzaehlen)aVona).Anzeige("Ich habe das Interface von meiner Masterklasse geerbt");


            ReadLine();

            AbgeleitetVonAndereAbleitung aVonAA = new AbgeleitetVonAndereAbleitung();


            List<int> intList = new List<int>();


            // aVonAA.      // Hat das Anzeige nicht!

            
        }
    }
}
