using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Interface
{
    public interface IUsersRepository
    {
        Users? GetById(Guid id);
        List<Users>? GetAll();
        void Register(Users users);
        void Edit(Users users);

        void Delete(Guid id);
    }
}
