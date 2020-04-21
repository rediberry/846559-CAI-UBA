using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio_VentasDeRepuestos
{
    static class Program
    {
        static List<Categoria> listaTemporal = new List<Categoria>();

        static Program()
        {
            listaTemporal.Add(new Categoria(1, "Motores"));
            listaTemporal.Add(new Categoria(2, "Neumaticos"));
            listaTemporal.Add(new Categoria(3, "Accesorios"));
        }

        static void Main(string[] args)
        {
            Repuesto repuesto1 = new Repuesto(1);
            Repuesto repuesto2 = new Repuesto(2);
            Repuesto repuesto3 = new Repuesto(1);

            listaTemporal.Add(new Categoria(1, "Motores"));

            bool igual11 = repuesto1.Equals(repuesto2);
            bool igual22 = repuesto1.Equals(repuesto3);


            VentaRepuestos v = new VentaRepuestos();

            Console.WriteLine(repuesto1.ToString());


            int aa = repuesto1.GetHashCode();

            int cod = 2;
            double precio = 10;

            v.ModificarPrecio(cod, precio);





            bool igual1 = repuesto1 == repuesto2; // cod 1 (obj1) y cod 2 (obj2) false
            bool igual2 = repuesto1 == repuesto3; // cod 1 (obj1) y cod 1 (obj3) false

            repuesto3 = repuesto1; // ob3 ahora referencia a la inst de obj1

            bool igual3 = repuesto1 == repuesto3; // cod 1 (obj1) y cod 1 (obj3) true

            repuesto3.Codigo = 5;

            int a = 1;
            int b = 2;
            int c = a;

            c = 8;


        }

        public static void Teest(List<Repuesto> lst)
        {
            foreach (Repuesto r in lst)
            {
                r.Precio = 10;
            }

        }

        public static Repuesto GetInstancia(int cod, List<Repuesto> lst)
        {
            Repuesto result = null;
            foreach (Repuesto r in lst)
            {
                if (r.Codigo == cod)
                    result = r;
            }
            return result;
        }

    }
}