﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {
            Weekdays day = new Weekdays();
            Console.WriteLine("What is the current day of the week?");
            string reply = Console.ReadLine();
            
            if(day == reply)

        }
    }
}
