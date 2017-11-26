using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dispetcher
{
    class Tanker
    {
        public string Numder { get; protected set; }
        public string NameDriver { get; protected set; }
        public double Volume { get; protected set; }
        public double VolumeFuel { get; set; }

        public virtual double GetVolumeFuel()
        {  
            return VolumeFuel;
        }
        public virtual double StartFillZapr(double volumeZapr)
        {
            if (volumeZapr > VolumeFuel)
            {
                double temp = VolumeFuel;
                VolumeFuel = 0;
                return volumeZapr - temp;
            }

            VolumeFuel -= volumeZapr;

            if (VolumeFuel == 0)
                Console.WriteLine($"Танкер {Numder} пустой...");
            return 0;
        }

    }

    class Tanker_MAZ4 : Tanker
    {
        public string CompanyName { get; private set; }

        public Tanker_MAZ4(string num, string nd, double v, double vF, string company)
        {
            Numder = num;
            NameDriver = nd;
            Volume = v;
            VolumeFuel = vF;
            CompanyName = company;
        }

        public override double GetVolumeFuel()
        {
            return VolumeFuel * 1.019;   // при переливе топливо протекает
        }

        public override double StartFillZapr(double volumeZapr)
        {
            if (volumeZapr > VolumeFuel * 1.019)
            {
                double temp = VolumeFuel;
                VolumeFuel = 0;
                return volumeZapr - temp * 1.019;
            }

            VolumeFuel -= volumeZapr  + VolumeFuel  * 1.019;

            if (VolumeFuel == 0)
                Console.WriteLine($"Танкер {Numder} пустой...");
            return 0;
        }
    }

    class Tanker_Fur21 : Tanker
    {
        public string CompanyName { get; private set; }
        public int countDriver { get; private set; }

        public Tanker_Fur21(string num, string nd, double v, double vF, string company, int cD)
        {
            Numder = num;
            NameDriver = nd;
            Volume = v;
            VolumeFuel = vF;
            CompanyName = company;
            countDriver = cD;
        }
    }
}
