using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator math = new Calculator();
            Console.WriteLine(math.Add(1, 2));
            Console.ReadLine();
        }

    }
}
