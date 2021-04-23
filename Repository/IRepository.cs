using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository 
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIDAsync(T arg);
        public Task<bool> AddAsync(T arg);
        public Task<bool> EditAsync(T arg);
        public Task<bool> DeleteAsync(T arg);
    }
}
