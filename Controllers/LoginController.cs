using ApiAuth.Models;
using ApiAuth.Repositories;
using ApiAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {


        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            var user = UserRepository.Get(model.UserName, model.Password);
            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }
            //gera o token
            var token = TokenServices.GenerateToken(user);
            //oculta a senha
            user.Password = "";
            //retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }

    }
    }

