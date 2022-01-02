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
        private IvykisRepository _ivykisRepository = new IvykisRepository();
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

            foreach(var zmogus in zmones)
            {
                var reportItemDarboValandos = new ReportItemDarboValandos();

                TimeSpan pietuLaikas = GautiIvykioLaika("Pietauti") * zmogus.PietuSkaicius;
                TimeSpan parukymoLaikas = GautiIvykioLaika("Parukyti") * zmogus.ParukymoSkaicius;
                TimeSpan tualetoLaikas = GautiIvykioLaika("Tualetas") * zmogus.TualetoSkaicius;
                TimeSpan darboLaikas = new TimeSpan(9, 0, 0) - pietuLaikas - parukymoLaikas - tualetoLaikas;
                reportItemDarboValandos.Vardas = zmogus.Vardas;
                reportItemDarboValandos.Pavarde = zmogus.Pavarde;
                reportItemDarboValandos.DarboLaikas = darboLaikas;
                darboValanduSarasas.Add(reportItemDarboValandos);
            }

            return darboValanduSarasas;
        }
        private TimeSpan GautiIvykioLaika(string ivykis)
        {
            Ivykis gautasIvykis = _ivykisRepository.GautiIvyki(ivykis);
            
            return gautasIvykis.Trukme;
        }
        
        
    }
}
