using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTYpes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your Name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("your favorite number plus 5 is: " + favNum);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursworked = 42;
            sbyte currenttemp = -24;
            char questionmark = '\u2103';
            decimal money = 1.5m;

            double heightsInCentimeters = 211.472984984;
            float secondsleft = 2.62f;
            short tempratureonMars = -233;
            string Name = "Alan";

            int ageNow = 31;
            string Agetoday = ageNow.ToString();

            bool isRaining = true;
            string weather = Convert.ToString(isRaining);

            Console.WriteLine(isRaining);
            Console.ReadLine();

        }
    }
}
