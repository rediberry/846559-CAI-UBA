using Newtonsoft.Json;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayer.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/api/v1/cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string result = WebHelper.Post("/api/v1/cliente", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Ape);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            //n.Add("Email", cliente.Email); // STRING
            //n.Add("Telefono", cliente.Telefono.ToString()); // INT
            //n.Add("FechaNacimiento", cliente.FechaNacimiento.ToShortDateString()); // DateTime
            //n.Add("Activo", cliente.Activo.ToString()); // bool
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
