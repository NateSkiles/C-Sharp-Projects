using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuitable
    {
        // Create another class called Employee and have it inherit from the Person class.
        public override void SayName()
        {
            // Implement the SayName() method inside of the Employee class.
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        // Have your Employee class from the previous drill inherit that interface and
        // implement the Quit() method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
