using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement advr = new Advertisement(20.3);
            Advertisement advr1 = new Advertisement(59.3);
            Advertisement advr2 = new Advertisement(33.7);
            Advertisement advr3 = new Advertisement(10.9);
            Advertisement advr4 = new Advertisement(100.9);

            Advertisement[] advs = { advr, advr1, advr2, advr3,advr4};

            //Console.WriteLine(advs.Sum1());

            //Array.Sort(advs);

            //foreach (Advertisement item in advs)
            //{
            //    Console.WriteLine(item.Price);
            //}

            //Console.WriteLine(advr > advr1);


            Console.ReadKey();
        }
    }
}
