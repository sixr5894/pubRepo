using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository.OrderRepos
{
    public class OrderRepository : IOrder<SHPOrder>
    {
        public OrderRepository() { this._cont = new SHPContext(); }
        private SHPContext _cont;

        public async Task<bool> AddOrderAsyync(SHPOrder arg)
        {
            try
            {
                await this._cont.AddAsync(arg);
                await this._cont.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<SHPOrder>> GetAllOrdersAsync()
        {
            var temp = await this._cont.Orders.AsNoTracking().ToListAsync();
            return temp;
        }

        public async Task<bool> DeleteOrderAsync(SHPOrder arg)
        {
            try
            {
                this._cont.Remove(arg);
                await this._cont.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> EditOrderAsync(SHPOrder arg)
        {
            var temp = await this._cont.Orders.FirstOrDefaultAsync((user)=>user.ID==arg.ID);
            if (temp == null)
                return false;
            temp.PaymentDone = arg.PaymentDone;
            temp.Sum = arg.Sum;
            temp.City = arg.City;
            temp.ClientName = arg.ClientName;
            await this._cont.SaveChangesAsync();
            return true;
        }
    }
}
