using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Services.Interface
{
    public interface ILoginService
    {
        Token? Login(UserDTO user);
    }
}
