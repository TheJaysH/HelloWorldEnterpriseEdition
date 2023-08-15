using HelloWorldEnterpriseEdition.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEnterpriseEdition.Factories
{
    /// <summary>
    /// Defines the contract for a service factory
    /// </summary>
    public interface IServiceFactory
    {
        IGreetingService CreateGreetingService();
        IMessageWriter CreateMessageWriter();
    }
}
