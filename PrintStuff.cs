using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language;
        public PrintStuff(string temp) {
            language = temp;
        }

        public void PrintName(string name)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + name + "!");
            }
            else if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + name + "!");
            }
            else if (language == "SP")
            {
                System.Console.WriteLine("Hola, " + name + "!");
            }
        }
    }
}
