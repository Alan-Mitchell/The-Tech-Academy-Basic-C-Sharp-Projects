using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{ 

public class ConstTest
{
    class SampleClass
    {
        public int x;
        public int y;
        public const int C1 = 5;
        public const int C2 = C1 + 5;

            public SampleClass(int p1) : this(p1, "Bob")
        {
            x = p1;
           
        }
        public SampleClass(string v): this(12, v)
            {
                v = "Alan";
               
            }
        public SampleClass(int p1, string v)
            {
                p1 = 12;
                v = "Name";
            }


    }

    static void Main()
    {
        var mC = new SampleClass(11, "Name");
        Console.WriteLine($"x = {mC.x}, y = {mC.y}");
        Console.WriteLine($"C1 = {SampleClass.C1}, C2 = {SampleClass.C2}");
        Console.ReadLine();
    }
}
}
/* Output
    x = 11, y = 22
    C1 = 5, C2 = 10
*/

