using ASP.NET_CORE_6_REST_API_Shop_Example.DBContext;
using ASP.NET_CORE_6_REST_API_Shop_Example.Interfaces;
using ASP.NET_CORE_6_REST_API_Shop_Example.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
builder.Services.AddDbContext<ShopDBContext>(options =>
        options.UseSqlServer(
        configuration.GetConnectionString("DefaultConnection"),
        ef => ef.MigrationsAssembly(typeof(ShopDBContext).Assembly.FullName)));
builder.Services.AddScoped<IShopDbContext>(provider => provider.GetService<ShopDBContext>());

builder.Services.AddTransient<IProductService, ProductService<ShopDBContext>>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();