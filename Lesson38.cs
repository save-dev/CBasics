/*
 * https://imgur.com/b2TKGDV
 */

using System;

namespace CBasics
{
    public class Lesson38
    {
        public static void Solution()
        {
            int x = 1, y = 2, z = 3;
            var b = false;
            Console.WriteLine($"Результат выполнения метода: {Chaos(x, y, z, b)}");
            Console.WriteLine($"Значения параметров x, y, z, bool: {x}, {y}, {z}, {b}");
        }

        private static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        private static int BiggerSum(ref int x, ref int y, ref int z)
        {
            x++;
            y++;
            z++;
            return x + y + z;
            // TODO: WTF with those guys x, y and z
        }

        private static int Chaos(int x, int y, int z, bool b)
        {
            return b ? Sum(x, y, z) : BiggerSum(ref x, ref y, ref z);
        }
    }
}
