using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Shared;

namespace WebApplication1.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Users> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer($"Server={Config.Server};" +
               $"Database={Config.Database};" +
               "User Id=sa;" +
               "Password=4553;");
        
    }
}
