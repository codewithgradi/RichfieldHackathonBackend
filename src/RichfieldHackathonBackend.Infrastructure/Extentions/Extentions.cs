using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.AI;
using OpenAI;
using System.ClientModel;
using RichfieldHackathonBackend.Infrastructure;
using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Application.Services;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Exceptions;
namespace simpli.Infrastructure;

public static class ServiceExtentions
{
    public static IServiceCollection ConfigureMcp(this IServiceCollection services)
    {
        services
        .AddMcpServer()
        .WithHttpTransport(opt =>
        {
            opt.Stateless = true;
        })
        .WithToolsFromAssembly();
        return services;
    }
   

    public static IServiceCollection ConfigureSqlDB(this IServiceCollection services, IConfiguration config)
    {
        var envType = config["OtherSettings:CurrentEnviroment"]?.ToLower().Trim(' ', '"');

        if (string.IsNullOrWhiteSpace(envType) || envType.Equals("placeholder", StringComparison.OrdinalIgnoreCase))
        {
            envType = "dev";
        }

        services.AddDbContext<AppDbContext>(opt =>
        {
            string? rawConnectionString = envType switch
            {
                "dev" => config["ConnectionStrings:DevDB"],
                "prod" => config["ConnectionStrings:ProdDB"],
                _ => throw new InvalidOperationException($"Invalid environment target '{envType}'.")
            };

            string? connectionString = rawConnectionString?.Trim(' ', '"', '\'');

            if (string.IsNullOrWhiteSpace(connectionString) ||
                connectionString.Equals("placeholder", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    $"The connection string for '{envType}' is missing or still set to 'placeholder'. " +
                    $"Checked key 'ConnectionStrings:{(envType == "dev" ? "DevDB" : "ProdDB")}'.");
            }

            opt.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        });

        return services;
    }
    public static IServiceCollection IdentityConfigurationsScope(this IServiceCollection services)
    {
        services.AddIdentityApiEndpoints<AppUser>(options =>
        {
            options.User.RequireUniqueEmail = true;
            options.SignIn.RequireConfirmedAccount = false;
        })
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();

        services.AddAuthorization();

        return services;
    }
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUserClaimsPrincipalFactory<AppUser>, AdditionalUserClaimsPrincipalFactory>();
        services.AddScoped<IAdminRepo, AdminRepo>();
        services.AddScoped<IAlumniRepo, AlumniRepo>();
        services.AddScoped<ICarrersRepo, CareersRepo>();
        services.AddScoped<ICertificationRepo, CertRepo>();
        services.AddScoped<IStudentRepo,StudentRepo>();
        services.AddScoped<ITaskRepo,TaskRepo>();
        services.AddScoped<ITaskSubRepo,TaskSubRepo>();

        services.AddScoped<AdminService>();
        services.AddScoped<AlumniService>();
        services.AddScoped<AnalyticsService>();
        services.AddScoped<CareerService>();
        services.AddScoped<CertificationService>();
        services.AddScoped<StudentService>();
        services.AddScoped<TaskService>();
        services.AddScoped<TaskSubService>();

        services.AddSingleton<AdminMappers>();
        services.AddSingleton<AlumniMappers>();
        services.AddSingleton<CertificationMappers>();
        services.AddSingleton<CareerMappers>();
        services.AddSingleton<StudentMappers>();


        return services;
    }
    public static IServiceCollection AddEnvironmentVariables(this IServiceCollection services)
    {
        DotNetEnv.Env.TraversePath().Load();

        return services;
    }
    public static IServiceCollection AllowCors(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy("AllowNextJs", builder =>
        {
              var frontendUrlDev = configuration["OtherSettings:FrontEndUrlDev"]?.ToLower().Trim(' ', '"');
              var frontendUrlProd = configuration["OtherSettings:FrontEndUrlProd"]?.ToLower().Trim(' ', '"');
              var backendLiveApiLink = configuration["OtherSettings:BackendLiveApiLink"]?.ToLower().Trim(' ', '"');

              if (string.IsNullOrEmpty(frontendUrlDev) || string.IsNullOrEmpty(frontendUrlProd) || string.IsNullOrEmpty(backendLiveApiLink))
              {
                  throw new ReasourceNotFoundException("There are no front-end urls.");
              }

              builder.WithOrigins([frontendUrlDev, frontendUrlProd, backendLiveApiLink])
          .AllowAnyMethod()
          .AllowAnyHeader()
          .AllowCredentials();
          });
        });

        return services;
    }
  
    public static IServiceCollection AddOpenAI(this IServiceCollection services, IConfiguration configuration)
    {
        string apiKey = configuration["OpenAi:ApiKey"]
            ?? throw new InvalidOperationException("Missing OpenAI api key in configuration.");

        // Retrieve OpenRouter URL from configuration (either top level or nested)
        string? openRouterUrl = configuration["OpenAi:OpenRouter"] ?? configuration["OpenRouter"];

        // Validate URI or fall back to standard OpenRouter base URL if missing or set to "Placeholder"
        if (string.IsNullOrWhiteSpace(openRouterUrl) ||
            openRouterUrl.Equals("Placeholder", StringComparison.OrdinalIgnoreCase) ||
            !Uri.TryCreate(openRouterUrl, UriKind.Absolute, out var openRouterUri))
        {
            openRouterUri = new Uri("https://openrouter.ai/api/v1");
        }

        var openAiOptions = new OpenAIClientOptions
        {
            Endpoint = openRouterUri
        };

        var openAiClient = new OpenAIClient(new ApiKeyCredential(apiKey), openAiOptions);

        IChatClient innerClient = openAiClient
            .GetChatClient("openrouter/free")
            .AsIChatClient();

        IChatClient chatClient = new ChatClientBuilder(innerClient)
            .UseFunctionInvocation()
            .Build();

        services.AddSingleton<IChatClient>(chatClient);

        return services;
    }
}