
using System;

namespace Dispetcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanker[] tankers = new Tanker[3];
            tankers[0] = new Tanker_MAZ4(
                "21-60",
                "Сярожа",
                300.0,
                299.5,
                "Белорусьнефть"
                );
            tankers[1] = new Tanker_Fur21(
                "29-99",
                "Маруся",
                500.0,
                450.5,
                "РосНефть",
                2
                );
            tankers[2] = new Tanker_MAZ4(
               "08-08",
               "Вася",
               300.0,
               280.0,
               "Белорусьнефть"
               );


            Dispetcher masha = new Dispetcher("Maшa");
            masha.tankerList = tankers;
            masha.StartWork();

            Console.Read();
        }
    }
}
