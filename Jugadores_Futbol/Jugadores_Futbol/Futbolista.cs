using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugadores_Futbol
{
    class Futbolista
    {
        private string nombre, apellido, posicion, edad;
        private string club = "Club Atlético Newell's Old Boys de Rosario";

        public string Nombre
        {
            set
            {
                nombre = value.ToUpper();
            }
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            set
            {
                apellido = value.ToUpper();
            }
            get
            {
                return apellido;
            }
        }

        public string Posicion
        {
            set
            {
                posicion = value.ToUpper();
            }
            get
            {
                return posicion;
            }
        }

        public string Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        private string Club
        {
            set
            {
                club = value.ToUpper();
            }
            
        }
        public string GetNombreCompleto()
        {
            return nombre + " " + apellido;
        }

        public string GetClub()
        {
            return "soy hincha de " + club;
        }

        public void Pasar()
        {
            Console.WriteLine("Hola, soy " + nombre + " " + apellido + ", estoy haciendo un pase!");
        }

        public void Patear()
        {
            Console.WriteLine("Tengo " + edad + " y estoy pateando la pelota!");
        }

        public void Cabecear()
        {
            Console.WriteLine("Juego de " + posicion + ", por eso estoy cabeceando una pelota aerea!");
        }

        public void Marcar()
        {
            Console.WriteLine("Estoy marcando a un jugador contrario!");
        }

        public void Correr()
        {
            Console.WriteLine("Estoy corriendo!");
        }

        public void HacerPromocion(Sponsor unSponsor, string slogan)
        {
            this.Pasar();
            Console.WriteLine("Voy a hacer la siguiente promocion:\n"
                + unSponsor.Promocionar());
            Console.WriteLine(">>>" + slogan + "<<<");
        }

    }
}
