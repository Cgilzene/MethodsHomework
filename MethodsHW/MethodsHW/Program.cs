using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            double addTotal;
            double sum;
            numberInputs input = new numberInputs();
            sum = input.Product(out addTotal);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }

    class numberInputs
    {
        public double Product(out double sum)
        {

            double addSum;
            double multSum;

            Console.WriteLine("please first input value");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("please second input value");
            float value2 = float.Parse(Console.ReadLine());
            Console.WriteLine("please third input value");
            float value3 = float.Parse(Console.ReadLine());

            Console.WriteLine("The answer for mult is");
            // multiply 3 numbers and return them
             multSum = value1 * value2 * value3;
            // add 3 numbers and return sum using out
             addSum = value1 + value2 + value3;

            sum = addSum;
            return multSum;
        }

        class cat // cat class
        {
            public string Name
            {

                get
                {
                    return Name;
                }
                set
                {
                    Name = "value";
                }
            }
            public int Age
            {
                get
                {
                    return Age;
                }
                set
                {

                    Age = Age;
                }
            }
                public int Catage(int value1)
            {
                int catsAge = value1 + 5;
                return catsAge;
            }
        }

    }
}
