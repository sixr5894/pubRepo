using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.OrderRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.Shop;
using UseCases.Shop.RandPriceGenerator;

namespace MxdlShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        public OrderController()
        {
            this._pricegen = new RandPriceGenerator();
            this._order = OrderReposFactory.CreateOrderRepository();
        }
        private IOrder<SHPOrder> _order;
        private RandPriceGenerator _pricegen;
        [HttpPost]
        public async Task<IActionResult> GetOrder(SHPOrder order)
        {
            var temp = await Task.Run(()=>this.InnerOrder(order));
            return Json(temp);
        }
        [HttpPut]
        public async Task<IActionResult> ConfirmOrder(SHPOrder order)
        {
            bool temp = await this._order.AddOrderAsyync(order);
            if (temp)
                return Ok("Order Added");
            return BadRequest("Order Not added");
        }

        private SHPOrder InnerOrder(SHPOrder order)
        {
            var temp = new SHPOrder(this._pricegen.GetPrice(order.Sum), order.ClientName, order.City);
            return temp;
        }
    }
}
