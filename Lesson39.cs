/*
 * https://imgur.com/tvttsy4
 */

using System;

namespace CBasics
{
    public class Lesson39
    {
        public static void Solution()
        {
        }

        private static void PrintResult(int m, int n, int k)
        {
            Console.WriteLine($"{m + n + k}");
        }

        private static void PrintResult(ref int m, ref int n, ref int k)
        {
            Console.WriteLine($"{m - n - k}");
        }

        private static void PrintResult(int m, int n)
        {
            Console.WriteLine(Math.Pow(m, n));
        }

    // TODO: One more override
    }
}
