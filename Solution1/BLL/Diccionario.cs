using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Diccionario
    {
        string key, value;
        public Dictionary<String, String> miDiccionario = new Dictionary<string, string>();


        public void llenarDiccionario (String clave, String valor)
        {
            miDiccionario.Add(key = clave, value = valor);
        }

       
    }
}
