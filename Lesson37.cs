/*
 * https://imgur.com/l9KkiIi
 */

using System;

namespace CBasics
{
    public class Lesson37
    {
        public static void Solution()
        {
            Console.WriteLine("Введите количество сотрудников предприятия");
            var numberEmployees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость одного трудодня");
            var workDayRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество дней для оплаты");
            var totalDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Общий объем денег, необходимый для оплаты всем сотрудникам: {GrossSalary(numberEmployees, totalDays, workDayRate)}");
        }

        /// <summary>
        /// Зарплата одного сотрудника
        /// </summary>
        /// <param name="totalDays">Рабочих дней</param>
        /// <param name="workDayRate">Оплата за день</param>
        /// <returns>ЗП сотрудника</returns>
        private static int EmployeeSalary(int totalDays, int workDayRate)
        {
            return checked(totalDays * workDayRate);
        }

        /// <summary>
        /// Зарплата всех сотрудников
        /// </summary>
        /// <param name="numberEmployees">Кол-во сотрудников</param>
        /// <param name="totalDays">Рабочих дней</param>
        /// <param name="workDayRate">Оплата за день</param>
        /// <returns>Зарплата всех сотрудников</returns>
        private static int GrossSalary(int numberEmployees, int totalDays, int workDayRate)
        {
            return checked(EmployeeSalary(totalDays, workDayRate) * numberEmployees);
        }
    }
}
