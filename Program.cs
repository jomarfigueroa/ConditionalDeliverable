using System;

namespace ConditionalDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the beginning of the program, prompting the user to enter an integer value.
            Console.WriteLine("What grade do you expect to get in ISM 4300? Enter a number percentage from 0 to 100.");

            try // The try catch is to save the program in the case of an error, being caused by the user typing in something other than what is permitted.
            {
                // This is going to read what the person types into the console
                string input = Console.ReadLine();
                int percent = int.Parse(input);
                //these are the conditional statements for the grades starting at A+
                if ((percent >= 98) && (percent <= 100)) //begin if-else-if statements for the grades
                {
                    Console.WriteLine("Your letter grade would be A+");
                    Console.ReadLine();
                }
                else if ((percent >= 92) && (percent <= 97))
                {
                    Console.WriteLine("Your letter grade would be A");
                    Console.ReadLine();
                }
                else if ((percent >= 90) && (percent <= 91))
                {
                    Console.WriteLine("Your letter grade would be A-");
                    Console.ReadLine();
                }
                else if ((percent >= 88) && (percent <= 89))
                {
                    Console.WriteLine("Your letter grade would be B+");
                    Console.ReadLine();
                }
                else if ((percent >= 82) && (percent <= 87))
                {
                    Console.WriteLine("Your letter grade would be B");
                    Console.ReadLine();
                }
                else if ((percent >= 80) && (percent <= 81))
                {
                    Console.WriteLine("Your letter grade would be B-");
                    Console.ReadLine();
                }
                else if ((percent >= 78) && (percent <= 79))
                {
                    Console.WriteLine("Your letter grade would be C+");
                    Console.ReadLine();
                }
                else if ((percent >= 72) && (percent <= 77))
                {
                    Console.WriteLine("Your letter grade would be C");
                    Console.ReadLine();
                }
                else if ((percent >= 70) && (percent <= 71))
                {
                    Console.WriteLine("Your letter grade would be C-");
                    Console.ReadLine();
                }
                else if ((percent >= 68) && (percent <= 69))
                {
                    Console.WriteLine("Your letter grade would be D+");
                    Console.ReadLine();
                }
                else if ((percent >= 62) && (percent <= 67))
                {
                    Console.WriteLine("Your letter grade would be D");
                    Console.ReadLine();
                }
                else if ((percent >= 60) && (percent <= 61))
                {
                    Console.WriteLine("Your letter grade would be D-");
                    Console.ReadLine();
                }
                
                else if ((percent <=59) && (percent >=0))
                {
                    Console.WriteLine("Your letter grade would be F");
                    Console.ReadLine();
                }                
                else // final else statement
                {
                    Console.WriteLine("ERROR! NOT A VALID GRADE!");
                    Console.ReadLine();
                }

            } // end of try

            catch // catch for error
            {
                Console.WriteLine("Please, please please please, I'm begging you, type in a number from 0 to 100 next time. Press ANY key to exit and try again.");
                Console.ReadKey(true);

            }

        } // end of program
    }
}
