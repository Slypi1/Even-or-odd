using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите целое число: ");
            int Number = int.Parse(Console.ReadLine());
            if (Number%2==0)
            {
                Console.WriteLine("Четное");

            }
            else
            {
                Console.WriteLine("Нечетное");
            }

            Console.ReadKey(); 
        }
    }
}
