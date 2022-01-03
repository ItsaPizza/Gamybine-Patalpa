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
            GeneruotiIvykius(50);
            foreach (var ivykis in ivykiai)
            {
                Console.WriteLine($"Ivykis {ivykis.Id}: Zmogaus ID: {ivykis.ZmogausId}, Veiksmas: {ivykis.Pavadinimas}");
            }
        }

        public List<Ivykis> GautiIvykius() => ivykiai;
        public Ivykis GautiIvyki(string ivykis)
        {
            var gautasIvykis = ivykiai.FirstOrDefault(x => x.Pavadinimas == ivykis);

            return gautasIvykis;
        }
        private TimeSpan GautiLaika(string ivykis)
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
            
            for (int i = 0; i < skaicius; i++)
            {
                var ivykis = new Ivykis();
                ivykis.Id = i + 1;
                var random = new Random();
                var veiksmas = random.Next(1, 4);
                switch (veiksmas)
                {
                    case 1:
                        ivykis.Pavadinimas = "Pietauti";
                        break;
                    case 2:
                        ivykis.Pavadinimas = "Parukyti";
                        break;
                    case 3:
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
