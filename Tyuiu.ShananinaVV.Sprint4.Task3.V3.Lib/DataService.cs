using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShananinaVV.Sprint4.Task3.V3.Lib
{
    public class DataService : ISprint4Task3V3
    {
        public int Calculate(int[,] array)
        {

            int rows = array.GetUpperBound(0) + 1;    //количество строк
            int columns = array.Length / rows;         //количество столбцов

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
