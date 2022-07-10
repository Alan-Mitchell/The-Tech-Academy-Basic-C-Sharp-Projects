using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Alan";
            employee1.LastName = "Mitchell";

            Employee employee2 = new Employee();
            employee2.Id = 1;
            employee2.FirstName = "John";
            employee2.LastName = "Doe";

            if(employee1 == employee2)
            {
                Console.WriteLine("Employee1 is equal to to Employee2");
            }
            else
            {
                Console.WriteLine("Employee1 is NOT equal to Employee2");
            }
            Console.ReadLine();
        }
    }
}
