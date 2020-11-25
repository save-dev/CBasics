using System;

namespace CBasics
{
    /*
     * https://imgur.com/5PWFdZX
     */
    public class Lesson27
    {
        public static void Solution()
        {
            double x, y, res;
            char op;
            {
                Console.WriteLine("Введите два операнда (разделяя клавишей Enter)");
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите оператор");
                op = Convert.ToChar(Console.ReadLine()); //Possible null assignment
            }
            checked
            {
                switch (op)
                {
                    case '+':
                        res = x + y;
                        break;
                    case '-':
                        res = x - y;
                        break;
                    case '*':
                        res = x * y;
                        break;
                    case '/':
                        if (y == 0)
                        {
                            Console.WriteLine("Деление на ноль.");
                            return;
                        }
                        else res = x / y;

                        break;
                    default:
                        Console.WriteLine("Нет такой операции");
                        return;
                }
            }


            Console.WriteLine(res);
        }
    }
}
