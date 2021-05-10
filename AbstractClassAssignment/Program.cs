using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            //Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student", employeeId = 1 };
            //Employee employee2 = new Employee() { firstName = "Sam", lastName = "Student", employeeId = 1 };
            //Employee employee3 = new Employee() { firstName = "Mike", lastName = "Smith", employeeId = 2 };

            //// Call the SayName() method on the object.
            //employee1.SayName();

            //// Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //// Hint: an object can be of an interface type if it implements that specific interface.
            //IQuitable quitable = new Employee();

            //bool checkedId = employee1 == employee2;
            //if (checkedId)
            //{
            //    Console.WriteLine("Employee \"{0}\" already exists, employee ID number: {1}", employee1.firstName, employee1.employeeId);
            //}
            //else
            //{
            //    Console.WriteLine("Employee ID's are different.");
            //}

            //bool checkedId2 = employee1 != employee3;
            //if (checkedId2)
            //{
            //    Console.WriteLine("Employee ID's are different.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee {0} already exists, employee ID number: {1}", employee1.firstName, employee1.employeeId);
            //}

            //quitable.Quit();



            // In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id. At least two employees should have the first name “Joe”.
            List<Employee> employeeList = new List<Employee>();
            List<Employee> employeeJoes = new List<Employee>();

            employeeList.Add(new Employee() { firstName = "Joe", lastName = "Smith", employeeId = 1 });
            employeeList.Add(new Employee() { firstName = "Jesse", lastName = "West", employeeId = 2 });
            employeeList.Add(new Employee() { firstName = "Joe", lastName = "Greene", employeeId = 3 });
            employeeList.Add(new Employee() { firstName = "Jake", lastName = "Smith", employeeId = 4 });
            employeeList.Add(new Employee() { firstName = "Kate", lastName = "Lee", employeeId = 5 });
            employeeList.Add(new Employee() { firstName = "Nate", lastName = "Skiles", employeeId = 6 });
            employeeList.Add(new Employee() { firstName = "Mike", lastName = "James", employeeId = 7 });
            employeeList.Add(new Employee() { firstName = "Jill", lastName = "Scott", employeeId = 8 });
            employeeList.Add(new Employee() { firstName = "Kim", lastName = "Sims", employeeId = 9 });
            employeeList.Add(new Employee() { firstName = "Alice", lastName = "Smith", employeeId = 10 });

            // // Using a foreach loop, create a new list of all employees with the first name “Joe”.
            //foreach (Employee employee in employeeList)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        employeeJoes.Add(employee);
            //    }
            //    Console.WriteLine("Employee Info: {0} {1} ID: {2}", employee.firstName, employee.lastName, employee.employeeId); 
            //}

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> employees = new List<Employee>(employeeList.Where(employee => employee.employeeId > 5));

            foreach (Employee employee in employees)
            {
                Console.WriteLine("{0} {1} {2}", employee.firstName, employee.lastName, employee.employeeId);
            }

            Console.ReadLine();
        }
    }
}
