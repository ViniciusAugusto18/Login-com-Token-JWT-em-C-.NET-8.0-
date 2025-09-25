using System.Collections.Generic;
using WebApplication1.Infra;
using WebApplication1.Models;
using System;
using WebApplication1.Repository.Interface;

namespace WebApplication1.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Delete(Guid id)
        {
            var user = _context.users.Find(id);
            if (user != null)
            {
                _context.users.Remove(user);
            }
        }

        public void Edit(Guid id,Users users)
        {
            var user = _context.users.Find(users.Id);
            if (user != null)
            {
                user.Name = users.Name;
                user.Email = users.Email;
                user.Password = users.Password;
                user.Tenent = users.Tenent;
                _context.users.Update(user);
            }
        }

        public List<Users>? GetAll()
        {
            return _context.users.ToList();
        }

        public Users? GetById(Guid id)
        {
            return _context.users.Find(id);
        }

        public void Register(Users users)
        {
            _context.users.Add(users);
        }
    }
}
