using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class LoginController : ControllerBase
    {

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserDTO? userdto)
        {
            return Ok(userdto);
        }

    }
}
