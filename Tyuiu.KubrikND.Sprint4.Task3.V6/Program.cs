using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint4.Task3.V6.Lib;

namespace Tyuiu.KubrikND.Sprint4.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кубрик Н.Д. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Кубрик Никита Дмитриевич | ИСПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент во второй строке массива.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] numsArray = new int[,] { { 8, 8, 3, 4, 5 },
                                            { 8, 6, 6, 4, 6 },
                                            { 3, 6, 5, 3, 4 },
                                            { 5, 6, 3, 7, 5 },
                                            { 7, 8, 5, 6, 6 } };

            Console.Write("Массив:{ ");
            for (int i = 0; i < numsArray.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < numsArray.Length / (numsArray.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(numsArray[i, j]);
                    if (j != numsArray.GetLength(0) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != numsArray.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(numsArray);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}