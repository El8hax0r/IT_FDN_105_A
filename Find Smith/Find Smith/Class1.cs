using System;

class Lastname
{
    static void Main()
    {
        Console.Write("Enter a person's full name:");
        string str = Console.ReadLine();

        if (str.Contains("Smith"))
        {
            Console.WriteLine("You found a Smith!");
        }
        else
        {
            Console.WriteLine("No Smith was found!");
        }

        Console.ReadLine();
    }
}