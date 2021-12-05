using AspNetCoreRateLimit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddOptions();
builder.Services.AddMemoryCache();
builder.Services.Configure<IpRateLimitOptions>(builder.Configuration.GetSection("IpRateLimiting")); //appsettings.json name
builder.Services.Configure<IpRateLimitPolicy>(builder.Configuration.GetSection("IpRateLimitPolicies")); //appsettings.json name
builder.Services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
builder.Services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
//builder.Services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
//builder.Services.AddInMemoryRateLimiting();


// we will use MemoryCacheIpPolicyStore if we have only 1 server or docker app copy.If we have multiple server or docker app, We have to use DistributedCacheIpPolicyStore

//builder.Services.AddOptions().AddMemoryCache().Configure<IpRateLimitOptions>(builder.Configuration.GetSection("IpRateLimit"));


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

app.UseIpRateLimiting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
