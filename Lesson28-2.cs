/*
 * https://imgur.com/yVNNIzi
 */

using System;

namespace CBasics
{
    public class Lesson282
    {
        public static void Solution()
        {
            Console.WriteLine("Введите два целых числа (через клавишу Enter)");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());

            (x >= y ? ref x : ref y) = 100;

            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
