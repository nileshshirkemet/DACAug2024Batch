
namespace DemoApp;

public class ShopWorker(IConfiguration config, ILogger<ShopWorker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int port = config.GetValue<int>("Listener:Port", 4002);
        logger.LogInformation("Starting shop server on TCP port {p}", port);
        await Task.CompletedTask;
    }
}