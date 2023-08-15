using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HelloWorldEnterpriseEdition.Services;

public class ConsoleGreetingService : IGreetingService
{
    private readonly IMessageWriter _messageWriter;
    private readonly ILogger<ConsoleGreetingService> _logger;

    public ConsoleGreetingService(IMessageWriter messageWriter, ILogger<ConsoleGreetingService> logger)
    {
        _messageWriter = messageWriter;
        _logger = logger;
    }

    public void Greet(string message)
    {
        _logger.LogInformation("Sending greeting: {Message}", message);
        _messageWriter.Write(message);
    }
}
