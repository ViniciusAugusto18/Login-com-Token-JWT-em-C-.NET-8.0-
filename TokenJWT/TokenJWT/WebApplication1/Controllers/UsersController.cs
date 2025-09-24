using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class UsersController : ControllerBase
    {
        [HttpGet("Users")]

        public ActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("Users{id}")]
        public ActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpPost ("Register")]
        public ActionResult RegisterUser(UserDTO userDTO)
        {
             return Ok();
        }
        [HttpPut("Users{id}")]
        public ActionResult EditUser(int id)
        {

                return Ok();
            
        }
        [HttpDelete("Users{id}")]
        public ActionResult DeleteUser(int id)
        {
                return Ok();
            
        }
    }
}
