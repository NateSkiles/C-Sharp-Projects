using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student", employeeId = 1 };
            Employee employee2 = new Employee() { firstName = "Sam", lastName = "Student", employeeId = 1 };
            Employee employee3 = new Employee() { firstName = "Mike", lastName = "Smith", employeeId = 2 };

            // Call the SayName() method on the object.
            employee1.SayName();

            // Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            // Hint: an object can be of an interface type if it implements that specific interface.
            IQuitable quitable = new Employee();

            bool checkedId = employee1 == employee2;
            if (checkedId)
            {
                Console.WriteLine("Employee {0} already exists, employee ID number: {1}", employee1.firstName, employee1.employeeId);
            }
            else
            {
                Console.WriteLine("Employee ID's are different.");
            }
            
            bool checkedId2 = employee1 != employee3;
            if (checkedId2)
            {
                Console.WriteLine("Employee ID's are different.");
            }
            else
            {
                Console.WriteLine("Employee {0} already exists, employee ID number: {1}", employee1.firstName, employee1.employeeId);
            }

            quitable.Quit();


            Console.ReadLine();
        }
    }
}
