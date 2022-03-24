using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите число: ");
            int Number = int.Parse(Console.ReadLine());
            bool Proverka = false;
            int i = 1;
            while (i <= Number -1)
            {
                
                if (Number%i== 0)
                i++;
                Proverka = true;
               break ;
            }
            if (!Proverka)
                Console.WriteLine( "Число простое" );
                else
                Console.WriteLine("Число не явлется простым");
            Console.ReadKey();  
        }
       
    }
}
