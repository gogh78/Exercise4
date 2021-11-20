using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести положительные числа A, B, C.
            //На прямоугольнике размера A x B размещено максимально возможное
            //количество квадратов со стороной C (без наложений).
            //Найти количество квадратов, размещенных на прямоугольнике.
            //Операции умножения и деления не использовать.
            Console.WriteLine("Введите положительные числа A, B - стороны прямоугольника и C - сторона вписываемого квадрата ");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            double f = a;
            while (b >= c)
            {
                b -= c;
                a = f;
                while (a >= c)
                {
                    a -= c;
                    s++;
                }
                
            }
            Console.WriteLine(" Количество квадратов вписаных в прямоугольник - {0}", s);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
