using HexToDecimal;

Console.WriteLine("Input hex number:");
var hexNumber = Console.ReadLine();

var app = new App();
var result = app.Run(hexNumber);

Console.WriteLine(result);