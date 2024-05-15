global using FastEndpoints;

using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using WebApplication12.models;


var builder = WebApplication.CreateBuilder();


builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();
builder.Services.AddAuthorization();




var app = builder.Build();
app.UseFastEndpoints();

app.UseSwaggerGen();

app.Run();
 
