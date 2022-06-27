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
            //Strng array instance
            string[] Colors = { "Blue", "Green", "Red" };
            Console.WriteLine("Please enter a number! ");
            int input = Convert.ToInt32(Console.ReadLine());
            //conditonal statement
            if (input > 2)
            {
                Console.WriteLine("please choose a smaller number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The color you chose was " + Colors[input]);
                Console.ReadLine();
            }
            //int array instance 
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Please enter a number! ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            //conditional statment
            if (numberInput > 2)
            {
                Console.WriteLine("please choose a smaller number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The color you chose was " + numbers[numberInput]);
                Console.ReadLine();

            }
            List<string> StringExample = new List<string> {"Fun", "Fuel", "Fashion" };
            Console.WriteLine("Select an index");
            int stringinput = Convert.ToInt32(Console.ReadLine());

            if(stringinput > 2)
            {
                Console.WriteLine("Please choose a smaller number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You chose the correct f word " + StringExample[stringinput]);
                Console.ReadLine();
            }
        }
    }
}
