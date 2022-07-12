using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();
            example.firstName = "Sample";
            example.lastName = "Student";
            example.SayName();

            IQuittable quitter = new Employee();
            quitter.Quit();
        }

        
    }
}
