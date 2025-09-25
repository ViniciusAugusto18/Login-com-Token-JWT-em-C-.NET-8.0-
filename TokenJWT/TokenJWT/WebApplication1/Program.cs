using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Infra;
using WebApplication1.Repository;
using WebApplication1.Repository.Interface;
using WebApplication1.Services;
using WebApplication1.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionContext.defaultconfig)));

#region  Login 
builder.Services.AddTransient<ILoginRepository, LoginRepository>();
builder.Services.AddTransient<ILoginService, LoginService>();
#endregion

#region Users
builder.Services.AddTransient<IUsersService, UserService>();
builder.Services.AddTransient<IUsersRepository, UsersRepository>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
