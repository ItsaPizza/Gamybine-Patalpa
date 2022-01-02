using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AtaskaitaVisiPraejimai
    {
        private VartaiRepository _vartaiRepository;
        private ZmogusRepository _zmogusRepository;

        public AtaskaitaVisiPraejimai(VartaiRepository vartaiRepository, ZmogusRepository zmogusRepository)
        {
            _vartaiRepository = vartaiRepository;
            _zmogusRepository = zmogusRepository;
        }

        public List<ReportItemPraejimai> GautiVisuPraejimus()
        {
            List<ReportItemPraejimai> praejimuSarasas = new List<ReportItemPraejimai>();
            List<Zmogus> zmones = _zmogusRepository.GautiZmones();
            

            foreach(var zmogus in zmones)
            {
                var reportItemPraejimai = new ReportItemPraejimai();
                int pertraukuSkaicius = zmogus.PietuSkaicius + zmogus.ParukymoSkaicius + zmogus.TualetoSkaicius;
                reportItemPraejimai.PraejimuSkaicius = 2 + (pertraukuSkaicius * 2);
                reportItemPraejimai.Vardas = zmogus.Vardas;
                reportItemPraejimai.Pavarde = zmogus.Pavarde;
                Vartai vartai = _vartaiRepository.GautiVienusVartus(zmogus.VartuId);                
                reportItemPraejimai.VartuPavadinimas = vartai.Pavadinimas;
                praejimuSarasas.Add(reportItemPraejimai);
            }
            return praejimuSarasas;
        }
    }
}
