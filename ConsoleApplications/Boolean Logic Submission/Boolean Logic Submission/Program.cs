using System;

namespace Boolean_Logic_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval Form");
            Console.WriteLine("\nTo get started today we need to get some information from you.");

            //Your application must ask these questions:
            //What is your age?
            Console.WriteLine("How old are you?: ");
            byte userAge = Convert.ToByte(Console.ReadLine());
            //Have you ever had a DUI?
            Console.WriteLine("Have you ever had a DUI? (y/n): ");
            string userStr = Console.ReadLine();
            bool userDUI = userStr.ToLower() == "yes" || userStr.ToLower() == "y";      // userDUI equals true if userStr is yes or y
      
            //How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets do you have?: ");
            byte userTickets = Convert.ToByte(Console.ReadLine());

            //Use the following qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUI’s.
            //Applicants must not have more than 3 speeding tickets.
            //Print the result of the boolean expression created from the above business rules.  

            bool qualified = userAge > 15 && userDUI == false && userTickets <= 3;
            if (qualified)
            {
                Console.WriteLine("\n\nCongratulations! You qualify.");
            }
            else
            {
                Console.WriteLine("\n\nI'm sorry, you do not qualify.");
            }

            Console.ReadLine();
        }
    }
}
