using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class ZmogusRepository
    {
        
        private List<Zmogus> zmones = new List<Zmogus>();
        public ZmogusRepository()
        {
            zmones.Add(new Zmogus(1, "John", "Snow", 1));
            zmones.Add(new Zmogus(2, "Tirion", "Lanister", 2));
            zmones.Add(new Zmogus(3, "Tywin", "Lanister", 2));
            zmones.Add(new Zmogus(4, "Jamie", "Lanister", 2));
            zmones.Add(new Zmogus(5, "Ned", "Stark", 3));
            zmones.Add(new Zmogus(6, "Aria", "Stark", 3));
            zmones.Add(new Zmogus(7, "Sansa", "Stark", 3));
            zmones.Add(new Zmogus(8, "Robert", "Barathian", 4));
            zmones.Add(new Zmogus(9, "Stanis", "Barathian", 4));
            zmones.Add(new Zmogus(10, "Denerys", "Targarian", 1));
        }

        public List<Zmogus> GautiZmones() => zmones;
        public Zmogus GautiZmogu(int id)
        {
            return zmones[id];
        }

    }
}
