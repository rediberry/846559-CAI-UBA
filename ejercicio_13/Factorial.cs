using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13
{
    class Factorial
    {
        public static int Facto(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Facto(num - 1);
        }
    }
}
