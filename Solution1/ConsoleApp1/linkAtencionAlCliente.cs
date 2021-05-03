using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace ConsoleApp1
{
    class linkAtencionAlCliente
    {
        AtencionAlCliente oAtencionAlCliente = new AtencionAlCliente();
        public void llenandoListaClientes()
        {
            oAtencionAlCliente.llenarListaClientes("carlos");
            oAtencionAlCliente.llenarListaClientes("jesus");
            oAtencionAlCliente.llenarListaClientes("pido");
            oAtencionAlCliente.llenarListaClientes("miguel");
            oAtencionAlCliente.llenarListaClientes("lice");

            Console.WriteLine("el primer cliente en ser atendido es");
                   
            try
            {
                while (0 <= oAtencionAlCliente.ListaCliente.Count)
                {
                    Console.WriteLine(oAtencionAlCliente.ListaCliente.Peek());
                    oAtencionAlCliente.ListaCliente.Dequeue();
                    
                    if (oAtencionAlCliente.ListaCliente.Count > 0)
                    {
                        Console.WriteLine("pulsa enter para pasar al proximo cliente");
                        Console.ReadLine();
                    }     
                }
                Console.WriteLine("no quedan mas clientes en la cola");
            }
            catch (Exception e)
            {
                
            }

        }

    }
}
