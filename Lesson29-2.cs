/*
 * https://imgur.com/Ayi0IMP
 */

using System;

namespace CBasics
{
    public class Lesson292
    {
        public static void Solution()
        {
            Console.WriteLine("Введите два целых числа (через клавишу Enter)");
            var m = Convert.ToInt32(Console.ReadLine());
            var n = Convert.ToInt32(Console.ReadLine());

            int min = Math.Min(m, n), max = Math.Max(m, n);
            min += min % 2 == 0 ? 1 : 0;

            while (min <= max)
            {
                Console.WriteLine(min);
                min += 2;
            }
        }
    }
}
