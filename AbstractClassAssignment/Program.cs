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

            // Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            // Hint: an object can be of an interface type if it implements that specific interface.
            IQuitable quitable = new Employee();

            quitable.Quit();


            Console.ReadLine();
        }
    }
}
