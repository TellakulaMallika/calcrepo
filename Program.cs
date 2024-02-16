// See https://aka.ms/new-console-template for more information
using CalExample;
Calc calc = new Calc();
Console.WriteLine("Add Call");
calc.Add(12, 45);
Console.WriteLine("Multiply Call");
calc.Multi(10.5, 12.45);
Console.WriteLine("Division Call");
calc.Div(15, 5);
Console.WriteLine("Subtraction Call");
calc.Sub(10, 5);
Console.WriteLine("Average Call");
calc.Avg(13.5, 35.5);