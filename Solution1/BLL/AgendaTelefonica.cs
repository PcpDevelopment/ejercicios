using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgendaTelefonica
    {
        public string nombre;
        public string telefono;
        public List<AgendaTelefonica> ListaAgendaTelefonica = new List<AgendaTelefonica>();


        public void llenarAgendaTelefonica(string nom, string tel)
        {
            ListaAgendaTelefonica.Add(new AgendaTelefonica { nombre = nom, telefono = tel  });
        }
    }
}
