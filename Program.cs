using System;

// Namespase
namespace NumberGuesser
{
    // Mail Class
    class Program
    {
        //Method
        static void Main(string[] args)
        {

            GetAppInfo(); //run GetAppInfo function to get info

            GreetUser();//greet user function

            while (true)
            {
                //init correct number
                // int correctNumber = 7;

                //Create a new random bject

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 0 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //its a number
                    if (!int.TryParse(input, out guess))
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going
                        continue;
                    }


                    //cast to int and put in guess

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }


                }



                //print error message
                PrintColorMessage(ConsoleColor.Yellow, "You are CURRECT!!!");

                // Ask use if they want to play again
                Console.WriteLine("Play Again? [Y or N]");

                //get answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") 
                {
                    return;
                }
                else
                {
                    return;
                }



            }


















        }

        static void GetAppInfo()
        {
            //app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Stefan Dzalev";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //print collor message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //write out app info
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
