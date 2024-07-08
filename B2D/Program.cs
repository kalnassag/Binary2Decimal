using System;
using static System.Console;

WriteLine("Enter the binary number: ");
string input = ReadLine() ?? "";
double result = 0;
int counter = input.Length - 1;
foreach (char letter in input)
{
    WriteLine($"Counter value is: {counter}");
    if (letter != '0' && letter != '1')
    {
        WriteLine("This is not a valid binary number");
        break;
    }
    else if (input.Length > 8)
    {
        WriteLine("We can only accept 8 digit binary numbers");
        break;
    }
    else
    {
        if (letter == '1')
            result += Math.Pow(2, counter);
        counter--;
    }
}

WriteLine(result);
