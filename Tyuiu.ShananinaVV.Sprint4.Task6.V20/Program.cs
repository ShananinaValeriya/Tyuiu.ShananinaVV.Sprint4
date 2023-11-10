using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint4.Task6.V20.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных {'Математика','Физика','Химия','Биология',  *");
            Console.WriteLine("* 'География','История','Литература'}. Используя класс Array, выведите    *");
            Console.WriteLine("* элементы массива, длина которых меньше 10 символов.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var sb = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= sb.Length - 1; i++)
            {
                Console.WriteLine(sb[i]);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы массива, длина которых меньше 10 символов: ");

            string[] res = ds.Calculate(sb);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();

        }
    }
}
