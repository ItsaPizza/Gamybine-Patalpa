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
            vartai.Add(new Vartai("Siaurinius", 1));
            vartai.Add(new Vartai("Pietinius", 2));
            vartai.Add(new Vartai("Rytinius", 3));
            vartai.Add(new Vartai("Vakarinius", 4));
        }
        public List<Vartai> GautiVisusVartus() => vartai;
        public Vartai GautiVienusVartus(int id)
        {
            var gautiVartai = vartai.FirstOrDefault(x => x.Id == id);

            return gautiVartai;
        }
    }
}
