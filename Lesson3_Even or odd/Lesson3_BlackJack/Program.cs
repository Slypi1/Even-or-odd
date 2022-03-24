using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать! \nСкажите сколько карт у вас на руках:");
            byte AmountCard = byte.Parse(Console.ReadLine());
            int SumCard = 0;
            for (int i = 0; i < AmountCard; i++)
            {
                Console.WriteLine("Ввидите номинал следующей карты : ");
                string  NumberCard = Console.ReadLine();
                switch (NumberCard)
                {
                    case "6" : SumCard = SumCard + 6;break;
                    case "7" : SumCard = SumCard + 7;break;
                    case "8" : SumCard = SumCard + 8;break;
                    case "9" : SumCard = SumCard + 9;break;
                    case "10": SumCard = SumCard + 10;break;
                    case "J" : SumCard = SumCard + 10;break;
                    case "Q": SumCard = SumCard + 10; break;
                    case "K": SumCard = SumCard + 10; break;
                    case "T": SumCard = SumCard + 10; break;
                    default: Console.WriteLine("Данной карты не существует");break;


                }
             }
            Console.WriteLine($"Сумма карт:{SumCard} ");

            Console.ReadKey();

        }
    }
}
