﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interface_ConsoleApplication
{
    public interface IAnzeige       // vorher ICaption
    {
        // nur die Methoden erklärt, nicht implementiert

        void Anzeige(string s);        // der Vertrag, was implementierende Klassen umsetzen müssen
                                       // Konventionsgemäß wird der implementierung von interface ein großes I voran gestellt
                                       // Methode vom Interface auch groß, damit man weiß, dass es aus dem Interface stammt
        
        
    }

}
