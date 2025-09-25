using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Services.Interface;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class UsersController : ControllerBase
    {   
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService) 
        { 
            _usersService = usersService;
        }
        [HttpGet("Users")]

        public ActionResult GetAll()
        {
           var users = _usersService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("Users{id}")]
        public ActionResult GetById(Guid id)
        {
            var user = _usersService.GetUserById(id);
            if (user == null)
                return NotFound(new { Message = "Not Found User"});
            return Ok(user);
        }
        [HttpPost ("Register")]
        public ActionResult RegisterUser(UserDTO userDTO)
        {
             return Ok();
        }
        [HttpPut("Users{id}")]
        public ActionResult EditUser(Guid id,[FromBody]UserDTO user)
        {
             _usersService.EditUser(id,user);
            return Ok();
            
        }
        [HttpDelete("Users{id}")]
        public ActionResult DeleteUser(Guid id)
        {
                return Ok();
            
        }
    }
}
