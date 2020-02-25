using System;
using System.Diagnostics;           //essential for the Stopwatch method

namespace ProcedureVariant
{
    class Program
    {
        const string TooBig = "Your number is too big!";
        const string TooSmall = "Your number is to small!";
        const string BullsEye = "Congratulations! You entered a correct number."; //if user input == randomized number say that


        //main:
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the Guessing game!");
            int a = ReadNumber("Enter minimal scope: ");
            int b = ReadNumber("Enter maximal scope: ");
            int randomized = Randomize(a, b);

#if DEBUG//used only in DEBUG mode
            Console.WriteLine(randomized); //shows the score for the programmer
#endif       
            int counter = 0;
            var timer = new Stopwatch();   //checking how much time elapsed since using the Start function
            timer.Start();
            while (true)
            {
                counter++;
                int userNumber = ReadNumber("Enter a number or type 'x' + Enter to end the programme: ");
                string result = Judge(randomized, userNumber); //result of the Judge method stored in a string 
                Console.WriteLine(result);
                if (result == BullsEye)                                   
                    break; //break exits the loop                   
            }
            timer.Stop();
            Console.WriteLine($" Number of attempts: {counter}");
            Console.WriteLine($" Time of the game: {timer.Elapsed}");
            Console.WriteLine("Thanks for playing my game! Until next time.");
        }

        //methods:
        /// <summary>
        /// A function that randomizes the number that will be guessed
        /// </summary>
        /// <param name="min">minimal value to be randomized</param>
        /// <param name="max">maximal value to be randomized</param>
        /// <returns>a random number</returns>
        static int Randomize(int min = 1, int max = 100)
        {
            var min1 = Math.Min(min, max);
            var max1 = Math.Max(min, max);
            var rnd = new Random();
            var randomized = rnd.Next(min1, max1 + 1);  
            
            return randomized;
        }

        /// <summary>
        /// stores the number from the User and checks it for exeptions
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        static int ReadNumber(string prompt = "")    //added a prompt functionality
        {
            bool correct = false;
            int number = 0;

            do
            {
                Console.Write(prompt);
                string UserInput = Console.ReadLine();
                if (UserInput == "X" || UserInput == "x")
                    Environment.Exit(66);
                //int number = 0;           //this variable is local and exists until the end of the current block

                try                              //the compiler doesn't see variables inside a 'try' block
                {
                    number = int.Parse(UserInput);       //if the error (...) appears here:
                    correct = true;  //if try doesn't return an exeption, set the bool to true in order to break the loop
                }
                catch (FormatException)                  //do this for FormatExpetion
                {
                    Console.WriteLine("This is not a number. Please enter a number.");
                }
                catch (OverflowException)                //do this for FormatExpetion
                {
                    Console.WriteLine("The scope is exceeded. Enter a lower number.");
                }
                catch (Exception)                         //do this for Expetion (unknwn err)
                {
                    Console.WriteLine("Unknown error. Shutting down.");
                }

            }
            while (!correct);

            return number;      
        }

        /// <summary>
    /// this function judges Userinput
    /// </summary>
    /// <param name="rand"></param>
    /// <param name="Input"></param>
    /// <returns></returns>
        static string Judge(int rand, int Input) 
        {
            if( rand < Input)
            {
                return TooBig;
            }
            else if(rand > Input)
            {
                return TooSmall;
            }
            else
            {
                return BullsEye;       
            }
        }

        
    }
}
