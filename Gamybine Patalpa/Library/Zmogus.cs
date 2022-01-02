using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int VartuNumeris { get; set; }
        public int PraejimuSkaicius { get; set; }
        public DateTime DarboLaikas { get; set; }

        public Zmogus() { }
        public Zmogus(string vardas, string pavarde, int varduNumeris, int praejimuSkaicius, DateTime darboLaikas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            VartuNumeris = varduNumeris;
            PraejimuSkaicius = praejimuSkaicius;
            DarboLaikas = darboLaikas;
        }
    }
}