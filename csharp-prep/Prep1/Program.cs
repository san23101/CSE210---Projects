using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the Programmer for their full name. 
        Console.Write("What is your first name? ");
        String first = Console.ReadLine();

        Console.Write("what is your Last namwe? ");
        String last = Console.ReadLine();

        Console.WriteLine($" Your name is {last}, {first} {last}");

    }
}