using System;

namespace CBasics
/*
 * https://imgur.com/7AejKwz
 */
{
    public class Lesson261
    {
        public static void Solution()
        {
            double area, perimeter;
            bool isSquare;
            {
                Console.WriteLine("Введите стороны прямоугольника");
                Console.WriteLine("Первая сторона:");
                var height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вторая сторона:");
                var width = Convert.ToDouble(Console.ReadLine());

                area = height * width;
                perimeter = (height + width) * 2;
                isSquare = height.Equals(width);
            }
            Console.WriteLine("Что считаем? [площадь] или [периметр]?");
            var answer = Console.ReadLine();

            if (answer == "площадь") Console.WriteLine($"Площадь прямоугольника: {area}");
            else if (answer == "периметр") Console.WriteLine($"Периметр прямоугольника: {perimeter}");
            else Console.WriteLine("Неверная команда!");

            if (isSquare) Console.WriteLine("данный прямоугольник — квадрат");
        }
    }
}
