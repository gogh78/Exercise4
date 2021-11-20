using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Осуществить ввод последовательности целых чисел и сравнить, что больше,
            //количество положительных или количество отрицательных. Последовательность
            //потенциально не ограничена, окончанием последовательности служит число 0.
            Console.WriteLine("Введите последовательность целых чисел (Число 0 служит окончанием)");
            int i;
            int negativ=0;
            int positiv=-1;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i<0)
                {
                    negativ++;
                }
                else
                {
                    positiv++;
                }
            }
            while (i != 0);
           
            Console.WriteLine("Количество отрицательных = {0} количество положительных {1} ", negativ, positiv);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
