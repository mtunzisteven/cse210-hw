using System;

class Program
{
    static void Main(string[] args)
    {

        /**
        
            Assignment:
                DisplayWelcome - Displays the message, "Welcome to the Program!"
                PromptUserName - Asks for and returns the user's name (as a string)
                PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
                SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
                DisplayResult - Accepts the user's name and the squared number and displays them.
                Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

        */

        welcomeFunction();

        string name = getNameFunction();
        int fav_num = getFavoriteNumberFunction();

        favNumberRooterFunction(name, fav_num);
    }

    static void welcomeFunction(){

        Console.WriteLine("Welcome to the program!");

    }

    static string getNameFunction(){

        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;

    }

    static int getFavoriteNumberFunction(){

        Console.WriteLine("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;

    }

    static void favNumberRooterFunction(string name, int favNumber){

            double sqrt_favNumber = Math.Sqrt(favNumber);

            Console.WriteLine($"{name}, the square of your number is {sqrt_favNumber:#.##}");

    }
}