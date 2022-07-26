﻿Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;


Console.WriteLine("---------------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("---------------------------------------------");

var gameSelected = Console.ReadLine();

//edit multiple
if (gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("Subtraction selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplication selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("Division selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
} else
{
    Console.WriteLine("Invalid input");
}