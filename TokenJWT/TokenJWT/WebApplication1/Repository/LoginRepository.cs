using WebApplication1.Infra;
using WebApplication1.Models;
using WebApplication1.Repository.Interface;

namespace WebApplication1.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ConnectionContext _context;
        public LoginRepository(ConnectionContext context)
        {
            _context = context;
        }
        public Users? login(Users users)
        {
            
            return _context.users.Find(users.Email, users.Password, users.Tenent);
        }
    }
}
