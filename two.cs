using System;

namespace ConsoleApplication1
{
    class Program
    {
    static void Main(string[] args)
    {
        //variables need to know type
        //you can also say private string firstName...
        string firstName = "Stevie";
        string lastName = "Wonder";

        Console.WriteLine("Name: " + firstName + " " + lastName);

        Console.WriteLine("Please enter a new first name.");
        firstName = Console.ReadLine();

        Console.WriteLine("New name: " + firstName + " " + lastName);

        Console.ReadLine();

        //and here are some int things
        int number1, number2;

        Console.WriteLine("Enter a number:");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Another number, please:");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Adding your numbers: " + (number1 + number2));

        Console.ReadLine();
    }
    }
}