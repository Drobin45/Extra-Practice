using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //First six exercises are operator exercises from my cohort's operator homework list.
            //Exercise one. Create a program that has the user type two intergers. 
            //Determine if those intergers are equal or inequal, then have the program inform the use if the intergeres are equal or not.
            //Complete!

            //Console.WriteLine("Type out an interger");
            //int intOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Type out another interger. This interger can be the same as the first, or it may be a separate interger.");
            //int intTwo = int.Parse(Console.ReadLine());

            //if (intOne == intTwo)
            //{
            //    Console.WriteLine("Those intergers are equal to one another!");
            //}
            //else
            //{
            //    Console.WriteLine("Those intergers aren't equal to one another!");
            //}

            //-------------------------------------------------------------------------------

            //Exercise two. Design app that asks for the user to input a number. Have app tell the user if that number is even or odd
            //Exercise Complete!
            //Console.WriteLine("Please input any interger");
            //int number =int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //-------------------------------------------------------------------------------

            //Exersice three. Create a program that asks the user to input a positive or negative interger.
            // Make the program accurately tell the user if the interger they entered is positive or negative.
            //Complete!

            //Console.WriteLine("Write a positive or negative interger!");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 0)
            //{
            //    Console.WriteLine("That is a positive number!");
            //}

            //else
            //{
            //    Console.WriteLine("That is a negative number!");
            //}

            //-------------------------------------------------------------------------------

            //Homework exercise four
            // Allow the user to type a single alphebetical character. 
            // Make the program accurately tell the user if the character is a vowel or consenant.
            //Complete!

            //Console.WriteLine("Type a single alphabetical character");
            //char letter = char.Parse(Console.ReadLine());
            //switch (letter)
            //{
            //    case 'a':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'e':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'i':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'o':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'u':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'y':
            //        Console.WriteLine("That is (sometimes?) a vowel!");
            //        break;

            //    default:
            //        Console.WriteLine("That is a consenant!");
            //        break;
            //}

            //-------------------------------------------------------------------------------

            //Exercise five. Design app to ask the user for three separate intergers. 
            // Have program recognize which of the three is the greatest interger.
            //Exercise complete!

            //Console.WriteLine("Enter three intergers");
            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());
            //int thirdNumber = int.Parse(Console.ReadLine());

            //if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            //{
            //    Console.WriteLine(firstNumber + " is the greates interger!");
            //}
            //else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            //{
            //    Console.WriteLine(secondNumber + " is the greatest interger!");
            //}
            //else
            //{
            //    Console.WriteLine(thirdNumber + " is the greatest interger!");
            //}

            //-------------------------------------------------------------------------------

            //Exercise six.Write a Console application that asks the user for 4 integers.
            //Calculate the mean for these 4 numbers and display the result.
            //Exercise complete!

            //Console.WriteLine("Please write in four separate intergers");
            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());
            //int thirdNumber = int.Parse(Console.ReadLine());
            //int fourthNumber = int.Parse(Console.ReadLine());

            //double preMean = (firstNumber + secondNumber + thirdNumber + fourthNumber);
            //double mean = (preMean / 4);

            //Console.WriteLine(mean);

            //-------------------------------------------------------------------------------

            //This practice is from C# Players Guide page 72
            // Objective: Create an app that acts as a calculator for users
            // Have them input two intergers, and allow them to input the following math operators: +, -, *, / & %
            // Run a switchcase that takes thier two intergers and the operator they have chosen and calculate them.
            // Present answer to the user.
            // Exercise complete!

            //Console.WriteLine("Welcome to the handy-dandy C# calculator! /nPlease input your first interger");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please input your second interger");
            //int secondNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please input the operator you wish to be used on the two intergers");
            //string math = Console.ReadLine();
            //int calc;

            //switch (math)
            //{
            //    case "+":
            //        calc = (firstNumber + secondNumber);
            //        Console.WriteLine("Answer =" + calc);
            //        break;
            //    case "-":
            //        calc = (firstNumber - secondNumber);
            //        Console.WriteLine("Answer =" + calc);
            //        break;
            //    case "*":
            //        calc = (firstNumber * secondNumber);
            //        Console.WriteLine("Answer =" + calc);
            //        break;
            //    case "/":
            //        calc = (firstNumber / secondNumber);
            //        Console.WriteLine("Answer =" + calc);
            //        break;
            //    case "%":
            //        calc = (firstNumber % secondNumber);
            //        Console.WriteLine("Answer =" + calc);
            //        break;
            //}

            //-------------------------------------------------------------------------------

            // "Loop" practice, page 73, example
            // Placing CW before a++ allows program to write each loop number
            // Taking away a++ creates infinite loop!

            //int a = 1;           
            //while (a<= 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}

            // "Loop" practice, page 74
            // Why can't I simply write "int score = int.Parse(Console.ReadLine());" instead of doing that 
            // weird string/int convert that the book does.... I don't fully understand this

            //int score = -1;
            //while (score <=0 || score <=10)
            //{
            //    string response = Console.ReadLine();
            //    score = Convert.ToInt32(response);
            //}

            // "Do-While Loop" practice, pag 75 typical loops occur if certainl conditions are met
            // The Do-While Loop occurs at least once, and loops if conditions (while operator) are met

            //int score;
            //do
            //{
            //    string response = Console.ReadLine();
            //    score = Convert.ToInt32(response);
            //}
            //while (score <= 0 || score <= 10);

            // "For-Loop" My favorite loop. Has three items in intialization text; 
            // initial condition (what makes this loop occur once), Condition to check (condition that restarts the loop), and
            // the action at the end of the loop (what occurs each loop around)
            // While this example is identical to how they wrote it in the book, it is inoperable
            // Need to initialize x within {}, but this instructs program to skip the loop after initialization....
            // Exercise INcomplete! Return later after class
            
            //for(int x =1; x <= 10; x++);
            //{                
            //    Console.Write(x);
            //}

            //--------------------------------------------------------------------------------


        }
    }
}
