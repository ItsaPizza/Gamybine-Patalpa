using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Zmogus
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int VartuId { get; set; }


        public Zmogus() { }
        public Zmogus(int id, string vardas, string pavarde, int vartuId)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            VartuId = vartuId;
        }
    }
}