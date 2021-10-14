using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
     static class Extensions
    {
        static double sum = 0;
        public static double Sum1(this Advertisement[] advr)
        {
            foreach (Advertisement item in advr)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
