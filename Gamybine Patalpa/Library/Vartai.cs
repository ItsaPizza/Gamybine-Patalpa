using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Vartai
    {
        public string Pavadinimas { get; set; }
        public int Id { get; set; }
        

        public Vartai() { }
        public Vartai(string pavadinimas, int id)
        {
            Pavadinimas = pavadinimas;
            Id = id;
        }

    }
}
