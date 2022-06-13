using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            String results = favNum == 12 ? "You have an awesome favorite Number" : "You do not have an awesome favorite number";

            Console.WriteLine(results);
            Console.ReadLine();
            

            //    int roomTemprature = 70;

            //    Console.WriteLine("Hi, what is your name?: ");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Hi, " + name + ", what is the remprature where you are?");
            //    int currentTemprature = Convert.ToInt32(Console.ReadLine());

            //    if (currentTemprature == roomTemprature)
            //    {
            //        Console.WriteLine("it is exactly room temprature");

            //    }
            //    else if (currentTemprature > roomTemprature)
            //    {
            //        Console.WriteLine("It is warmer than room temprature.");

            //    }
            //    else if (roomTemprature > currentTemprature)
            //    {
            //        Console.WriteLine("Room temprature is warmenr than current temprature");
            //    }

            //    else
            //    {
            //        Console.WriteLine("This will never run!");
            //    }

            Console.ReadLine();
            //int currentTemprature = 80;
            //int roomTemprature = 70;

            //string comparisonResult = currentTemprature == roomTemprature ? "It is room temp" : "It is not room temp";

            //Console.WriteLine(comparisonResult);
            ////if(currentTemprature == roomTemprature)
            ////{
            ////    Console.WriteLine("It is exactly room temprature. ");

            ////}
            ////else if(currentTemprature > roomTemprature)
            ////    {
            ////    Console.WriteLine("It is warmer than room temprature");
            ////}
            ////else if (roomTemprature > currentTemprature)
            ////{
            ////    Console.WriteLine("Room temprature is  greater than current temprature");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("It is not exactly room temprature.");
               

            ////}
            //Console.ReadLine();
        }
    }
}
