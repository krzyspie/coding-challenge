using DecimalToBinary;

namespace DecimalToBinaryTests;

public class AppTests
{
    [TestCase("3", "11")]
    [TestCase("15", "1111")]
    [TestCase("63", "111111")]
    [TestCase("64", "1000000")]
    [TestCase("127", "1111111")]
    [TestCase("", "")]
    public void App_Run_ShouldReturnBinaryRepresentation(string number, string expected)
    {
        // Arrange
        var app = new App();
        
        // Act
        var result = app.Run(number);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [TestCase("-127")]
    [TestCase("232www")]
    public void App_Run_ShouldReturnException(string number)
    {
        // Arrange
        var app = new App();
        
        // Act&Assert
        Assert.Throws<FormatException>(() => app.Run(number));
    }
}