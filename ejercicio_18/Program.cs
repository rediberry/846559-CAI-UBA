using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;

            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Conversor \n2) Limpiar Consola \nX) Salir";

            // pantalla de bienvenida
            Console.WriteLine("Bienvenido al conversor de CAI");
            do
            {
                Console.WriteLine(menu); //mostramos el menú

                try
                {
                    //capturamos la seleccion
                    string opcionSeleccionada = Console.ReadLine();

                    // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                    // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                    if (ConsolaHelper.EsOpcionValida(opcionSeleccionada, "12X"))
                    {
                        if (opcionSeleccionada.ToUpper() == "X")
                        {
                            continuarActivo = false;
                            continue;
                        }

                        switch (opcionSeleccionada)
                        {
                            case "1":
                                // Conversor
                                Program.Conversor();
                                break;                                 
                            case "2":
                                Console.Clear();
                                break;
                            //etc... si tenemos más opciones...
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor intente nuevamente. Mensaje: " + ex.Message);
                }
                Console.WriteLine("Ingrese una tecla para continuar.");

                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);

            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();            
        }

        #region "Métodos Propios de este programa, no reutilizables ya que piden ingresos solo para interfaz consola"

        private static void Conversor()
        {            
            int valor = ConsolaHelper.PedirInt("el numero que desea convertir");
            Calculadora.Conversor1(valor);
        }

        #endregion
    }
}

