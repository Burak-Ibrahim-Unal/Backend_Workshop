using Microsoft.Extensions.Options;
using Products.Data;
using Products.Data.Interfaces;
using Products.Repositories;
using Products.Repositories.Interfaces;
using Products.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<ProductDatabaseSettings>(builder.Configuration.GetSection(nameof(ProductDatabaseSettings))); // get cache settings from appsettings.json
builder.Services.AddSingleton<IProductDatabaseSettings>(sp=>sp.GetRequiredService<IOptions<ProductDatabaseSettings>>().Value);

builder.Services.AddTransient<IProductContext,ProductContext>();
builder.Services.AddTransient<IProductRepository,ProductRepository>();
//builder.Services.AddTransient<IProductDatabaseSettings,ProductDatabaseSettings>();

//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
