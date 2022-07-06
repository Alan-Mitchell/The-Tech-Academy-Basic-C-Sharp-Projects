using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //One-dimensional array of strings
            string[] cars = { "BMW", "Ford", "GM" };
            //User input added 
            Console.WriteLine("Add another car brand!");
            string userInput = Console.ReadLine();

            //this loop prints out the array
            foreach (string i in cars)
            {
                Console.WriteLine(i + userInput);

            }
            Console.ReadLine();
            //while(true)
            //{
            //    Console.WriteLine("this loop is infinte");
            //    Console.ReadLine();
            //}

            {
                int i = 0;
                while (i < 5)
                {
                    Console.WriteLine(i);

                    i++;
                }

                {
                    int b = 0;
                    while (b < 3)
                    {
                        Console.WriteLine(b);

                        b++;
                    }
                    {
                        int c = 0;
                        while (c <= 9)
                        {
                            Console.WriteLine(c);

                            c++;
                        }
                        Console.ReadLine();

                        {
                            List<string> Foods = new List<string>();

                            Foods.Add("Shrimp");
                            Foods.Add("Lamb");
                            Foods.Add("Hotdogs");
                            Foods.Add("Hamburgers");

                            Console.WriteLine("Add a food");
                            string foodInput = Console.ReadLine();

                            if (Foods.Contains(foodInput))
                            {
                                for (int Food = 0; Food < Foods.Count; Food++)

                                {
                                    if (foodInput == Foods[Food])
                                    {
                                        Console.WriteLine(Food);
                                    }


                                }
                            }
                            else
                            {
                                Console.WriteLine("No match");
                            }
                            Console.ReadLine();

                            List<string> States = new List<string> { "TN", "NY", "OR", "TN" };
                            Console.WriteLine("Please enter a state abbreviation");
                            string stateInput = Console.ReadLine();

                            if (States.Contains(stateInput))
                            {
                                for (int State = 0; State < States.Count; State++)

                                {
                                    if (stateInput == States[State])
                                    {
                                        Console.WriteLine(State);
                                    }


                                }
                            }
                            else
                            {
                                Console.WriteLine("No match");
                            }
                            Console.ReadLine();

                            List<string> Colors = new List<string> { "Red", "Blue", "Green", "Red" };

                            List<string> Colors2 = new List<string> { };

                            foreach (string Color in Colors)
                            {
                                if (Colors2.Contains(Color))
                                {
                                    Console.WriteLine("Color appears twice in the List");
                                }
                                else
                                {
                                    Console.WriteLine("Not a duplicate");
                                }
                                Colors2.Add(Color);
                                Console.ReadLine();
                            }







                        }
                    }
                }
            }
        }
    }
}
;
