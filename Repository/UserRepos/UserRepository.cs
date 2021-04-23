using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository.UserRepos
{
    public class UserRepository : IRepository<SHPUser>
    {
        public UserRepository() { this._sHPContext = new SHPContext(); }

        private SHPContext _sHPContext;

        public async Task<IEnumerable<SHPUser>> GetAllAsync()
        {
            return await this._sHPContext.Users.AsNoTracking().ToListAsync();
        }

        public async Task<SHPUser> GetByIDAsync(SHPUser arg)
        {
            var temp = await this._sHPContext.Users.Where(obj => obj.ID == arg.ID).FirstOrDefaultAsync();
            return temp;
        }

        public async Task<bool> AddAsync(SHPUser arg)
        {
            try
            {
                await this._sHPContext.AddAsync(arg);
                await this._sHPContext.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> EditAsync(SHPUser arg)
        {
            var temp = await this._sHPContext.Users.Where(obj => obj.ID == arg.ID).FirstOrDefaultAsync();
            if (temp != null)
            {
                temp.ChangeTo(arg);
                await this._sHPContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(SHPUser arg)
        {
            try
            {
                this._sHPContext.Users.Remove(arg);
                await this._sHPContext.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }
    }
}
