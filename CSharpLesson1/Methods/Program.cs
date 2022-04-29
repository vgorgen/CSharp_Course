using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
            Add(14,15);
            Console.WriteLine("");
            Add2(456, 125);
            Console.WriteLine("");
            int a;
            int b = 5;
            multiply(out a, b);
            Console.WriteLine("");
            Console.WriteLine(Add3(1, 2, 6, 45, 21, 22, 5));
            Console.ReadLine();
        }

        static int Sum()
        {
            int a = 1 , b = 1, res = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i = 1; i < 10; i++)
            {
                
                a = b;
                b = res;
                res += a;
                Console.WriteLine(res);


            }
            return res;
        }

        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            for (int i = 0; i < 3; i++)
            { Console.WriteLine(""); }

            Console.WriteLine(sum);
            return sum;
        }

        static int Add2(int num1, int num2)
        {
            var sub = num1 - num2;
            Console.WriteLine(sub);
            return sub;
            
        }

        static int multiply(out int a, int b)
        {
            a = 20;
            var sum = a * b;
            Console.WriteLine(sum);
            return sum;
        }

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
