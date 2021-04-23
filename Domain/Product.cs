using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public  string Name { get; set; }
        public int Price { get; set; }
        private Types _type { get; }
    }
}
