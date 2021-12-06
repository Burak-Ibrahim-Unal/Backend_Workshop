using Smidge;
using Smidge.Cache;
using Smidge.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSmidge(builder.Configuration.GetSection("smidge"));
// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseSmidge(bundle =>
{
    bundle.CreateJs("AllJsFiles", "~/js/").WithEnvironmentOptions(BundleEnvironmentOptions.Create().ForDebug(builder =>
        builder.EnableCompositeProcessing().EnableFileWatcher()
        .SetCacheBusterType<AppDomainLifetimeCacheBuster>()
        .CacheControlOptions(enableEtag: false, cacheControlMaxAge: 0)).Build()); // we can type folder location only
    bundle.CreateCss("AllCssFiles", "~/css/site.css", "~/lib/bootstrap/dist/css/bootstrap.css"); // Or we can type one by one

});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
