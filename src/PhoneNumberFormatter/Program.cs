using PhoneNumberFormatter;

Console.WriteLine("Enter a string of a 11 digit number:");
var inputNumber = Console.ReadLine();

App app = new App();
var result = app.Run(inputNumber);
Console.WriteLine($"Formatted phone number is: {result}");

Console.ReadKey();