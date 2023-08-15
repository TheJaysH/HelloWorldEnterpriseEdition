namespace HelloWorldEnterpriseEdition.Tests;

public class GreetingControllerTests
{
    [Fact]
    public void ActionGreet_CallsGreetOnGreetingService()
    {
        // Arrange
        var mockGreetingService = new Mock<IGreetingService>();
        var mockLogger = new Mock<ILogger<GreetingController>>();
        var controller = new GreetingController(mockGreetingService.Object, mockLogger.Object);

        // Act
        controller.ActionGreet();

        // Assert
        mockGreetingService.Verify(s => s.Greet("Hello, World!"), Times.Once);
    }
}