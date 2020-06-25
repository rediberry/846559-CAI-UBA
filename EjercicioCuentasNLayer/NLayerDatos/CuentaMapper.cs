using Newtonsoft.Json;
using NLayerEntidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerDatos
{
    public class CuentaMapper
    {
        public Cuenta Traer(int idCliente)
        {
            string json2 = WebHelper.Get("/api/v1/cuenta/" + idCliente.ToString()); // trae un texto en formato json de una web
            Cuenta resultado = Map(json2);
            return resultado;
        }

        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "insert");

            string result = WebHelper.Post("/api/v1/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        public TransactionResult Update(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "update");

            string result = WebHelper.Post("/api/v1/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private Cuenta Map(string json2)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json2);
            return lst;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta, string tipo)
        {
            NameValueCollection n = new NameValueCollection();

            if (tipo == "insert")
            {
                n.Add("idCliente", cuenta.idCliente.ToString());
                n.Add("Descripcion", cuenta.Descripcion);
            }
            else if (tipo == "update")
            {
                n.Add("id", cuenta.id.ToString());
                n.Add("Saldo", cuenta.Saldo.ToString());
            }

            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
