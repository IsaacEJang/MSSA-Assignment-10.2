using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        #region Formatting

        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 10.2");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Part1
            Introduction();
            /*1.Write a program in C# Sharp to find the +ve numbers from a list of numbers 
             * using where conditions in LINQ Query.
            Input: { 2, -1, 3, -3, 10, -200}
            Expected output: { 2, 3, 10}*/

            //creating list of numbers hard coded
            List<int> numbers = new List<int>();

            //adding numbers to list
            numbers.Add(2);
            numbers.Add(-1);
            numbers.Add(3);
            numbers.Add(-3);
            numbers.Add(10);
            numbers.Add(-200);

            //filtering for positive (+ve) numbers
            var positiveNumbers = numbers.FindAll(x => x > 0); // have to create new list or use 'var'

            //Display postive numbers
            Console.WriteLine("\nI will return the postive numbers from '[2, -1, 3, -3, 10, -200]':\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (int x in positiveNumbers)
            {
                Console.Write(x + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            #endregion

            #region Part2
            Transition(); Part(2);
            /* 2.Write a program to create a list of employees. Consider a hard coded list.
            Display all employees who have salary more than $5000 and age< 30.*/

            // list of hard coded employees
            List<Employee> employees = new List<Employee>
            {
                new Employee {Name = "John", Age = 32, Salary = 5500},
                new Employee {Name = "Paul", Age = 25, Salary = 7000},
                new Employee {Name = "Matthew", Age = 37, Salary = 3200},
                new Employee {Name = "Mark", Age = 27, Salary = 8750},
                new Employee {Name = "Luke", Age = 31, Salary = 9000},

            };

            //creating filtered employees
            var filteredEmployees = employees.FindAll(e => e.Salary > 5000 && e.Age < 30);

            //Display Results
            Console.WriteLine("\nAll employees who have salary more than $5000 and age< 30");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            foreach (Employee employee in filteredEmployees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: ${employee.Salary}, Age: {employee.Age}");
            }
            Console.ForegroundColor = ConsoleColor.White; 
            #endregion

            ClosingMessage(); Console.ReadKey();

        }

    }
}
