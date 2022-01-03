using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Ivykis
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public int ZmogausId { get; set; }
        public TimeSpan Trukme { get; set; }
        public Ivykis() { }
        public Ivykis(int id, string pavadinimas, int zmogausId, TimeSpan trukme)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            ZmogausId = zmogausId;
            Trukme = trukme;
        }

    }
}
