using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math operation = new Math();
            {
                Console.WriteLine(operation.MathMethod(2, 3));
                Console.ReadLine();
            }
            Math operationF = new Math();
            {
                Console.WriteLine(operationF.MathMethod( 2.2, 3.3));
                Console.ReadLine();

            }
            Math operatonS = new Math();
            {
                Console.WriteLine(operatonS.MathMethod(1, 3));
                Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
