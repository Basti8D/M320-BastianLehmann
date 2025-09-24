using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public Person() { }
        public void essen() 
        {
            Console.WriteLine("Ich als Person {0} {1} esse mit Messer und Gabel", Vorname, Name);
        }
        public abstract void Trage();
    }
}
