using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11TskStruct
{
    public struct Solve
    {
        public double k, b;
        public void Root()
        {
            if (k > 0 || k < 0)
            {
                Console.WriteLine("Значение числа х= {0}", (0 - b) / k);
            }
            else
            {
                Console.WriteLine("Деление на 0. Уравнение не решено");
            }
        }
    }
}
