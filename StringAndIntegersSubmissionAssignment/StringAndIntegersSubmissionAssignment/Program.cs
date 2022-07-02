using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
       
    {

        try {  


           List<int> numbers1 = new List<int> { 1, 4, 6, 8, 9 };

            foreach(int num1 in numbers1)
        {

            Console.WriteLine("Pick a number. ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("List divided answers " + num1 / numberOne);
                Console.WriteLine();


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
