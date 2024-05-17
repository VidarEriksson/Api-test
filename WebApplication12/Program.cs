global using FastEndpoints;

using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApplication12.models;


var builder = WebApplication.CreateBuilder();


builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();
//builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
    "server=localhost;port=3306;database=Athor;user=root;password=password;";
    //throw new ArgumentException("Connectionstring missing, paste in user secret");

builder.Services.AddDbContext<UserDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));






var app = builder.Build();


app.UseHttpsRedirection();
app.UseFastEndpoints();

app.UseSwaggerGen();

app.Run();
 
