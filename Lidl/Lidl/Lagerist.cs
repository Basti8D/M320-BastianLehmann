using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    internal class Lagerist : Person
    {
        public int groesse {  get; set; }
        public Lagerist() { }
        public void lagereEin() {
            Console.WriteLine("Ich als Lagerist {0} {1} lagere ein.", Vorname, Name);
        }
        public override void Trage()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} trage mit dem Stapler.", Vorname, Name);
        }
    }
}
