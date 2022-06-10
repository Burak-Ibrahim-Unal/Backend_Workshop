using Microsoft.Extensions.Options;
using Products.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<ProductsDatabaseSettings>(builder.Configuration.GetSection("ProductsDatabaseSettings")); // get cache settings from appsettings.json
builder.Services.AddSingleton<IProductsDatabaseSettings>(sp=>sp.GetRequiredService<IOptions<ProductsDatabaseSettings>>().Value);

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

app.UseAuthorization();

app.MapControllers();

app.Run();
