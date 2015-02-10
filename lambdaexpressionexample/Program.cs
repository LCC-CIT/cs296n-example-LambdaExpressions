using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionExample
{

    class Program
    {
        // A plain vanilla method
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // This method takes a delegate as the third parameter
        static void WriteMath(short n1, short n2, Func< short, short, int> func)
        {
            Console.WriteLine("Parameters {0} and {1} result in {2}", n1, n2, func(n1, n2));
        }

        static void Main(string[] args)
        {
            // using a regular method definition
            short a = 2, b = 3;
            Console.WriteLine("{0} plus {1} equals {2}", a, b, Sum(a, b));

            // using a lambda expression to define a Func delegate
            Func<int, int, int> sum;
            sum = (n1, n2) => n1 + n2;
            Console.WriteLine("{0} plus {1} equals {2}", a, b, sum(a,b));

            // using a lambda expression as a method argument
            WriteMath(a, b, (num1, num2) => { return num1 + num2; });
            WriteMath(a, b, (num1, num2) => { return num1 * num2; });
            WriteMath(a, b, (num1, num2) => num1 - num2);
        }
    }
}
