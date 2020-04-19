
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuarActivo = true;

            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar Nomina"+
                "\n2) Agregar Empleado \n3) Borrar Empleado \n4) Obtener empleado con mayor salario" +
                "\n5) Limpiar Consola \nX) Salir";


            // Creo el objeto con el que voy a trabajar en este programa
            Nomina nomina1 = new Nomina("cai");

            // pantalla de bienvenida
            Console.WriteLine("Bienvenido a " + nomina1.Nombre);

            do
            {
                Console.WriteLine(menu); //mostramos el menú
                try
                {
                    //capturamos la seleccion
                    string opcionSeleccionada = Console.ReadLine();
                    // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                    // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                    if (ConsolaHelper.EsOpcionValida(opcionSeleccionada, "12345X"))
                    {
                        if (opcionSeleccionada.ToUpper() == "X")
                        {
                            continuarActivo = false;
                            continue;
                        }

                        switch (opcionSeleccionada)
                        {
                            case "1":
                                // listar
                                Program.ListarNomina(nomina1);
                                break;

                            case "2":
                                // agregar empleado
                                Program.AgregarEmpleado(nomina1);

                                break;
                            case "3":
                                // eliminar empleado
                                Program.EliminarEmpleado(nomina1);

                                break;
                            case "4":
                                // alta
                                Program.ObtenerEmpleadoCaro(nomina1);
                                break;
                            case "5":
                                // limpiar consola
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
        private static void EliminarEmpleado(Nomina nomina)
        {            
            if (nomina.TieneEmpleados)
            {
                ListarNomina(nomina);
                Console.WriteLine("Elija un apellido de la lista para eliminar: ");
                try
                {
                    string a = ConsolaHelper.PedirString("Apellido");

                    nomina.EliminarEmpleado(a);

                    Console.WriteLine("El empleado ha sido eliminado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No es posible eliminar el empleado solicitado. " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Por el momento no hay empleados para eliminar");
            }
        }

        private static void AgregarEmpleado(Nomina nomina)
        {
            try
            {

                string n = ConsolaHelper.PedirString("Nombre");
                string a = ConsolaHelper.PedirString("Apellido");        
                double s = ConsolaHelper.PedirDouble("Salario");

                // acá si necesitamos enviarle los param al método para que sepa que tipo de obj crear
                nomina.AgregarEmpleado(n, a, s);
                Console.WriteLine("Empleado agregado.");

            }
            catch (Exception ex)
            {
                // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                // podemos preguntarle si quiere hacerlo de nuevo. Depende de nuestro negocio.
                // if(quiereIntentarNuevamente)
                AgregarEmpleado(nomina);
            }
        }

        public static void ListarNomina(Nomina nomina)
        {
            
            if (nomina.TieneEmpleados)
            {
                foreach (Empleado a in nomina.Empleados)
                {
                    MostrarCredencial(a);
                }
            }
            else
            {
                Console.WriteLine("Por el momento no hay empleados para listar.");
            }
        }
         
        private static void MostrarCredencial(Empleado empleado)
        {
            Console.WriteLine(empleado.GetNombreCompleto());
        }

        public static void ObtenerEmpleadoCaro(Nomina nomina)
        {
            if (nomina.TieneEmpleados)
            {
                nomina.ObtenerEmpleadoCaro();
            }
            else
            {
                Console.WriteLine("Por el momento, la lista se encuentra vacía.");
            }
        }
        #endregion
    }

}
