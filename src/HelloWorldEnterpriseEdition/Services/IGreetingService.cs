using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEnterpriseEdition.Services;

/// <summary>
/// Defines the contract for a greeting service
/// </summary>
public interface IGreetingService
{
    void Greet(string message);
}
