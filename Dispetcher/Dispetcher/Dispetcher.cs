using System;
using System.Collections.Generic;
using Dispetcher.Zapravki;

namespace Dispetcher
{
    class Dispetcher
    {
        public string name { get; private set; }

        private List<Zapravka> zapravkaList;
        public Tanker[] tankerList { get; set; }

        public Dispetcher(string n)
        {
            name = n;
            zapravkaList = new List<Zapravka>();
            Tanker[] tankerList = new Tanker[0];
            CreateList();
        }

        private void CreateList()
        {
            zapravkaList.Add(new Zapravka(1, 500, 499));
            zapravkaList.Add(new Zapravka(2, 300, 200));
        }

        public void StartWork()
        {
            if (tankerList.Length > 0)
                Work();
            else Console.WriteLine("Делаю вид, что работаю...");
        }

        private void Work()
        {
            int i = 0;
            foreach(Zapravka zapr in zapravkaList)
            {
                while(zapr.VolumeEmpy != 0 && i < tankerList.Length)
                {
                    zapr.StartFill(tankerList[i]);
                    if(tankerList[i].GetVolumeFuel() == 0)
                        i++;
                    Console.WriteLine();
                }
            }
        }
    }
}
