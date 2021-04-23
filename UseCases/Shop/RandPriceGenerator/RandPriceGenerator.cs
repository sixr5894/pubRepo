using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Shop.RandPriceGenerator
{
    public class RandPriceGenerator
    {
        public int GetPrice(int param)
        {
            var temp = new Random();
            return param - temp.Next(1,500);
        }
    }
}
