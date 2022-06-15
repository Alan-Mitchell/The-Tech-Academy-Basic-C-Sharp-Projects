using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below");
            Console.ReadLine();

            Console.WriteLine("Please enter the weight of your package.");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();

            }

            else if (pkgWeight < 50)
            {
                Console.WriteLine("What is the width of your package?");
                int pkgwidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package height?");
                int pkgheight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                int pkglength = Convert.ToInt32(Console.ReadLine());
            
            
               if (pkgwidth * pkgheight * pkglength > 50)
               {
                  Console.WriteLine("Package too big to be shipped via Package Express.");
                   Console.ReadLine();
               }
               else {
                        int dimensions = pkgwidth * pkgheight * pkglength;
                   Console.WriteLine("Your total is $" + dimensions * pkgWeight / 100);
                    Console.ReadLine();

            

            }
                }

            }
            


        }
    }

