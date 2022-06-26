using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Colors = { "Blue", "Green", "Red" };
            Console.WriteLine("Please enter a number! ");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input >2 )
            {
                Console.WriteLine("please choose a smaller number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The color you chose was " + Colors[input]);
                Console.ReadLine();
            }
        }
    }
}
