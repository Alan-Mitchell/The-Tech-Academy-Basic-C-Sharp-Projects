using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmissionAssignment
{
    public class Calculator : CalculatorBase
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static implicit operator int(Calculator v)
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorBase
    {
    }
}
