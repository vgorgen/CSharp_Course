using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 10;
            //if (num == 8)
            //{
            //    Console.WriteLine("Number is true");
            //}
            //else
            //{
            //    Console.WriteLine("Number is false");
            //}

            switch (num)
            {
                case 7:
                    Console.WriteLine("Number is 7");
                    break;
                case 8:
                    Console.WriteLine("Number is 8");
                    break;
                default:
                    Console.WriteLine("Number is not 7 or 8");
                    break;
            }
            Console.ReadLine();
        }
    }
}
