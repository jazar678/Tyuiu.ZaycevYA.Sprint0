using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tyuiu.ZaycevYA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object Cheak(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length;i++) 
            {
                total = total + numbers[i];
            }
            return total;
        }
        public static object CheakMult(int[] numbrs) {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbrs[index];
                index++;
            }
            while (index < numbrs.Length);
            return total;
        }
        public static object CheakSabst(int[] numbers) { 
            var total = 0;
            int index = 0;

            while (index < numbers.Length) 
            { 
                total = total - numbers[index];
                index++;
            }
            return total;
            
        
        }
    }
}
