using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.Write("What is your grade in CSE 210? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string Grade = "";

        if (percent >= 90)
        {
            Grade = "A";
        }
        else if (percent >= 80)
        {
            Grade = "B";
        }
        else if (percent >= 70)
        {
            Grade = "C";
        }
        else if (percent >= 60)
        {
            Grade = "D";
        }
        else
        {
            Grade = "F";
        }

        Console.WriteLine($"Your grade is: {Grade}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed CSE210!");
        }
        else
        {
            Console.WriteLine("You failed you will have to retake this next semester!");
        }
    }
}