/*
 * https://imgur.com/WDcjV4e
 */

using System;

namespace CBasics
{
    public class Lesson30
    {
        public static void Solution()
        {
            string[] months =
            {
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"
            };
            foreach (var m in months) Console.WriteLine(m);

            // Part 2
            var userErrorCount = 0;
            const int userErrorAllowed = 5;

            Console.WriteLine($"Введите все месяцы года по порядку, разделяя их клавишей Enter. У вас {userErrorAllowed} попыток");
            foreach (var month in months)
            {
                Console.WriteLine($"Введите месяц");
                var input = Console.ReadLine();

                while (!input.Equals(month) && userErrorCount < userErrorAllowed - 1)
                {
                    Console.WriteLine($"Попытка #{userErrorCount + 2}. Введите месяц заново");
                    input = Console.ReadLine();
                    userErrorCount++;
                }

                if (userErrorCount == userErrorAllowed - 1) break;
            }
        }
    }
}
