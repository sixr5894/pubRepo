using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrder<T>
    {
        public Task<bool> AddOrderAsyync(T arg);
        public Task<IEnumerable<T>> GetAllOrdersAsync();
        public Task<bool> DeleteOrderAsync(T arg);
        public Task<bool> EditOrderAsync(T arg);
    }
}
