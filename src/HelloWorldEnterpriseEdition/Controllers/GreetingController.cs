using HelloWorldEnterpriseEdition.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEnterpriseEdition.Controllers
{
    /// <summary>
    /// Implementation of IGreetingController that uses a greeting service to send a greeting
    /// </summary>
    public class GreetingController : IGreetingController
    {
        private readonly IGreetingService _greetingService;
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(IGreetingService greetingService, ILogger<GreetingController> logger)
        {
            _greetingService = greetingService;
            _logger = logger;
        }

        public void ActionGreet()
        {
            try
            {
                _greetingService.Greet("Hello, World!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sending greeting.");
            }
        }
    }
}
