using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using MicroserviceBaseApp.Products.Data;
using MicroserviceBaseApp.Products.Data.Interfaces;
using MicroserviceBaseApp.Products.Repositories;
using MicroserviceBaseApp.Products.Repositories.Interfaces;
using MicroserviceBaseApp.Products.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


#region Copnfiguration Dependencies
builder.Services.Configure<ProductDatabaseSettings>(builder.Configuration.GetSection(nameof(ProductDatabaseSettings))); // get cache settings from appsettings.json
builder.Services.AddSingleton<IProductDatabaseSettings>(sp => sp.GetRequiredService<IOptions<ProductDatabaseSettings>>().Value);
#endregion

#region Product Dependencies
builder.Services.AddTransient<IProductContext, ProductContext>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
#endregion

// builder.Services.AddEndpointsApiExplorer();

#region Swagger Dependencies
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1.0.0", new OpenApiInfo
    {
        Title = "Products",
        Version = "v1.0.0"
    });
});
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1.0.0/swagger.json", "Products v1.0.0"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
