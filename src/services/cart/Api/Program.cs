using DotMK.Cart.Application;
using DotMK.Cart.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.AddCartInfrastructure();

var app = builder.Build();
app.UseCartInfrastructure();
app.MapCartEnpoints();
app.Run();