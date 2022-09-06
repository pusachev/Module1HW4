// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Module1HW4.Factory;

do
{
    Console.WriteLine("Please enter number of array size: ");

    string usrInput = Console.ReadLine() ?? " ";

    if (usrInput.Trim(' ').Length == 0)
    {
        Console.WriteLine("Error: Empty input");
        Console.WriteLine("Enter to continue\n");
        continue;
    }

    int arraySize = 0;
    char[] abcArray = new char[27];
    char[] toUpperChars = { 'a', 'e', 'i', 'd', 'h' };

    for (int i = 97; i < 123; i++)
    {
        int index = i - 96;
        abcArray[index] = Convert.ToChar(i);
    }

    try
    {
        arraySize = int.Parse(usrInput);
    }
    catch (FormatException)
    {
        Console.WriteLine("Plese enter valid number format");
        Console.WriteLine("Enter to continue\n");
        continue;
    }

    if (arraySize <= 0)
    {
        Console.WriteLine("Plese enter valid number format");
        Console.WriteLine("Enter to continue\n");
        continue;
    }

    int[] array = RandomArrayFactory.Create(arraySize);

    int[] even = new int[array.Length];
    int[] odd = new int[array.Length];

    int eventIndex = 0;
    int oddIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even[eventIndex++] = array[i];
        }
        else
        {
            odd[oddIndex++] = array[i];
        }
    }

    char[] oddChar = new char[odd.Length];
    char[] evenChar = new char[even.Length];

    int evenUpperCount = 0;
    int oddUpperCount = 0;

    if (even.Length > 0)
    {
        for (int i = 0; i < even.Length; i++)
        {
            if (even[i] == 0)
            {
                continue;
            }

            if (Array.Exists(toUpperChars, el => el == abcArray[even[i]]))
            {
                evenChar[i] = char.ToUpper(abcArray[even[i]]);
                evenUpperCount++;
            }
            else
            {
                evenChar[i] = abcArray[even[i]];
            }
        }
    }

    if (odd.Length > 0)
    {
        for (int i = 0; i < odd.Length; i++)
        {
            if (odd[i] == 0)
            {
                continue;
            }

            if (Array.Exists(toUpperChars, el => el == abcArray[odd[i]]))
            {
                oddChar[i] = char.ToUpper(abcArray[odd[i]]);
                oddUpperCount++;
            }
            else
            {
                oddChar[i] = abcArray[odd[i]];
            }
        }
    }

    if (evenUpperCount > oddUpperCount)
    {
        Console.WriteLine("Even array has more upper letters than odd array.");
    }
    else if (oddUpperCount > evenUpperCount)
    {
        Console.WriteLine("Odd array has more upper letters than even array.");
    }
    else
    {
        Console.WriteLine("Array are equal.");
    }

    Console.WriteLine("Even array: {0}", string.Join(" ", evenChar));
    Console.WriteLine("Odd array: {0}", string.Join(" ", oddChar));

    Console.WriteLine("Pres Esc to exit or Enter to contilue.");
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);
