using System;

class Program
{
    static void Main(string[] args)
    {
        /**
        
            Assignment
                Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because many people benefit from seeing the program built up step by step.

            Core Requirements
                Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)

                Ask the user for a guess.

                Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.

                At this point, you won't have any loops.


                Add a loop that keeps looping as long as the guess does not match the magic number.

                At this point, the user should be able to keep playing until they get the correct answer.


                Instead of having the user supply the magic number, generate a random number from 1 to 100.

                Play the game and make sure it works!

            Stretch Challenge
                Keep track of how many guesses the user has made and inform them of it at the end of the game.

                After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
        */

        string replay;

        do{

            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 101);

            int guess = magic_number-1;
            int guesses = 0;

            while(magic_number != guess){

                
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());

                if(magic_number > guess){

                    Console.WriteLine("Higher");

                }else if(magic_number < guess){

                    Console.WriteLine("Lower");

                }

                guesses ++;
            }
            
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You used {guesses} guesses.\n");

            Console.WriteLine("Do you want to play again?(yes/no)");
            replay = Console.ReadLine();

        }while(replay == "yes");

    }
}