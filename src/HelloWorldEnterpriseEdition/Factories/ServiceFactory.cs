using HelloWorldEnterpriseEdition.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEnterpriseEdition.Factories
{
    /// <summary>
    /// Implementation of IServiceFactory that creates instances of ConsoleGreetingService and ConsoleMessageWriter
    /// </summary>
    public class ServiceFactory : IServiceFactory
    {
        private readonly ILoggerFactory _loggerFactory;

        public ServiceFactory(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public IGreetingService CreateGreetingService()
        {
            return new ConsoleGreetingService(CreateMessageWriter(), _loggerFactory.CreateLogger<ConsoleGreetingService>());
        }

        public IMessageWriter CreateMessageWriter()
        {
            return new ConsoleMessageWriter();
        }
    }
}
