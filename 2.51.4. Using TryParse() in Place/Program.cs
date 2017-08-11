﻿class MainClass
{
    static void Main()
    {
        double number;
        string input;

        System.Console.Write("Enter a number: ");
        input = System.Console.ReadLine();
        if (double.TryParse(input, out number))
        {
            // Converted correctly, now use number
        }
        else
        {
            System.Console.WriteLine("The text entered was not a valid number.");
        }
    }
}