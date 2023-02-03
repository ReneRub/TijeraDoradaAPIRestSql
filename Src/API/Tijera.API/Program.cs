using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TD.Core.Abstraction.Services;
using TD.Core.Services;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;
using TD.Infrastructure.Repositories;
using Tijera.API.Extensios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<AppDbContext>();

//var connectionString = builder.Configuration.GetConnectionString("PostgreSqlconnection");

builder.Services.AddDbContext<TIJERADORADAContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection")));
builder.Services.AddMemoryCache();

//builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddBusinessServices();
builder.Services.AddRepositories();
builder.Services.AddCustomAutoMapper();
builder.Services.AddApiVersioning();
builder.Services.AddCustomBuilders();

//BearerToken
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
        };
    });

builder.Services.AddCustomApiVersioning();



var app = builder.Build();

//var loggerFactory = app.Services.GetService<ILoggerFactory>();
//loggerFactory.AddFile(builder.Configuration["Logging:LogFilePath"].ToString());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseApiVersioning();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
