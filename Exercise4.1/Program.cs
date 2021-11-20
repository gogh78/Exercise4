using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести целое число N > 0.
            //Найти квадрат данного числа, используя для его вычисления следующую формулу:
            //N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого
            //выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).
            Console.WriteLine("Введите число N больше 0");
            int n = Convert.ToInt32(Console.ReadLine());
            int s=0;
            for (int i = 1; i <= n; i++)
            {
                s += (2 * i - 1);
                Console.WriteLine(" Квадрат числа {0} равен {1}", i, s);
            }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
