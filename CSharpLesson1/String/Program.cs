using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sntnc = "This is my family.";
            var res = sntnc.Length;
            //Stringi klonlar
            var res2 = sntnc.Clone();
            //neyle bittiğini kontrol eder.
            bool res3 = sntnc.EndsWith("family.");
            //neyle başladığını kontrol eder.
            bool res4 = sntnc.StartsWith("T");
            //bir kelimenin veya harfin nerde olduğunu bulur ve kaçıncı sırada olduğunu söyler.
            var res5 = sntnc.IndexOf("my");
                
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string cty = "Istanbul";
            Console.WriteLine(cty);
            foreach (var city in cty)
            {
                Console.WriteLine(city);
            }
            string cty2 = "Ankara";
            string res = cty + cty2;
            Console.WriteLine(res);
        }
    }
}
