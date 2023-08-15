namespace HelloWorldEnterpriseEdition.Tests;

public class ConsoleGreetingServiceTests
{
    [Fact]
    public void Greet_CallsWriteOnMessageWriter()
    {
        // Arrange
        var mockMessageWriter = new Mock<IMessageWriter>();
        var mockLogger = new Mock<ILogger<ConsoleGreetingService>>();
        var service = new ConsoleGreetingService(mockMessageWriter.Object, mockLogger.Object);

        // Act
        service.Greet("Hello, Test!");

        // Assert
        mockMessageWriter.Verify(w => w.Write("Hello, Test!"), Times.Once);
    }   
}
