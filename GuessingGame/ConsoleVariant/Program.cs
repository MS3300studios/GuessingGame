using System;

namespace ConsoleVariant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the Guessing game!");

            // 1. computer randomizes a number
            #region randomizing
            var random = new Random(); //creating random type object 
            int randomized = random.Next(1, 101);
#if DEBUG//used only in DEBUG mode
            Console.WriteLine(randomized);
#endif
            Console.WriteLine("I randomized a number from 1 to 100.\nTry to guess it!");
            #endregion

            int counter = 1; //attempt counter
            bool isGuessed = false;

            while (!isGuessed) //until isGuessed not false
            { 
                // 2. user suggests a number
                Console.Write("Enter a number: ");
                int userNumber = int.Parse(Console.ReadLine()); //read a number from user and Parse it into a int type

                // 3. computer analyzes the number
                if (userNumber < randomized)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number is too small!");
                    Console.ResetColor();
                }
                else if (userNumber > randomized)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number is too big!");
                    Console.ResetColor();
                }
                else if (userNumber == randomized)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! You have guessed correctly!");
                    Console.WriteLine($"You guessed on attempt number: {counter}");
                    Console.ResetColor();
                    isGuessed = true;
                }
                else
                {
                    Console.WriteLine("That is not a number, try again.");
                }

                counter++;
            }
        }
    }
}
