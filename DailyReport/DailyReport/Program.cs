using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   //Console.Write prints onto the console 
            Console.WriteLine("The Tech Academy");
            //Console.readline keeps the printed console on the screen
            Console.ReadLine();
            //Prints the question, What is you name?
            Console.WriteLine("What is your name?");
            //assigns a variable to the answer.
            string Name = Console.ReadLine();

            //keeps the answer on the page
            Console.ReadLine();
            //Next required question given
            Console.WriteLine("What course are you on?");
            // This variable is the answer to the course question
            string courseName = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("What page number");
            string pageNumber = Console.ReadLine();
            Console.ReadLine();
            //This line uses \ to add in extra "". 
            Console.WriteLine("Do you need help with anything? Please answer \"true\"\"false\"");
            string helpNeeded = Console.ReadLine();
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study");
            string studytime = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will repond shortly. Have a nice day!");
            Console.ReadLine();
            





        
            
        }
    }
}
