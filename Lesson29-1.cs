/*
 * https://imgur.com/Ayi0IMP
 */

using System;

namespace CBasics
{
    public class Lesson291
    {
        public static void Solution()
        {
            Console.WriteLine("Введите целое число ");
            var n = Convert.ToInt32(Console.ReadLine());
            while (n >= 0) Console.Write(n--);
        }
    }
}
