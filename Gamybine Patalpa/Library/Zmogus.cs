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
        public int VartuId { get; set; }
        public int PietuSkaicius { get; set; }
        public int ParukymoSkaicius { get; set; }
        public int TualetoSkaicius { get; set; }

        public Zmogus() { }
        public Zmogus(string vardas, string pavarde, int vartuId, int pietuSkaicius, int parukymoSkaicius, int tualetoSkaicius)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            VartuId = vartuId;
            PietuSkaicius = pietuSkaicius;
            ParukymoSkaicius = parukymoSkaicius;
            TualetoSkaicius = tualetoSkaicius;
        }
    }
}