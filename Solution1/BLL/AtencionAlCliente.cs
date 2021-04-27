using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AtencionAlCliente
    {
       String clientes;
       public  Queue<String> ListaCliente = new Queue<string>();

        public void llenarListaClientes(String cliente)
        {
            ListaCliente.Enqueue(clientes = cliente);
        }

        public void OrdenClientes()
        {
            
        }

    }
}
