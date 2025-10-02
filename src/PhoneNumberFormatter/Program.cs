// See https://aka.ms/new-console-template for more information

using PhoneNumberFormatter;

Console.WriteLine("Enter a string of a 11 digit number:");
var inputNumber = Console.ReadLine();

App app = new App();
app.Run(inputNumber);

Console.ReadKey();