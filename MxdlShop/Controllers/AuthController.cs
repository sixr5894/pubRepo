using Microsoft.AspNetCore.Mvc;
using Repository.AuthRepos;
using Shop.Repository.AuthRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MxdlShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        public AuthController() { this._authenticator = AuthFactory.Create(); }

        private IAuthenticator<AuthModel> _authenticator; 
        [HttpPost]
        public async Task<IActionResult> GetToken(AuthModel model)
        {

            if (!await this._authenticator.LogInAsync(model))
                return BadRequest("NO acces");
            var temp = JwtFactory.CreateJwt(model.Login);
            return Json(new { token = temp, status = true }) ;
        }
    }
}
