using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Newtonsoft.Json;
using Entidades;
using System.Text;
using System.Threading.Tasks;
using NLayerDatos;
using System.Collections.Specialized;

namespace Datos
{
    public class PlazoFijoMapper
    {
        public List<PlazoFijo> TraerTodos()
        {
            string json = WebHelper.Get("api/v1/PlazoFijo/" + ConfigurationManager.AppSettings["Registro"]);
            List<PlazoFijo> resultadoMapeo = MapList(json);
            return resultadoMapeo;
        }
        private List<PlazoFijo> MapList(string jsonDeserializar)
        {
            List<PlazoFijo> listDeserealizada = JsonConvert.DeserializeObject<List<PlazoFijo>>(jsonDeserializar);
            return listDeserealizada;
        }
        public ResultadoTransaccion Insert(PlazoFijo plazofijonuevo)
        {
            NameValueCollection obj = ReverseMap(plazofijonuevo);
            string resultadoPost = WebHelper.Post("api/v1/PlazoFijo/", obj);
            ResultadoTransaccion resultado = MapResultado(resultadoPost);
            return resultado;
        }
        private NameValueCollection ReverseMap(PlazoFijo p)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Tipo", p.Tipo.ToString());
            n.Add("Dias", p.Dias.ToString());
            n.Add("CapitalInicial", p.CapitalInicial.ToString());            
            n.Add("Interes", p.Interes.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Registro"]);
            return n;
        }
        private ResultadoTransaccion MapResultado(string resultado)
        {
            ResultadoTransaccion mapresult = JsonConvert.DeserializeObject<ResultadoTransaccion>(resultado);
            return mapresult;
        }
    }
}
