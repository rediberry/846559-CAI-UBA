﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_calculadora_basica
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string n;
            bool esNumero;
            int valor2;
            string n2;
            string opc_user;
            string opc_user_suma = "suma";
            string opc_user_resta = "resta";
            int operacion = 0;
            string rta_user;
            string rta_si = "si";
            string rta_no = "no";
            List <int> coleccion_resultados = new List<int>();

            do
            {

                do
                {
                    Console.WriteLine("Ingrese el primer Valor Entero");
                    n = Console.ReadLine();
                    /* Si es número correcto retornará true y saldrá
                    *  del Ciclo*/
                    esNumero = int.TryParse(n, out valor);
                }
                while (!esNumero);
                Console.WriteLine("El primer Valor Ingresado es " + n);
                Console.ReadKey();
                Console.Clear();

                do
                {
                    Console.WriteLine("Ingrese el segundo Valor Entero");
                    n2 = Console.ReadLine();
                    /* Si es número correcto retornará true y saldrá
                    *  del Ciclo*/
                    esNumero = int.TryParse(n2, out valor2);
                }
                while (!esNumero);
                Console.WriteLine("El segundo Valor Ingresado es " + n2);
                Console.ReadKey();
                Console.Clear();

                
                
                Console.WriteLine("Ingrese 'suma' si desea SUMAR o 'resta' si desea RESTAR");
                opc_user = Console.ReadLine();                  
                //falta validacion de lo que se ingresa por consola

                Console.WriteLine("La opción ingresada es: " + opc_user);
                Console.ReadKey();
                Console.Clear();

                if (opc_user == opc_user_suma)
                {
                    operacion = valor + valor2;
                    Console.WriteLine("La suma es: " + operacion);                    
                }
                else if (opc_user == opc_user_resta)
                {
                    operacion = valor - valor2;
                    Console.WriteLine("La resta es: " + operacion);                    
                }

                coleccion_resultados.Add(operacion);
                                             
                
                Console.WriteLine("Desea realizar otra operación? S/N");
                rta_user = Console.ReadLine();
                //falta validacion de lo que se ingresa por consola
                
                Console.WriteLine("La respuesta ingresada es: " + rta_user);
                Console.ReadKey();
                Console.Clear();                                             
            }
            while (rta_user != rta_no);
            

            if (coleccion_resultados.Count() > 1)
            {
                Console.WriteLine("Los resultados obtenidos son: " + coleccion_resultados);
            }
            else Console.WriteLine("Para mostrar los resultados obtenidos deben haber al menos 2 operaciones");
            Console.ReadKey();
        }
    }
}
