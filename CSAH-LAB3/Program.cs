using System;

namespace CSAH_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool repeat = true;

            Console.WriteLine("Hello human, give me your name.");
            string userInput = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Oh...that's uh, interesting for a human...ehem.");

            do
            {
                
                Console.WriteLine("Anyways " + userInput + "! Choose a number between 1 and 100.");

                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("You picked " + userNumber + "? I do believe that's even my " +
                        "good lad.");
                }
                else
                {
                    Console.WriteLine(userNumber + " just so happens to be an odd number, it suits you " + userInput);
                }

                if (userNumber < 25)
                {
                    Console.Write(" it's also under 25. ");
                    Console.WriteLine();
                }
               
                Console.WriteLine("Would you like to try again " + userInput + "?");

                string response = Console.ReadLine().ToLower().Trim();

                if (response == "no")
                {
                    repeat = false;
                    Console.WriteLine("Good Bye!");
                }
                else
                {
                    repeat = true;
                }
            }
            while (repeat == true);

        }
    }
}
