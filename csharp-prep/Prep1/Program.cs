using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your first name?");      
        string fname = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {fname}, {lname} {fname}.");
    }
}