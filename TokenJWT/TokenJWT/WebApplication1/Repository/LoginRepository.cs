using WebApplication1.Infra;
using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public Users? login(Users users)
        {
            
            return _context.users.Find(users.Email, users.Password, users.Tenent);
        }
    }
}
