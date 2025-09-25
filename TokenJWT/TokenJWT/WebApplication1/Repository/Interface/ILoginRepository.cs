using WebApplication1.Models;

namespace WebApplication1.Repository.Interface
{
    public interface ILoginRepository
    {
        Users? login(Users users);
    }
}
