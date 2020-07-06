using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using NLayerEntidades;
using System.Threading.Tasks;

namespace NLayerDatos
{
    public class LineasPrestamoMapper
    {
        public List<TipoPrestamo> TraerTodos()
        {
            string json2 = WebHelper.Get("api/v1/prestamotipo");
            List<TipoPrestamo> resultado = MapList(json2);
            return resultado;
        }
        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> lst = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return lst;
        }
    }
}
