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
            zmones.Add(new Zmogus("John", "Snow", 1, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Tirion", "Lanister", 2, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Tywin", "Lanister", 2, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Jamie", "Lanister", 2, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Ned", "Stark", 3, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Aria", "Stark", 3, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Sansa", "Stark", 3, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Robert", "Barathian", 4, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Stanis", "Barathian", 4, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
            zmones.Add(new Zmogus("Denerys", "Targarian", 1, GautiPietuSkaiciu(), GautiParukymoSkaiciu(), GautiTualetoSkaiciu()));
        }

        private int GautiPietuSkaiciu()
        {
            var random = new Random();
            int pietuSkaicius = random.Next(0, 3);
            
            return pietuSkaicius;
        }
        private int GautiParukymoSkaiciu()
        {
            var random = new Random();
            int parukymoSkaicius = random.Next(0, 5);

            return parukymoSkaicius;
        }
        private int GautiTualetoSkaiciu()
        {
            var random = new Random();
            int tualetoSkaicius = random.Next(1, 6);

            return tualetoSkaicius;
        }
        public List<Zmogus> GautiZmones() => zmones;

    }
}
