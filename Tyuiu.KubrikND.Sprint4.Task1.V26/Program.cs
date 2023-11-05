using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint4.Task1.V26.Lib;
namespace Tyuiu.KubrikND.Sprint4.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кубрик Н.Д. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("*Выполнил: Кубрик Никита Дмитриевич | ИСПб-23-1                           *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 8 подсчитать сумму          *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int length;
            Console.WriteLine("Введите кол-во элементов массива: ");
            length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i <= length - 1; i++)
            {
                Console.Write("Введите " + i + " элемент массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);
            Console.WriteLine("Сумма нечетных элементов массива: " + result);
            Console.ReadKey();

        }
    }
}