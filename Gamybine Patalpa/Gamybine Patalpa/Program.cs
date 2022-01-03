using Library;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ivykisRepository = new IvykisRepository();
            var vartaiRepository = new VartaiRepository();
            var zmogusRepository = new ZmogusRepository();
            var ataskaitaVisiPraejimai = new AtaskaitaVisiPraejimai(ivykisRepository, vartaiRepository, zmogusRepository);
            var ataskaitaDarboValandos = new AtaskaitaDarboValandos(ivykisRepository, zmogusRepository);
            List<ReportItemPraejimai> visuPraejimai = ataskaitaVisiPraejimai.GautiVisuPraejimus();
            List<ReportItemDarboValandos> visuDarboValandos = ataskaitaDarboValandos.GautiVisuDarboValandas();

            Console.WriteLine("Visu darbuotoju praejimu pro vartus ataskaita: ");
            foreach(var item in visuPraejimai)
            {
                Console.WriteLine($"{item.Vardas} {item.Pavarde} praejo pro {item.VartuPavadinimas} vartus {item.PraejimuSkaicius} kartu(-us)");
            }
            Console.WriteLine();
            Console.WriteLine("Visu darbuotoju darbo laiko ataskaita: ");
            foreach(var item in visuDarboValandos)
            {
                Console.WriteLine($"{item.Vardas} {item.Pavarde} darbo laikas truko {item.DarboLaikas}");
            }

            Console.ReadLine();
        }
    }
}