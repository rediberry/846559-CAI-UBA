using Solucion.LibreriaNegocio;
using Solucion.LibreriaNegocio.Entidades;
using Solucion.LibreriaNegocio.Exceptions;
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
            if (expendedora.Latas.Count() < 7)
            {
                try
                {
                    string c = ConsolaHelper.PedirString("Codigo");
                    double p = ConsolaHelper.PedirDouble("Precio");
                    double v = ConsolaHelper.PedirDouble("Volumen (ml)");
                    string n = expendedora.GetMarca(c);
                    string s = expendedora.GetSabor(c);

                    //generamos el objeto acá
                    Lata ll = new Lata(c, n, s, p, v);
                    expendedora.AgregarLata(ll);
                    Console.WriteLine("Lata agregada.");

                }
                catch (Exception ex)
                {
                    // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                    Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                    IngresarLata(expendedora);
                }
            }            
            else if (expendedora.Latas.Count() >= 7)
            {
                CapacidadInsuficienteException ex = new CapacidadInsuficienteException(string.Format("La {0} se encuentra llena",expendedora.Nombre));
                throw ex;
            }

        }
        private static void ExtraerLata(Expendedora expendedora)
        {
            if (expendedora.EstaVacia())
            { 
                Console.WriteLine("Codigos válidos:");
                Program.ListarLatas();
                try
                {
                    string c = ConsolaHelper.PedirString("Codigo");
                    double p = ConsolaHelper.PedirDouble("El dinero en la maquina");
                    DevolucionMaquina LataVuelto = expendedora.ExtraerLata(c, p);
                    expendedora.Latas.Remove(LataVuelto.Lata);                    
                    Console.WriteLine("Aquí tiene su {0} - {1}. Su vuelto es ${2}.", LataVuelto.Lata.Nombre, LataVuelto.Lata.Sabor, LataVuelto.Cambio.ToString());
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Intente nuevamente." + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("La expendedora está vacía.");
            }
        }
        private static void ObtenerBalance(Expendedora expendedora)
        {
            
            string saldo = expendedora.GetBalance();
            Console.WriteLine("El saldo de la expendedora es: ${0}.", saldo);
            string count = expendedora.ContarLatas(expendedora);
            Console.WriteLine("Hay {0} latas en la expendedora.", count);
            int capacidad = expendedora.GetCapacidadRestante();
            if (capacidad > 0)
            {
                Console.WriteLine("Se pueden ingresar hasta {0} latas adicionales.", capacidad);
            }
            else
            {
                Console.WriteLine("La expendedora se encuentra llena, no pueden agregarse latas adicionales.");
            }
        }
        private static void MostrarStock(Expendedora expendedora)
        {
            if (expendedora.EstaVacia())
            {
                string count = expendedora.ContarLatas(expendedora);
                Console.WriteLine("Hay {0} latas en la expendedora.", count);
                foreach (Lata a in expendedora.Latas)
                {
                    string l = a.ToString();
                    Console.WriteLine(l);
                }
            }
            else if (!expendedora.EstaVacia())
            {
                SinStockException ex = new SinStockException(string.Format("La {0} no tiene stock.", expendedora.Nombre));
                throw ex;
            }
        }
        private static void ListarLatas()
        {
            Console.WriteLine("+ CO1 - Coca Cola Regular\n+ CO2 - Coca Cola Zero\n+ SP1 - Sprite Regular "+
                "\n+ SP2 - Sprite Zero\n+ FA1 - Fanta Regular\n+ FA2 - Fanta Zero");
        }
        #endregion
    }
}
