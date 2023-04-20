using System;

class Program
{
    static void Main(string[] args)
    {
        /**
        Ask the user for their grade percentage, then write a series of 
        if-elif-else statements to print out the appropriate letter grade. 
        (At this point, you'll have a separate print statement for each 
        grade letter in the appropriate block.)

        Assume that you must have at least a 70 to pass the class. 
        After determining the letter grade and printing it out. 
        Add a separate if statement to determine if the user passed 
        the course, and if so display a message to congratulate them. 
        If not, display a different message to encourage them for 
        next time.

        Change your code from the first part, so that instead of 
        printing the letter grade in the body of each if, elif, or 
        else block, instead create a new variable called letter and 
        then in each block, set this variable to the appropriate value. 
        Finally, after the whole series of if-elif-else statements, 
        have a single print statement that prints the letter grade once.
        */

        Console.WriteLine("Enter your grade percentage");
        string grade_letter = Console.ReadLine();
        int grade = int.Parse(grade_letter);
        string letter = "";
        string sign = "";

        if(grade >= 90){
            letter = "A";
        }else if(grade >= 80 && grade < 90){
            letter = "B";
        }else if(grade >= 70 && grade < 80){
            letter = "C";
        }else if(grade >= 60 && grade < 70){
            letter = "D";
        }else{
            letter = "F";
        }

        string grade_dec_unit = grade_letter[1].ToString();

        if(grade > 50){
            
            if(int.Parse(grade_dec_unit) >= 7){
                sign = "+";
            }
            
            if(int.Parse(grade_dec_unit) < 3){
                sign = "-";
            }

        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if(grade >= 70){
            Console.WriteLine("Congratulations! You passed the class!");
        }else{
            Console.WriteLine("You did not pass, all the best on your next attempt.");
        }
    }
}