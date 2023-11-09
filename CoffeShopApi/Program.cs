using Domain;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CoffeShopDbContext>(
        options => options.UseNpgsql("Server=localhost;Database=coffeeshopdb;Port=5432;User Id=postgres;Password=postgres"));

//builder.Services.AddDbContext<CoffeShopDbContext>(o => o.UseNpgsql("Server=localhost;Database=coffeshopdb;Port=5432;User Id=postgres;Password=postgres"));//builder.Configuration.GetConnectionString("CoffeShopDb")
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IDisplayMenuService, DisplayMenuService>();

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
