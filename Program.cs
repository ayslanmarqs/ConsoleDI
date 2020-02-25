using ConsoleDI.Controllers;
using ConsoleDI.Presenters;
using ConsoleDI.UseCases;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddScoped<IPresenter, ConsolePresenter>()
                .AddScoped<IController, ConsoleController>()
                .AddScoped<IUseCase, SumUseCase>()
                .BuildServiceProvider();

            serviceProvider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");
            var controller = serviceProvider.GetService<IController>();
            controller.Run();
            logger.LogDebug("All done!");
        }
    }
}
