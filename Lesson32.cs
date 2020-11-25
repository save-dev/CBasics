/*
 * https://imgur.com/D1DjF48
 */

using System;

namespace CBasics
{
    public class Lesson32
    {
        public static void Solution()
        {
            for (var i = 0; i <= 100; i++) Console.WriteLine(i);
            for (var i = 2500; i >= 1001; i -= 3) Console.WriteLine(i);
            for (var i = 100; i >= 0; i -= 4) Console.WriteLine(i);
            for (float i = 1; i < 5; i += .2f) Console.WriteLine(i); //WTF?
        }
    }
}
