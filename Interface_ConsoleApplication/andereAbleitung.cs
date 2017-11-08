using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interface_ConsoleApplication
{
    public class AndereAbleitung : IAnzeige, IAbzaehlen
    {
        void IAnzeige.Anzeige(string s)
        {
            WriteLine("Ich könnte den string zeigen, will aber nicht");
        }

        void IAnzeige.Entladen()
        {
            throw new NotImplementedException();
        }

        void IAbzaehlen.Anzeige(string s)
        {

        }
        void IAbzaehlen.Entladen()
        {

        }
    }
}
