using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_expendedora
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;            

            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar latas disponibles \n2) Agregar latas " +
                "\n3) Extraer lata \n4) Mostrar balance \n5) Ver stock \n6) Limpiar Consola \nX) Salir";


            // Creo el objeto con el que voy a trabajar en este programa
            Expendedora exp1 = new Expendedora("Expendedora CAI");
            exp1.Encendida = false;
            Console.WriteLine("Desea encender la Expendedora?");
            string encender = ConsolaHelper.PedirString("'s'");
            if (ConsolaHelper.EsOpcionValida(encender, "s"))
            {


                do
                {
                    // pantalla de bienvenida
                    Console.WriteLine("Bienvenido a " + exp1.Nombre);
                    Console.WriteLine(menu); //mostramos el menú

                    try
                    {
                        //capturamos la seleccion
                        string opcionSeleccionada = Console.ReadLine();

                        // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                        // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                        if (ConsolaHelper.EsOpcionValida(opcionSeleccionada, "123456X"))
                        {
                            if (opcionSeleccionada.ToUpper() == "X")
                            {
                                continuarActivo = false;
                                continue;
                            }

                            switch (opcionSeleccionada)
                            {
                                
                                case "1":
                                    // listar latas disponibles
                                    Program.ListarLatas();

                                    break;
                                case "2":
                                    // agregar latas
                                    Program.IngresarLata(exp1);

                                    break;
                                case "3":
                                    // extraer latas
                                    Program.ExtraerLata(exp1);
                                    break;
                                case "4":
                                    // mostrar balance
                                    Program.ObtenerBalance(exp1);
                                    break;
                                case "5":
                                    // ver stock
                                    Program.MostrarStock(exp1);
                                    break;
                                case "6":
                                    // limpiar pantalla
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
                
            }  else Console.WriteLine("Gracias por usar la app.");

            Console.ReadKey();
            
            

             
        }

        #region 
        private static void IngresarLata(Expendedora expendedora)
        {
            Console.WriteLine("Codigos válidos:");
            Program.ListarLatas();
            try
            {
                               
                 string c = ConsolaHelper.PedirString("Codigo");            
                              

                //string n = ConsolaHelper.PedirString("Nombre");
                //string s = ConsolaHelper.PedirString("Sabor");
                double p = ConsolaHelper.PedirDouble("Precio");
                double v = ConsolaHelper.PedirDouble("Volumen");


                // opcion 1 generamos el objeto acá
                Lata ll = new Lata(c, n, s, p, v);
                expendedora.AgregarLata(ll);
                Console.WriteLine("Lata agregada.");
                // opción 2 mandamos valores y que lo genere el propio método                
            }
            catch (Exception ex)
            {
                // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                // podemos preguntarle si quiere hacerlo de nuevo. Depende de nuestro negocio.
                // if(quiereIntentarNuevamente)
                IngresarLata(expendedora);
            }
        }
        private static void ExtraerLata(Expendedora expendedora)
        {
            throw new NotImplementedException();
        }
        private static void ObtenerBalance(Expendedora expendedora)
        {
            throw new NotImplementedException();
        }
        private static void MostrarStock(Expendedora expendedora)
        {
            throw new NotImplementedException();
        }
        private static void ListarLatas()
        {
            Console.WriteLine("+ CO1 - Coca Cola Regular\n+ CO2 - Coca Cola Zero\n+ SP1 - Sprite Regular "+
                "\n+ SP2 - Sprite Zero\n+ FA1 - Fanta Regular\n+ FA2 - Fanta Zero");
        }
        #endregion
    }
}
