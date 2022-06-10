using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program title Printed
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            // Person 1 Details
            Console.WriteLine("Person 1");
            Console.ReadLine();
            //Person 1 user inputs
            Console.WriteLine("a. Hourly Rate: ");
            int P1HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b. Hours worked per week: ");
            int P1HoursPerWeek = Convert.ToInt32(Console.ReadLine());

            //Person 2 user inputs
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("a. Hourly Rate: ");
            int P2HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b. Hours worked per week: ");
            int P2HoursPerWeek = Convert.ToInt32(Console.ReadLine());

            //Math operations to figure salary 
            Console.WriteLine("Annual Salary of Person 1");
            Console.ReadLine();
            int P1AnnualSalry = P1HourlyRate * P1HoursPerWeek * 52;
            Console.WriteLine("Person 1 annual salry is " + P1AnnualSalry);
            Console.ReadLine();

            //Person 2 salary figures 
            Console.WriteLine("Annual Salary of Person ");
            Console.ReadLine();
            int P2AnnualSalry = P2HourlyRate * P2HoursPerWeek * 52;
            Console.WriteLine("Person 2 annual salry is " + P2AnnualSalry);
            Console.ReadLine();

            //Comparison Operators for salories. 
            bool salaryCompare = P1AnnualSalry > P2AnnualSalry;
            Console.WriteLine("Does Person 1 make more money than person 2: " + salaryCompare);
            Console.ReadLine();



        }
    }
}
