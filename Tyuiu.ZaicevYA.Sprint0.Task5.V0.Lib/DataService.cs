﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Tyuiu.ZaycevYA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Sabtraction(int a, int b)
        {
            return (a - b);
        }
        public static int Multiplication(int a, int b)
        {
            return (b * a);

        }
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя");
                return -1;
            }
            else
            {
                return (b / a);
            }
        
        }
    }
}