using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository.OrderRepos
{
    public static class OrderReposFactory
    {
        public static IOrder<SHPOrder> CreateOrderRepository()
        {
            var temp =(IOrder<SHPOrder>) new OrderRepository();
            return temp;
        }
    }
}
