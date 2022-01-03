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

        public IvykisRepository(int skaicius)
        {
            GeneruotiIvykius(skaicius);
            Console.WriteLine("Ivykiu sarasas:");
            Console.WriteLine();
            foreach (var ivykis in ivykiai)
            {
                Console.WriteLine($"Ivykis {ivykis.Id}: Zmogaus ID: {ivykis.ZmogausId}, Veiksmas: {ivykis.Pavadinimas}");
            }
            Console.WriteLine();
        }

        public List<Ivykis> GautiIvykius() => ivykiai;
        public Ivykis GautiIvyki(string ivykis)
        {
            var gautasIvykis = ivykiai.FirstOrDefault(x => x.Pavadinimas == ivykis);

            return gautasIvykis;
        }
        public TimeSpan GautiLaika(string ivykis)
        {
            switch (ivykis)
            {
                case "Pietauti":
                    return new TimeSpan(01, 00, 00);
                case "Parukyti":
                    return new TimeSpan(00, 15, 00);
                case "Tualetas":
                    return new TimeSpan(00, 10, 00);
                default: throw new ArgumentException(nameof(ivykis));
            }
        }
        private void GeneruotiIvykius(int skaicius)
        {
            var random = new Random();

            for (int i = 0; i < skaicius; i++)
            {
                var ivykis = new Ivykis();
                ivykis.Id = i + 1;                
                var veiksmas = random.Next(1, 10);
                switch (veiksmas)
                {
                    case 1:
                    case 2:
                        ivykis.Pavadinimas = "Pietauti";
                        break;                    
                    case 3:
                    case 4:
                    case 5:
                        ivykis.Pavadinimas = "Parukyti";
                        break;                    
                    case 6:
                    case 7:
                    case 8:
                    case 9:                    
                        ivykis.Pavadinimas = "Tualetas";
                        break;
                    default:
                        break;
                }
                ivykis.ZmogausId = random.Next(1, 11);
                ivykis.Trukme = GautiLaika(ivykis.Pavadinimas);
                ivykiai.Add(ivykis);
            }

        }
            

           
        
    }
}
