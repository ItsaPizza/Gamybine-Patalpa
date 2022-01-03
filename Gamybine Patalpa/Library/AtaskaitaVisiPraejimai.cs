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
        private IvykisRepository _ivykisRepository;
        private VartaiRepository _vartaiRepository;
        private ZmogusRepository _zmogusRepository;

        public AtaskaitaVisiPraejimai(IvykisRepository ivykisRepository,VartaiRepository vartaiRepository, ZmogusRepository zmogusRepository)
        {
            _ivykisRepository = ivykisRepository;
            _vartaiRepository = vartaiRepository;
            _zmogusRepository = zmogusRepository;
        }

        public List<ReportItemPraejimai> GautiVisuPraejimus()
        {
            List<ReportItemPraejimai> praejimuSarasas = new List<ReportItemPraejimai>();
            List<Zmogus> zmones = _zmogusRepository.GautiZmones();
            List<Ivykis> ivykiai = _ivykisRepository.GautiIvykius();

            foreach(var zmogus in zmones)
            {
                var reportItemPraejimai = new ReportItemPraejimai();
                reportItemPraejimai.PraejimuSkaicius = 2;
                reportItemPraejimai.Vardas = zmogus.Vardas;
                reportItemPraejimai.Pavarde = zmogus.Pavarde;
                Vartai vartai = _vartaiRepository.GautiVienusVartus(zmogus.VartuId);
                reportItemPraejimai.VartuPavadinimas = vartai.Pavadinimas;
                foreach (var ivykis in ivykiai)
                {
                    if (ivykis.ZmogausId == zmogus.Id)
                    {
                        reportItemPraejimai.PraejimuSkaicius += 2;
                    }
                }

                praejimuSarasas.Add(reportItemPraejimai);
            }
            praejimuSarasas = praejimuSarasas.OrderBy(x => x.Vardas).ToList();
            return praejimuSarasas;
        }
    }
}
