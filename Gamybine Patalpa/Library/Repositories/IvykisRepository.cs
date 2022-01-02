using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class IvykisRepository
    {
        private List<Ivykis> ivykiai = new List<Ivykis>();
        public IvykisRepository()
        {                       
            ivykiai.Add(new Ivykis("Pietauti", new TimeSpan(01, 00, 00)));
            ivykiai.Add(new Ivykis("Parukyti", new TimeSpan(00, 15, 00)));
            ivykiai.Add(new Ivykis("Tualetas", new TimeSpan(00, 10, 00)));
        }

        public List<Ivykis> GautiIvykius() => ivykiai;
        public Ivykis GautiIvyki(string ivykis)
        {
            var gautasIvykis = ivykiai.FirstOrDefault(x => x.Pavadinimas == ivykis);

            return gautasIvykis;
        }
    }
}
