using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using WebApplication1.Models;
using WebApplication1.Shared;

namespace WebApplication1.Infra
{
    public class ConnectionContext : DbContext
    {
        public static string defaultconfig = $"Server={Config.Server};" +
               $"Database={Config.Database};" +
               "User Id=sa;" +
               "Password=4553;";
        public ConnectionContext(DbContextOptions<ConnectionContext> options)
        : base(options) 
        { }
        
        public DbSet<Users> users { get; set; }


        
    }
}
