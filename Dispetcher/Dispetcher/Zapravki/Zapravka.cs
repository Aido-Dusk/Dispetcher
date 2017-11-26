using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dispetcher.Zapravki
{
    class Zapravka
    {
        public int Number { get; private set; }
        public double Volume { get; private set; }
        public double VolumeEmpy { get; set; }

        public Zapravka(int num, double V, double VF)
        {
            Number = num;
            Volume = V;
            VolumeEmpy = VF;
        }

        public void StartFill(Tanker tanker)
        {
            Console.WriteLine($"Заправка колонки {Number}, Свободное мето: {VolumeEmpy}");
            Console.WriteLine($"Танкер: {tanker.Numder}, Водитель: {tanker.NameDriver}, Топливо: {tanker.GetVolumeFuel()}");

            VolumeEmpy = tanker.StartFillZapr(VolumeEmpy);

            if (VolumeEmpy == 0)
            {
                Console.WriteLine($"Колонка номер {Number} заправлена...");
            }
            else
            {
                Console.WriteLine($"В колонке номер {Number} осталось {VolumeEmpy} свободного места...");
            }
        }
    }
}
