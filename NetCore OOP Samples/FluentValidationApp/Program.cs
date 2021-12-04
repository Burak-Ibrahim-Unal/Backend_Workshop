using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidationApp.FluentValidators;
using FluentValidationApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//There are 3 ways to implement Fluent Validation in Net Core 6

builder.Services.AddControllersWithViews().AddFluentValidation(options =>
{
    //Way1
    //options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());

    //Way2
    options.RegisterValidatorsFromAssemblyContaining<CustomerValidator>();
});

//Way3
//builder.Services.AddControllersWithViews().AddFluentValidation();
//builder.Services.AddTransient<IValidator<Customer>, CustomerValidator>();

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter= true;
});

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings"]);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
