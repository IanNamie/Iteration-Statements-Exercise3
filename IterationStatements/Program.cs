using System.Diagnostics.CodeAnalysis;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("NumberIndex");
            NumberIndex();
            Console.WriteLine("ByThree");
            ByThrees();
            Console.WriteLine($"NumChecker");
            NumChecker();
            Console.WriteLine($"EvenOrOddChecker");
            EvenOrOddChecker();
            Console.WriteLine($"PosOrNegChecker");
            PosOrNegChecker();
            Console.WriteLine($"");
        }
        public static void NumberIndex()
        {
            for (int numberIndex = 1000; numberIndex >= -1000; numberIndex--)
            {
                Console.WriteLine(numberIndex);
            }
        }
        public static void ByThrees()
        {
            for (var byThree = 0; byThree <= 999; byThree += 3)
            {
                Console.WriteLine(byThree);
            }

        }
        public static void NumChecker()
        {
            Console.WriteLine(" were gonna see if some numbers are the same! What is your first number?");
            var user1stImput = Console.ReadLine();
            Console.WriteLine("What is your second number?");
            var user2stImput = Console.ReadLine();
            if (user1stImput != user2stImput)
            {
                Console.WriteLine("Nice try those are not the same!");
            }
            else
            {
                Console.WriteLine(" Nice Job! they are the same!");
            }

        }
        public static void EvenOrOddChecker()
        {
            Console.WriteLine($"what is the first number you would like to enter?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"what is the second number you would like to enter?");
            var num2 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"Your first number is a postive number!");
            }
            else
            {
                Console.WriteLine($"Your first number is a odd number!");
            }
            if (num2 % 2== 0)
            {
                Console.WriteLine($"Your second number is even!");
            }
            else
            {
                Console.WriteLine($"Your second number is odd!");

            }
        }
        public static void PosOrNegChecker()
        {
            Console.WriteLine($"We are going to check if a number is Negative or positive. What number would you like to try?");
            var posOrNegNum = int.Parse(Console.ReadLine());
            if (posOrNegNum < 0)
            { Console.WriteLine($"that would be a negative number! Nice job!");
            }
            else 
            { 
                Console.WriteLine($"that woudl be a postive number! Great Job");
            }
        }
    }
}
