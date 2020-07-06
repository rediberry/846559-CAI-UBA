using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using NLayerEntidades;
using Newtonsoft.Json;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerDatos
{
    public class PrestamoMapper
    {
        public List<Prestamo> Traer()
        {
            string json3 = WebHelper.Get("api/v1/prestamo/" + ConfigurationManager.AppSettings["Registro"]);
            List<Prestamo> resultado = MapList(json3);
            return resultado;
        }
        public ResultadoTransaccion Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string result = WebHelper.Post("api/v1/prestamo/", obj);
            ResultadoTransaccion resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("TNA", prestamo.TNA.ToString());
            n.Add("Linea", prestamo.Linea);
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Monto", prestamo.Monto.ToString());
            n.Add("Cuota", prestamo.Cuota.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Registro"]);
            return n;
        }
        private ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }
    }
}
