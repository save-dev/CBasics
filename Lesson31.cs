/*
 * https://imgur.com/IxZumn5
 */

using System;

namespace CBasics
{
    public class Lesson31
    {
        public static void Solution()
        {
            Console.WriteLine("Введите длину нового массива");
            var len = Convert.ToInt32(Console.ReadLine());
            var arr = new int[len];

            Console.WriteLine("Заполните массив элементами");
            var cnt = 0;
            while (cnt < len)
            {
                Console.WriteLine("Введите элемент");
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
                cnt++;
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));
            Array.Resize(ref arr, len + 1);

            Console.WriteLine("Введите новый элемент массива");
            arr[len] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
