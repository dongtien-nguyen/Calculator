using CalculatorLibrary;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
var num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your result: {num1} + {num2} = " + (Calculator.DoSum(num1, num2)));

// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();