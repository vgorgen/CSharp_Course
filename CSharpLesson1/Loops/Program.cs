using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forloop();
            //WhileLoop();
            //ForEachLoop();
            if(IsPrimenumber(7))
            {
                Console.WriteLine("This number is prime.");
            }
            else
            {
                Console.WriteLine("This number is not prime.");
            }

            Console.ReadLine();
        }

        private static bool IsPrimenumber(int number)
        {
            bool result = true;
            for(int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }

                else if(number % i == 1 || number % i != 0)
                {
                    result = true;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] collection = { "Apple", "Samsung", "Xiaomi" };
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private static void WhileLoop()
        {
            int i = 1;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void Forloop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Finished!");
        }
    }
}
