using WebApplication1.Models;

namespace WebApplication1.Interface
{
    public interface ILoginRepository
    {
        Users? login(Users users);
    }
}
