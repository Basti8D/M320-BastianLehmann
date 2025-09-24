using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    internal class Kunde : Person
    {
        public Kunde() 
        {
            umsatz = 0;
        }
        public double umsatz {  get; set; }
        public void Kaufe()
        {
            Console.WriteLine("Ich als Kunde {0} {1} kaufe bei Lidl", Vorname, Name);
        }
        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde {0} {1} trage mit dem Einkaufswagen", Vorname, Name);
        }
    }
}
