using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World ");
            int number = 156;
            long number2 = 159789654852;
            byte number3 = 255;
            bool con = true;
            char chr = 'b';
            string str = "Love me";
            double d = 18.8;
            decimal dec = 19.565468795123m;
            var thor = "WER";
            thor = "ASD";

            Console.WriteLine("Number is {0}", number);
            Console.WriteLine("Number is {0}", number2);
            Console.WriteLine("Number is {0}", number3);
            Console.WriteLine("Number is {0}", con);
            Console.WriteLine(chr);
            Console.WriteLine("Chr: {0}", (int)chr);
            Console.WriteLine(str);
            Console.WriteLine("Double number is {0}", d);
            Console.WriteLine("Decimal number is {0}", dec);
            Console.WriteLine(Days.Monday);
            Console.WriteLine(thor);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
