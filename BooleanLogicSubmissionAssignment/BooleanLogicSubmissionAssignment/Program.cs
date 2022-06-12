using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int ageCheck = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? True or False ");
            bool DUIstatus = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had? ");
            int SpeedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            Console.ReadLine();
            bool Qualified = ageCheck > 15 && DUIstatus == false && SpeedingTickets < 3;
            Console.WriteLine(Qualified);
            Console.ReadLine();


        }
    }
}
