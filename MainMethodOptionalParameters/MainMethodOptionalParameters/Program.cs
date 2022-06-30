using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameters Ops = new OptionalParameters();
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in a diffrent number");
            int num2 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
