using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Ivykis
    {
        public string Pavadinimas { get; set; }
        public TimeSpan Trukme { get; set; }
        public Ivykis() { }
        public Ivykis(string pavadinimas, TimeSpan trukme)
        {
            Pavadinimas = pavadinimas;
            Trukme = trukme;
        }

    }
}
