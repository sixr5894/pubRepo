using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;
using Repository.AuthRepos;
using Microsoft.AspNetCore.Mvc;
using Repository.Context;

namespace Shop.Repository.AuthRepos
{
    public class Authenticator : IAuthenticator<AuthModel>
    {
        public Authenticator()
        {
            this._cont = new SHPContext();
        }
        private SHPContext _cont;
        public async Task<bool> LogInAsync(AuthModel model)
        {
            bool temp = await Task.Run(()=>this.LogIn(model));
            if (!temp) return false;
            return true;
        }
        private bool LogIn(AuthModel model)
        {
            if (model.Login == "Laziz" && model.Password == "Khotamov")
                return true;
            return false;
        }

    }
}
