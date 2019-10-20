using System;

class Program
{
    static void Main()
    {
        // Assign "Dave" to str
        string firstName = "Dave";
        string lastName = "Smith";

        // Concatenate strings
        string fullName = firstName + " " + lastName;
        Console.WriteLine("fullName using concatenation: {0}", fullName);

        if (fullName.StartsWith("Dave"))
        {
            Console.WriteLine("Dave is present");
        }

        if (fullName.EndsWith("Smith"))
        {
            Console.WriteLine("Smith is present");
        }

        // Compare two strings
        if (fullName == "Dave Smith")
        {
            Console.WriteLine("Dave Smith is present");
        }

        // A different way to format a string using
        // a format like Console.WriteLine
        fullName = string.Format("{0} {1} is {2}", firstName, lastName, 23);
        Console.WriteLine("fullName using string.Format: {0}", fullName);

        Console.ReadLine();
    }
}