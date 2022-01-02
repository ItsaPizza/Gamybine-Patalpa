using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class VartaiRepository
    {
        private List<Vartai> vartai = new List<Vartai>();
        public VartaiRepository()
        {
            vartai.Add(new Vartai("Siauriniai", 1));
            vartai.Add(new Vartai("Pietiniai", 2));
            vartai.Add(new Vartai("Rytiniai", 3));
            vartai.Add(new Vartai("Vakariniai", 4));
        }
    }
}
