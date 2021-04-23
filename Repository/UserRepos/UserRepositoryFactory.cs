using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository.UserRepos
{
    public static class UserRepositoryFactory
    {
        public static IRepository<SHPUser> CreateUserRepository()
        {
            var temp = (IRepository<SHPUser>) new UserRepository();
            return temp;
        }
    }
}
