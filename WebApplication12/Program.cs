global using FastEndpoints;
using Data;
using FastEndpoints.Swagger;
using Features.Account.Create;
using System.Reflection;




var builder = WebApplication.CreateBuilder();

//gets the endpoint info
builder.Services.AddFastEndpoints(options => options.Assemblies = [Assembly.GetAssembly(typeof(CreateAccountEndpoint))!]);
builder.Services.SwaggerDocument();
//get from dataExtensions 
builder.Services.AddData(builder.Configuration);
//builder.Services.AddAuthorization();







var app = builder.Build();


app.UseHttpsRedirection();
app.UseFastEndpoints();

app.UseSwaggerGen();

app.Run();
 
