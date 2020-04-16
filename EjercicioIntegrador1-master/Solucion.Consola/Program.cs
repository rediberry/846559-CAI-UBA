﻿using Solucion.LibreriaConsola;
using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;

            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar Alumnos \n2) Listar Empleados \n3) Agregar Alumno " +
                "\n4) Agregar Empleado \n5) Borrar Alumno \n6) Borrar Empleado \n7) Limpiar Consola \nX) Salir";
         
            
            // Creo el objeto con el que voy a trabajar en este programa
            Facultad fce = new Facultad("FCE");

            // pantalla de bienvenida
            Console.WriteLine("Bienvenido a " + fce.Nombre);

            do
            {
                Console.WriteLine(menu); //mostramos el menú

                try
                {
                    //capturamos la seleccion
                    string opcionSeleccionada = Console.ReadLine(); 

                    // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                    // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                    if (ConsolaHelper.EsOpcionValida(opcionSeleccionada,"1234567X"))
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
                                Program.ListarAlumnos(fce);
                                break;
                            case "2":
                                // listar
                                Program.ListarEmpleados(fce);
                                
                                break;
                            case "3":
                                // alta
                                Program.AgregarAlumno(fce);
                                
                                break;
                            case "4":
                                // alta
                                Program.AgregarEmpleado(fce);
                                break;
                            case "5":
                                // borrar
                                Program.EliminarAlumno(fce);
                                break;
                            case "6":
                                // borrar
                                Program.EliminarEmpleado
                                    (fce);
                                break;
                            case "7":
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
                catch (Exception ex) {
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
        private static void EliminarEmpleado(Facultad facultad)
        {
            Program.ListarEmpleados(facultad);            
            int legajo = ConsolaHelper.PedirInt("el Legajo que desea eliminar");
            facultad.EliminarEmpleado(legajo);
            Console.WriteLine("Empleado eliminado.");
        }

        private static void AgregarEmpleado(Facultad facultad)
        {
            try
            {
                
                string n = ConsolaHelper.PedirString("Nombre");
                string a = ConsolaHelper.PedirString("Apellido");
                int c = ConsolaHelper.PedirInt("Legajo");
                string t = ConsolaHelper.PedirString("tipo empleado (D docente, B bedel, A directivo)");
                DateTime f = ConsolaHelper.PedirFecha("Ingreso laboral");
                

                string ap = string.Empty;
                if (t.ToUpper() == "B")
                {
                    ap = ConsolaHelper.PedirString("Apodo");
                }
                int s = 0;
                if (t.ToUpper() == "D")
                {
                    s = ConsolaHelper.PedirInt("Puntaje");
                }
                

                // acá si necesitamos enviarle los param al método para que sepa que tipo de obj crear
                facultad.AgregarEmpleado(n,a,c,f,t,ap,s);
                Console.WriteLine("Empleado agregado.");

            }
            catch (Exception ex)
            {
                // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                // podemos preguntarle si quiere hacerlo de nuevo. Depende de nuestro negocio.
                // if(quiereIntentarNuevamente)
                AgregarEmpleado(facultad);
            }
        }

        private static void EliminarAlumno(Facultad facultad)
        {
            Program.ListarAlumnos(facultad);
            int codigo = ConsolaHelper.PedirInt("el codigo que desea eliminar");
            facultad.EliminarAlumno(codigo);
            Console.WriteLine("Alumno eliminado.");
        }

        private static void AgregarAlumno(Facultad facultad)
        {
            try
            {
                string n = ConsolaHelper.PedirString("Nombre");
                string a = ConsolaHelper.PedirString("Apellido");
                int c = ConsolaHelper.PedirInt("Código");
                DateTime f = ConsolaHelper.PedirFecha("nacimiento");

                // opcion 1 generamos el objeto acá
                Alumno al = new Alumno(c,n,a,f);
                facultad.AgregarAlumno(al);
                Console.WriteLine("Alumno agregado.");
                // opción 2 mandamos valores y que lo genere el propio método
                // facultad.AgregarAlumno(n,a,c,f);
            }
            catch (Exception ex)
            {
                // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                // podemos preguntarle si quiere hacerlo de nuevo. Depende de nuestro negocio.
                // if(quiereIntentarNuevamente)
                AgregarAlumno(facultad);
            }

        }

        public static void ListarAlumnos(Facultad facultad)
        {
            Console.WriteLine("Listado de Alumnos:");
            foreach(Alumno a in facultad.Alumnos)
            {
                MostrarCredencial(a);
            }
            if ( facultad.Alumnos.Count == 0)
            {
                Console.WriteLine("La lista de alumnos se encuentra vacía");
            }

        }

        public static void ListarEmpleados(Facultad facultad)
        {
            Console.WriteLine("Listado de Empleados:");
            foreach (Empleado a in facultad.Empleados)
            {
                MostrarCredencial(a);
            }
            if (facultad.Empleados.Count == 0)
            {
                Console.WriteLine("La lista de empleados se encuentra vacía");
            }
        }

        private  static void MostrarCredencial(Persona persona)
        {
            Console.WriteLine(persona.GetCredencial());
        }

        #endregion

    }
}
