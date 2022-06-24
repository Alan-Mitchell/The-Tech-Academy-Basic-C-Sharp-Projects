using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Alan";

            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a new line. ";
            //string filename = @"C:\Users\Jesse";
            //bool trueOrFalse = name.Contains("a");
            //trueOrFalse = name.EndsWith("f");
            //name = name.ToUpper();
            //name = name.ToLower();

            //int length = name.Length;

            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(filename);
            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Alan");   


            //Console.WriteLine(sb);
            //Console.ReadLine();
            // Variables that will be used to concatenates 
            string fname = "Alan ";
            string mname = "Fitzgerald ";
            string lname = "Mitchell ";
            //This method is used to make all letters of the variable uppercase.
            fname = fname.ToUpper();
            StringBuilder firstline = new StringBuilder();
            firstline.Append("Hello, my name is Alan.");
            StringBuilder sencondline = new StringBuilder();
            sencondline.Append("What is your name");
            
            Console.WriteLine(sencondline);
            //Concatenated strings
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
