using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person, IQuittable
    {
        
        public void Quit()
            
        {
            
            Console.WriteLine("Employee Quit");
            
        }

        public override void SayName()
        {
            Console.WriteLine(firstName, lastName);
            
        }
    }
    
}
