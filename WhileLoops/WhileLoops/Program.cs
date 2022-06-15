using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //This example below displays a while loop
            int number = 76;
            while(number < 80)
                {
                Console.WriteLine(number++);
                Console.ReadLine();

            }
            do
            {
                Console.WriteLine(number--);
                Console.ReadLine();
            }
            while (number > 70);


        }

    }
}
