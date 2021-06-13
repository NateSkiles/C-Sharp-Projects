using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuitable
    {
        // Add a property to the Employee class called “things” and have its data type be a generic list matching
        // the generic type of the class
        // Note: Change to class Employee<T> for generic class type
        //public List<T> Things { get; set; }

        // Create another class called Employee and have it inherit from the Person class.
        public override void SayName()
        {
            // Implement the SayName() method inside of the Employee class.
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        // Have your Employee class from the previous drill inherit the IQuitable interface and
        // implement the Quit() method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        public int employeeId { get; set; }

        // Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        // Returns bool value when comparing two employee IDs.
        public static bool operator == (Employee employee1, Employee employee2)
        {
            bool checkedId = employee1.employeeId == employee2.employeeId;
            return checkedId;
        }
        public static bool operator != (Employee employee1, Employee employee2)
        {
            bool checkedId = employee1.employeeId != employee2.employeeId;
            return checkedId;
        }

        // Override Equals() and GetHashCode() to implement == operator overload
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
