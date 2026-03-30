// See https://aka.ms/new-console-template for more information
using SampleApp;

Console.WriteLine("Hello, World!");

var calculator = new Calculator();
Console.WriteLine($"2 + 3 = {calculator.Add(2, 3)}");
Console.WriteLine($"10 - 4 = {calculator.Subtract(10, 4)}");
Console.WriteLine($"3 * 7 = {calculator.Multiply(3, 7)}");
Console.WriteLine($"15 / 4 = {calculator.Divide(15, 4)}");
