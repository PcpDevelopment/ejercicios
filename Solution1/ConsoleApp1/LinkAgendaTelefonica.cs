using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace ConsoleApp1
{
    class LinkAgendaTelefonica
    {
        String entrada;
        AgendaTelefonica oAgendaTelefonica = new AgendaTelefonica();
        public void llenarAgendaTelefononica()
        {
            oAgendaTelefonica.llenarAgendaTelefonica("jesus", "809-653-3592" );
            oAgendaTelefonica.llenarAgendaTelefonica("pcprog","809-550-8455");
            oAgendaTelefonica.llenarAgendaTelefonica("mildred","809-813-2700" );
            oAgendaTelefonica.llenarAgendaTelefonica("jesus", "809-871-0207");
            Console.WriteLine("estas son las personas que tienes registradas:");
            foreach (var item in oAgendaTelefonica.ListaAgendaTelefonica)
            {
                Console.WriteLine(item.nombre);
            }
        }
        public void VerificarAgendaTelefonica()
        {
            Console.WriteLine("escriba el nombre de la persona para ver su numero telefonico");
            entrada = Console.ReadLine();
            for(int i = 0; i<oAgendaTelefonica.ListaAgendaTelefonica.Count; i++)
            {
                if(oAgendaTelefonica.ListaAgendaTelefonica[i].nombre == entrada)
                {
                    Console.WriteLine("el numero telefonico de: " + oAgendaTelefonica.ListaAgendaTelefonica[i].nombre + " es :" + oAgendaTelefonica.ListaAgendaTelefonica[i].telefono);
                }
                
            }
        }

        
    }
}
