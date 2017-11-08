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
            a1.Anzeige("Ich habe implementiert");

            ReadLine();

            AbgeleitetVonAbgeleitet aVona = new AbgeleitetVonAbgeleitet();
            aVona.Anzeige("Ich habe das Interface von meiner Masterklasse geerbt");

            ReadLine();

            AbgeleitetVonAndereAbleitung aVonAA = new AbgeleitetVonAndereAbleitung();

            // aVonAA.      // Hat das Anzeige nicht!
        }
    }
}
