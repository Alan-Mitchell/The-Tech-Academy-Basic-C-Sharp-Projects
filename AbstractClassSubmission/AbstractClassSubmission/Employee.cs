using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person, IQuittable
    {
        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }

        public override void SayName()
        {
            throw new NotImplementedException();
        }
    }
}
