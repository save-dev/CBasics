using System;

namespace CBasics
{
/*
 * https://imgur.com/7AejKwz
 */
    public class Lesson262
    {
        public static void Solution()
        {
            Console.WriteLine("Введите 4 целых числа (через клавишу Enter)");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            var a4 = Convert.ToInt32(Console.ReadLine());

            if ((a1 * a2 * a3 * a4) % 2 == 0)
            {
                var max1 = Math.Max(a1, a2) % 2 == 0 ? Math.Max(a1, a2) : Math.Min(a1, a2);
                var max2 = Math.Max(a3, a4) % 2 == 0 ? Math.Max(a3, a4) : Math.Min(a3, a4);
                var max3 = Math.Max(max1, max2) % 2 == 0 ? Math.Max(max1, max2) : Math.Min(max1, max2);

                Console.WriteLine(max3);
            }
            else Console.WriteLine("Not found");
        }
    }
}
