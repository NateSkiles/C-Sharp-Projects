using System;

namespace Math_And_Comparison_Operator_Submission
{
    class Program
    {
        static void Main()
        {
            // The program must start by printing “Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison Program");

            // It must then print “Person 1” to the screen and get the following details from user input:
            Console.WriteLine("\nPerson 1:");
            // Hourly Rate
            Console.Write("Please enter your hourly rate: $");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());        // Take user input as string, convert to decimal

            // Hours worked per week
            Console.Write("Please enter hours worked per week: ");
            byte hoursWorked1 = Convert.ToByte(Console.ReadLine());

            // It must then print “Person 2” to the screen and then get the following details from user input:
            Console.WriteLine("\nPerson 2:");
            // Hourly Rate
            Console.Write("Please enter your hourly rate: $");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

            // Hours worked per week
            Console.Write("Please enter hours worked per week: ");
            byte hoursWorked2 = Convert.ToByte(Console.ReadLine());

            // It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
            // Weekly income equals hours worked times hourly rate, salary is weekly income times 52. Convert to int
            int salaryPerson1 = (int)(hoursWorked1 * hourlyRate1 * 52);
            Console.WriteLine("\nAnnual salary of Person 1: $" + salaryPerson1);
            // It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
            int salaryPerson2 = (int)(hoursWorked2 * hourlyRate2 * 52);
            Console.WriteLine("Annual salary of Person 2: $" + salaryPerson2);

            // It must then print to the screen “Does Person 1 make more money than Person 2 ?” and write the true or false value of this statement below it.
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool largerSalary = salaryPerson1 > salaryPerson2;
            if (largerSalary)       // If largerSalary is true, person 1 has a larger salary
            {
                Console.WriteLine("Person 1 has a larger salary.");
            }
            else                   // Else, person 2 has larger salary.
            {
                Console.WriteLine("Person 2 has a larger salary");
            }


            Console.ReadLine();
        }
    }
}
