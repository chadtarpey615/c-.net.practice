using System;

// name space
namespace NumberGuesser
{
// main class
    class Program
    {
        // entry point method
        static void Main(string[] args)
        {
        GetAppInfo(); // run get app function

        GreetUser() ; // ask user info

            while(true) {

     
            // create a new random object

            Random random = new Random();

// generates a random number
            int correctNumber = random.Next(1, 10);

            // init guess var
            int guess = 0;

            // ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            // while guess not correct
              while(guess != correctNumber) {
             // get user input
                  string input  = Console.ReadLine();

                  // make sure its a number

                  if (!int.TryParse(input, out guess)) {
              // print error message
              PrintColorMessage(ConsoleColor.Red, "Please use an actual number")
                  }

             // cast to int and put in guess variable
                 guess = Int32.Parse(input);

                 //match guess to correct number
                 if (guess != correctNumber) {
                       /// print error message
      
              PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");


            continue;

                 }
                        }

                        // output success message
                          /// change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info

              PrintColorMessage(ConsoleColor.Yellow, "Correct you guessed it !!!!");
           

            // ask to play again 
            Console.WriteLine("Play again? [Y or N]");

            // get answer
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y") {
                continue;
            } else if (answer == "N") {
                return ;
            } else {
                return;
            }

            }

        }

        static void GetAppInfo() {
                 string name = "Chad Tarpey";
            int age = 35;
            // start here //
            Console.WriteLine(name+ " is " + age);
            // o and 1 are placeholders for name age
            Console.WriteLine("{0} is {1}", name, age);
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chad Tarpey";


            /// change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

// reset text color to default white
            Console.ResetColor();
        }

        static void GreetUser() {
                        // ask user name
            Console.WriteLine("What is your name ?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // print volor message
        static void PrintColorMessage(ConsoleColor color, string message) {
                    Console.ForegroundColor = color;

            // tell user its the wrong number

            Console.WriteLine(message);

            // reset text color to default white
            Console.ResetColor();
        }
    }
}
