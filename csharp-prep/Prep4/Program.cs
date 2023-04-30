using System;

class Program
{
    static void Main(string[] args)
    {
        /**
        
            Assignment
                Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.

                Once you have a list, have your program do the following:

            Core Requirements
                Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

                Compute the sum, or total, of the numbers in the list.

                Compute the average of the numbers in the list.

                Find the maximum, or largest, number in the list.

            Stretch Challenge
                Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).

                Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.

        */
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number;

        do{

            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);

        }
        while(number != 0);

        double average  = numbers.Average();
        double sum = numbers.Sum();
        double max = numbers.Max();

        List<int> pos_numbers = new List<int>();

        foreach( int num in numbers){

            if(num > 0){
                pos_numbers.Add(num);
            }
        }

        double pos_min = pos_numbers.Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {pos_min}");

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach( int num in numbers){

            if(num != 0){
                Console.WriteLine(num);
            }
        }

    }
}