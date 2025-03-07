﻿using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter a character to replace: ");
            char charToReplace = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (inputString != null)
            {
                string resultString = inputString.Replace(charToReplace, 'x');
                Console.WriteLine("Modified string: " + resultString);
            }
        }
    }
}
