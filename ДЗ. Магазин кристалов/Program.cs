
using System;

namespace ДЗ.Магазин_кристалов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals;
            int oneCrystalPrice = 15;

            Console.WriteLine("Вас приветствует магазин кристалов! Сегодня у нас действует акция! Один кристал за " + oneCrystalPrice + " золота.");
            Console.Write("Сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристалов вам необходимо? ");
            crystals = Convert.ToInt32(Console.ReadLine());

            gold-= crystals*oneCrystalPrice;
            Console.WriteLine($"У вас в сумке {crystals} кристалов, и {gold} едениц золота");
        }
    }
}
