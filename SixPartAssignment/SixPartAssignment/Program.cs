using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part 1
            ////instance of a string array
           string[] GOATS = { "Serena Willams", "Lebron James", "Hank Aaron" };
            Console.WriteLine("Name a sports GOAT.");
            Console.ReadLine();

            foreach(string i in GOATS)
            {
               Console.WriteLine(i + " is a sports GOAT!");
                Console.ReadLine();
            }

            //Part 2 
            while(true)
            {
              Console.WriteLine("This is an infinite loop");
             Console.ReadLine();
            }

           int t = 0;
            while (t < 5)
           {
               Console.WriteLine(t);
                t++;
            }

            //Part 3 
            int a = 3;
            while (a < 5)
            {
               Console.WriteLine(a);
                a++;
            }
            int b = 0;
            while (b <= 5)
            {
                Console.WriteLine(b);
                b++;
            }
            //Part 4
            List<string> Sports = new List<string>();
            Sports.Add("Tennis");
            Sports.Add("Basketball");
            Sports.Add("Hockey");

            Console.WriteLine("Name a sport ");
            string sportInput = Console.ReadLine();

            foreach (var sport in Sports)
            {
                Console.WriteLine(sport);
                Console.ReadLine();
            }

            bool answer = String.Equals(Sports, sportInput);

            if (answer is true)
            {
                Console.WriteLine("You got it ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter another sport");
                Console.ReadLine();
            }

            //Part 5
            List<string> drinks = new List<string>();
            drinks.Add("Wine");
            drinks.Add("Water");
            drinks.Add("Soda");
            drinks.Add("Wine");

            Console.WriteLine("Enter a drink");
            string drinkInput = Console.ReadLine();
            
            foreach (var drink in drinks)
            {
                Console.WriteLine(drink);
                Console.ReadLine();
            }

            bool drinkanswer = String.Equals(drinks, drinkInput);

            if (drinkanswer is true)
            {
                Console.WriteLine("You got it ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter another drink");
                Console.ReadLine();
            }

            //Part 6
            List<String> Cakes = new List<string>();
            Cakes.Add("Carrot");
            Cakes.Add("Cheesecake");
            Cakes.Add("Strawberry");
            Cakes.Add("Carrot");

            List<string> Cakes2 = new List<string>();

            foreach(var cake in Cakes)
            {
                if (Cakes2.Contains(cake))
                {
                    Console.WriteLine("I have already seen {0} before", cake);
                }
                else
                {
                    Console.WriteLine("I have not seen {0} before", cake);
                    Cakes2.Add(cake);

                }
            }
            



        }
    }
}
