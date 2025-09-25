using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repository.Interface
{
    public interface IUsersRepository
    {
        Users? GetById(Guid id);
        List<Users>? GetAll();
        void Register(Users users);
        void Edit(Guid id,Users users);

        void Delete(Guid id);
    }
}
