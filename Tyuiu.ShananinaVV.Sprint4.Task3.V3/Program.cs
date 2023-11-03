using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint4.Task3.V3.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ar = new int[5, 5] { { 9, 4, 5, 4, 8 },
                                        { 7, 6, 7, 7, 4 },
                                        { 4, 4, 3, 5, 6 },
                                        { 6, 5, 9, 4, 9 },
                                        { 9, 7, 8, 7, 7 } };

            int rows = ar.GetUpperBound(0) + 1;
            int columns = ar.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{ar[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           
            int res = ds.Calculate(ar);

            
            Console.WriteLine("Количество нечетных элементов во всем массиве = " + res);
            Console.ReadKey();

        }
    }
}
