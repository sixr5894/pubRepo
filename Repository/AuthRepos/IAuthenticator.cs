using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AuthRepos
{
    public interface IAuthenticator<T>
    {
        public Task<bool> LogInAsync(T arg);
    }
}
