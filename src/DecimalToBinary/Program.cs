using System.Text;using DecimalToBinary;

Console.WriteLine("Decimal To Binary converter");

Console.WriteLine("Enter Decimal number: ");
var inputNumber = Console.ReadLine();

var app = new App();

var result = app.Run(inputNumber); 
Console.WriteLine(result);
Console.ReadKey();