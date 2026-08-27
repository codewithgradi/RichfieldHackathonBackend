using Microsoft.EntityFrameworkCore;
using RichfieldHackathonBackend.Api.Middleware;
using RichfieldHackathonBackend.Infrastructure;

var envPath = Path.Combine(Directory.GetCurrentDirectory(), "../.env");
if (File.Exists(envPath))
{
    DotNetEnv.Env.Load(envPath);
}
else
{
    DotNetEnv.Env.Load();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddOpenApi();
builder.Services.AddTransient<GlobalExceptionMiddleware>();
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
});

builder.Services.LoadAddEnvironmentVariables()
    .ConfigureSqlDB(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration)
    .IdentityConfigurationsScope()
    .AllowCors(builder.Configuration)
    .ConfigureMcp()
    .AddOpenAI(builder.Configuration);

builder.Services.AddScoped<AdminMcpTools>();
builder.Services.AddScoped<AluminiMcpTool>();
builder.Services.AddScoped<StudentMcpStudent>();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors("AllowNextJs");
app.UseMiddleware<GlobalExceptionMiddleware>();
app.UseAuthentication();

app.UseAuthorization();
app.MapControllers();
app.MapIdentityApi<AppUser>();
app.MapMcp("/mcp");
using var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
Console.WriteLine($"==> CONNECTED DB: {dbContext.Database.GetDbConnection().ConnectionString}");
app.Run();

app.Run();

