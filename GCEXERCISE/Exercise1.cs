using System;

namespace Inclasslabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Some Text");
            string text = Console.ReadLine();

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
/*
 * DescriptionPrompt the user to enter a string. After the user enters a string, 
 * output the same string back tothe console.
 * Example>>Enter some text: <<Hello, World! ECHOOOOOO!>>Hello, World! ECHOOOOOO!
 */
