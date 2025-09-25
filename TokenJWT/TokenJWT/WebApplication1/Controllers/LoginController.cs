using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Services.Interface;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginservice;
        public LoginController(ILoginService loginservice)
        {
            _loginservice = loginservice;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserDTO userdto)
        {
            Token? token = new Token();
            token = _loginservice.Login(userdto);
            if (token == null)
                return Unauthorized(new { Message = "Invalid Credentials" });

            return Ok();
        }

    }
}
