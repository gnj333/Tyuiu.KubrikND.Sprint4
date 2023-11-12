using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KubrikND.Sprint4.Task5.V14.Lib;

namespace Tyuiu.KubrikND.Sprint4.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #3 | Выполнил: Кубрик Н. Д. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Двумерные массивы(генератор случайных чисел)                       *");
            Console.WriteLine("*Задание #4.5                                                             *");
            Console.WriteLine("*Вариант #14                                                              *");
            Console.WriteLine("*Выполнил: Кубрик Никита Дмитриевич | ИСПб-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан двумерный целочисленный массив на 5 на 5 элементов заполненный       *");
            Console.WriteLine("*случайными значениями в диапазоне от -5 до 7. Найдите количество         *");
            Console.WriteLine("*положительных элементов.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int rows, columns;
            Console.Write("Введите кол-во строк массива: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов массива: ");
            columns = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    array[i, j] = rnd.Next(-5, 7);
            }

            Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
