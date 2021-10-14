using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Advertisement : IComparable
    {
        public string Name { get; set; }
        public string SailorName { get; set; }
        public double Price { get; set; }
        enum Category
        {
            Low,
            Medium,
            High
        }
        public Advertisement(double price)
        {
               this.Price = price; 
        }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(((Advertisement)obj).Price);
            //Advertisement compareTo = (Advertisement)obj;
            //if (Price> compareTo.Price)
            //{
            //    return 1;
            //}
            //else if (Price == compareTo.Price)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return -1;
            //}
        }


        public static bool operator >(Advertisement advr1 , Advertisement advr2)
        {
            return advr1.Price > advr2.Price;
        }
        public static bool operator <(Advertisement advr1, Advertisement advr2)
        {
            return advr1.Price < advr2.Price;
        }

                                                                                                                    
    }
   
}
