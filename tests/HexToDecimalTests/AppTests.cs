using HexToDecimal;

namespace HexToDecimalTests;

public class AppTests
{
    [TestCase("FFFF", 65535)]
    [TestCase("A7", 167)]
    public void App_Run_ShouldReturnDecimalValue(string number, double expected)
    {
        // Arrange
        var app = new App();
        
        // Act
        var result = app.Run(number);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [TestCase("ZZ")]
    [TestCase("18W")]
    public void App_Run_ShouldThrowFormatException(string number)
    {
        // Arrange
        var app = new App();
        
        // Act&Assert
        Assert.Throws<FormatException>(() => app.Run(number));
    }
    
    [Test]
    public void App_Run_ShouldThrowArgumentException()
    {
        // Arrange
        var app = new App();
        
        // Act&Assert
        Assert.Throws<ArgumentNullException>(() => app.Run(""));
    }
}