using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaycevYA.Sprint0.Task6.V0.Lib;


namespace Tyuiu.ZaycevYA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args) {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива =" + DataService.Cheak(numsArray));
            Console.WriteLine("Разность элементов массива =" + DataService.CheakSabst(numsArray));
            Console.WriteLine("Произведение элементов массива =" + DataService.CheakMult(numsArray));
            Console.ReadKey();




        }
    

    }


}