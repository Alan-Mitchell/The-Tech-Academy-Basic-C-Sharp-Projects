using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
       
    {

        try {  


           List<int> numbers1 = new List<int> { 1, 4, 6, 8, 9 };


        {

            Console.WriteLine("Pick a number. ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number. ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        } }
            

        catch (FormatException ex)

        {
            Console.WriteLine("Please type a whole number! ");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero ");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    }
}
