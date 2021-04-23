using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.OrderRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.Shop;

namespace MxdlShop.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("[controller]")]
    public class ModeratorController : Controller
    {
        private IOrder<SHPOrder> _order;
        public ModeratorController() { this._order = OrderReposFactory.CreateOrderRepository(); }

        [HttpGet]
        public async Task<IActionResult> GetAllOrdersAsync()
        {
            var temp = await this._order.GetAllOrdersAsync();
            return Json(temp);
        }
        [HttpPut]
        public async Task<IActionResult> DeleteOrder(SHPOrder order)
        {
            if (await this._order.DeleteOrderAsync(order))
                return Ok("success");
            return BadRequest("error occured");
        }
        [HttpPost]
        public async Task<IActionResult> EditOrder(SHPOrder order)
        {
            bool temp = await this._order.EditOrderAsync(order);
            if(temp)
                return Ok("success");
            return BadRequest("error occured");
        }
    }
}
