using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Interface_ConsoleApplication
{
    public class Abgeleitet : IAnzeige, IAbzaehlen
    {
        public void Anzeige(string s)
        {
            WriteLine("Die Anzeige: {0}", s);
        }

        public void Entladen()
        {

        }

    }
}
