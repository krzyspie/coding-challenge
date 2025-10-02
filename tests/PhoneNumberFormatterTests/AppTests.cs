using PhoneNumberFormatter;

namespace PhoneNumberFormatterTests;

public class AppTests
{
    [Test]
    public void App_Run_ShouldReturnCorrectlyFormattedNumber()
    {
        // Arrange
        const string number = "98979695943";
        var app = new App();
        
        //Act
        var result = app.Run(number);
        
        //Assert
        Assert.That(result, Is.EqualTo("+9 (897) 969-5943"));
    }
    
    [TestCase("")]
    [TestCase("1234567891w")]
    [TestCase("4356")]
    public void App_Run_ShouldThrowException(string number)
    {
        // Arrange
        var app = new App();
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => app.Run(number));
    }
}