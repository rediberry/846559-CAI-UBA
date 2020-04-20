using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionConsola
{
    public abstract class Calculadora
    {
        private double _valor;

        public double Valor { get => _valor; set => _valor = value; }
       
        public static void Conversor1(Int32 a)
        {            
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(a, 8));
            Console.WriteLine(Convert.ToString(a, 16));
        }        
    }
}
