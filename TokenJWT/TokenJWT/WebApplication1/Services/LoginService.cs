using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Repository.Interface;
using WebApplication1.Services.Interface;

namespace WebApplication1.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public Token? Login(UserDTO user)
        {
            var userLogin = new Users
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Tenent = user.Tenent
            };
            var login = _loginRepository.login(userLogin);
            if (login == null)
                return null;

            return new Token
            {
                AccessToken = TokenService.CreateAccessToken(login),
                RefreshToken = RefreshTokenService.CreateRefreshToken(login)
            };
        }
    }
}
