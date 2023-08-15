using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEnterpriseEdition.Services;

/// <summary>
/// Defines the contract for a message writer
/// </summary>
public interface IMessageWriter
{
    void Write(string message);
}
