// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Module1HW4.Factory;

do
{
    Console.WriteLine("Hello usser");
    Console.WriteLine("Please enter number of array size: ");

    string usrInput = Console.ReadLine() ?? " ";

    if (usrInput.Trim(' ').Length == 0)
    {
        Console.WriteLine("Error: Empty input");
        continue;
    }

    int arraySize = 0;

    try
    {
        arraySize = int.Parse(usrInput);
    }
    catch (FormatException)
    {
        Console.WriteLine("Plese enter valid number format");
        continue;
    }

    int[] array = RandomArrayFactory.Create(arraySize);

    Console.WriteLine("Pres Esc to exit or Enter to contilue.");
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);
