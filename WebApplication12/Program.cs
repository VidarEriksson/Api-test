global using FastEndpoints;
using Data;
using FastEndpoints.Swagger;
using Features.Account.Create;
using System.Reflection;




var builder = WebApplication.CreateBuilder();


builder.Services.AddFastEndpoints(options => options.Assemblies = [Assembly.GetAssembly(typeof(CreateAccountEndpoint))!]);
builder.Services.SwaggerDocument();
builder.Services.AddData(builder.Configuration);
//builder.Services.AddAuthorization();







var app = builder.Build();


app.UseHttpsRedirection();
app.UseFastEndpoints();

app.UseSwaggerGen();

app.Run();
 
