using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaycevYA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.ZaycevYA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #0                                                     *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                   *");
            Console.WriteLine("* Задание #7                                                    *");
            Console.WriteLine("* Вариант #0                                                    *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать консульную программу на C# , которая суммирует       *");
            Console.WriteLine("* значения двух одинаковых массивов по длине                    *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");

            int[] ar1 = new int[] { 1, 2, 3, 4, 5, };
            Console.WriteLine("Заначение элементов массива №1");
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.Write(ar1[i] + ",");

            }
            Console.WriteLine();

            int[] ar2 = new int[] { 1,2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.Write(ar2[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");

            if (ar1.Length == ar2.Length)
            {
                int[] re = DataService.Add(ar1, ar2);
                Console.WriteLine("Сумма элементов массива равна");
                for (int i = 0; i < re.Length; i++)
                {
                    Console.Write(re[i] + ",");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов *");
            }
            Console.ReadKey();

        }
    }
}