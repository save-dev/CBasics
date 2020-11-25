using System;

/*
 * Refactor this
 * https://imgur.com/xwtTMrY
*/
namespace CBasics
{
    public class Refactoring
    {
        public static void Solution()
        {
            double value;
            var g = 0;
            const int x = 1, y = 2, z = 3;

            Console.WriteLine("Введите число");
            var input = Convert.ToUInt32(Console.ReadLine());

            if (x > y && input < 15)
            {
                g = y;
                value = g + Math.PI;
            }
            else
            {
                if (z == y && z < 4) g = z;
                value = g + Math.PI * 2;
            }

            Console.WriteLine($"Число g = {g}, значение value = {value}");
        }
    }
}
