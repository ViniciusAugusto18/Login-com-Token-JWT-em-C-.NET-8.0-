using WebApplication1.DTOs;

namespace WebApplication1.Services.Interface
{
    public interface IUsersService
    {
        List<UserDTO>? GetAllUsers();
        UserDTO? GetUserById(Guid id);

        void RegisterUser(UserDTO userDTO);

        void EditUser(Guid id, UserDTO userDTO);

        void DeleteUser(Guid id);

    }
}
