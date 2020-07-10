using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NLayer.Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _id;

        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name = "apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }
        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember]
        public string Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return string.Format("{3}) Apellido: {0}, Nombre: {1}, Dirección: {2}", this._apellido, this._nombre, this._direccion, this._id);
        }
    }
}
