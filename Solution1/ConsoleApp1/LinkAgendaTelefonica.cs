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
            oAgendaTelefonica.llenarAgenda("jesus", "809-653-3592" );
            oAgendaTelefonica.llenarAgenda("pcprog","809-550-8455");
            oAgendaTelefonica.llenarAgenda("mildred","809-813-2700" );
            oAgendaTelefonica.llenarAgenda("josefa", "809-871-0207");
            Console.WriteLine("estas son las personas que tienes registradas:");
            foreach (var item in oAgendaTelefonica.agendaTel.Keys)
            {
                Console.WriteLine(item);
            }
        }
        public void VerificarAgendaTelefonica()
        {
            Console.WriteLine("escriba el nombre de la persona que desea ver su numero");
             entrada = Console.ReadLine();
            if (oAgendaTelefonica.agendaTel.ContainsKey(entrada))
            {
                
                Console.WriteLine("el numero de: " + entrada + " es: " + oAgendaTelefonica.agendaTel[entrada]);
            }
            else
            {
                Console.WriteLine("ese contacto no esta registrado");
            }
        }

        
    }
}
