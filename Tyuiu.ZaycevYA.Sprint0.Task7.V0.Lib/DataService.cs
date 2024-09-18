using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tyuiu.ZaycevYA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] Add(int[] n1, int[] n2) 
        {
            int[] re= new int[5];
            for (var i = 0; i < re.Length; i++)
            {
                re [i]= n1[i] + n2[i];
            }
            return re;
        }
    }
}
