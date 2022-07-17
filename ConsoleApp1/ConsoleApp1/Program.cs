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
            DateTime dateTime = new DateTime(2022, 7, 17, 12, 03, 34);
            Console.WriteLine(dateTime);

            Console.WriteLine("Please provide a number");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime dateTime1 = new DateTime(2022, 7, 17, 12 + x, 03, 34);
            Console.WriteLine(dateTime1);

            Console.ReadLine();
        }
    }
}
