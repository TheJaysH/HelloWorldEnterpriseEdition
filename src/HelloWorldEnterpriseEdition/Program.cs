using Autofac;
using HelloWorldEnterpriseEdition.Controllers;
using HelloWorldEnterpriseEdition.Factories;
using HelloWorldEnterpriseEdition.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloWorldEnterpriseEdition;

internal class Program
{
    static void Main()
    {
        // Build configuration from appsettings.json
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        // Create a logger factory
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddConfiguration(config.GetSection("Logging"))
                .AddConsole();
        });

        // Register services with Autofac
        var builder = new ContainerBuilder();
        builder.RegisterInstance(loggerFactory).As<ILoggerFactory>();
        builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>));
        builder.RegisterType<ServiceFactory>().As<IServiceFactory>();
        builder.Register(c => c.Resolve<IServiceFactory>().CreateGreetingService()).As<IGreetingService>();
        builder.RegisterType<GreetingController>().As<IGreetingController>();
        var container = builder.Build();

        // Resolve the IGreetingController service and call ActionGreet
        using (var scope = container.BeginLifetimeScope())
        {
            var controller = scope.Resolve<IGreetingController>();
            controller.ActionGreet();
        }

        Console.ReadKey();
    }
}
