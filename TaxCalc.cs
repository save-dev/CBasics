using System;

namespace CBasics
{
    public class TaxCalcSolution
    {
        public static void Solution()
        {
            const decimal oneMinutePrice = 2.0M, taxRate = .2M;
            decimal taxTotalQuarter;
            {
                Console.Write("Введите количество минут за январь ");
                var minutesJanuary = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Введите количество минут за февраль ");
                var minutesFebruary = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Введите количество минут за март ");
                var minutesMarch = Convert.ToUInt32(Console.ReadLine());

                checked
                {
                    var minutesTotalQuarter = minutesJanuary + minutesFebruary + minutesMarch;
                    var priceTotalQuarter = minutesTotalQuarter * oneMinutePrice;
                    taxTotalQuarter = priceTotalQuarter * taxRate;
                }
            }
            Console.WriteLine($"Сумма налога: {taxTotalQuarter} грн.");
        }
    }
}
