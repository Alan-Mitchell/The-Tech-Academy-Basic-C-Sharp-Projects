using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            //New instance of a datetime object
            //DateTime dateTime = new DateTime();
            Console.WriteLine(DateTime.Now);

            //user providiing a number. 
            Console.WriteLine("Please provide a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(x));
            

            Console.ReadLine();
        }
    }
}
