using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class RefreshTokenService
    {
        public static object CreateRefreshToken(Users user)
        {
            var key = Encoding.ASCII.GetBytes(Key.secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddDays(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return new { Token = tokenString };

        }
    }
}
