using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {
        //The instance of a string array
        string[] cars = { "Ford", "GM", "BMW", };
        Console.WriteLine("What is your favorite car type!");
        //for loop created to itterate through cars array
        for(int car=0; car < cars.Length; car++)
        {
            //Writes on the console the indices of the array cars
            Console.WriteLine(cars[car]);
        }
        Console.ReadLine();
    }
    
    }

