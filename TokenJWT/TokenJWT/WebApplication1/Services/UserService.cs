using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Repository.Interface;
using WebApplication1.Services.Interface;

namespace WebApplication1.Services
{
    public class UserService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void DeleteUser(Guid id)
        {
            _usersRepository.Delete(id);
        }

        public void EditUser(Guid id, UserDTO userDTO)
        {
            _usersRepository.Edit(id,new Users
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password,
                Tenent = userDTO.Tenent
            });
        }

        public List<UserDTO>? GetAllUsers()
        {
           var users = _usersRepository.GetAll();
            if (users == null || !users.Any())
            {
                return new List<UserDTO>();
            }
            var userDTOs = users.Select(user => new UserDTO
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Tenent = user.Tenent
            }).ToList();
            return userDTOs;
        }

        public UserDTO? GetUserById(Guid id)
        {
            var user = _usersRepository.GetById(id);
            if (user == null)
                return null;
            return new UserDTO
            {
                id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Tenent = user.Tenent
            };

        }

        public void RegisterUser(UserDTO userDTO)
        {
            _usersRepository.Register(new Users
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password,
                Tenent = userDTO.Tenent
            });
        }
    }
}
