using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            // Call the SayName() method on the object.
            employee.SayName();

            Console.ReadLine();
        }
    }
}
