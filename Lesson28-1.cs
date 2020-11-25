/*
 * https://imgur.com/yVNNIzi
 */

using System;

namespace CBasics
{
    public class Lesson281
    {
        public static void Solution()
        {
            Console.WriteLine("Введите два целых числа (через клавишу Enter)");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());

            x = (x % 2 == 0) ? x : ++x;
            y = (y % 2 == 0) ? y : ++y;

            var result = ((x + y) % 4 == 0)
                ? $"Сумма значений {x} и {y} делится на 4"
                : $"Сумма значений {x} и {y} на 4 не делится";

            Console.WriteLine(result);
        }
    }
}
