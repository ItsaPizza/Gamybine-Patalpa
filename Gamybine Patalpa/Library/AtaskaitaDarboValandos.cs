using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AtaskaitaDarboValandos
    {
        private IvykisRepository _ivykisRepository;
        private ZmogusRepository _zmogusRepository;

        public AtaskaitaDarboValandos(IvykisRepository ivykisRepository, ZmogusRepository zmogusRepository)
        {
            _ivykisRepository = ivykisRepository;
            _zmogusRepository = zmogusRepository;
        }
        public List<ReportItemDarboValandos> GautiVisuDarboValandas()
        {
            List<ReportItemDarboValandos> darboValanduSarasas = new List<ReportItemDarboValandos>();
            List<Zmogus> zmones = _zmogusRepository.GautiZmones();
            List<Ivykis> ivykiai = _ivykisRepository.GautiIvykius();

            foreach(var zmogus in zmones)
            {
                var reportItemDarboValandos = new ReportItemDarboValandos();
                reportItemDarboValandos.Vardas = zmogus.Vardas;
                reportItemDarboValandos.Pavarde = zmogus.Pavarde;
                TimeSpan darboLaikas = new TimeSpan(09, 00, 00);

                foreach (var ivykis in ivykiai)
                {
                    if (ivykis.ZmogausId == zmogus.Id)
                    {
                        darboLaikas -= ivykis.Trukme;
                    }
                }
                reportItemDarboValandos.DarboLaikas = darboLaikas;

                darboValanduSarasas.Add(reportItemDarboValandos);
            }

            return darboValanduSarasas;
        }
        //private TimeSpan GautiIvykioLaika(string ivykis)
        //{
        //    Ivykis gautasIvykis = _ivykisRepository.GautiIvyki(ivykis);
            
        //    return gautasIvykis.Trukme;
        //}
        
        
    }
}
