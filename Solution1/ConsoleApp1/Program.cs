using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static List<Program> prueba = new List<Program>();
        string nombre, telefono;
        static LinkMostrarPromedios oMostrarPro = new LinkMostrarPromedios();
        static LinkMostrarDiccionario oMostrarDic = new LinkMostrarDiccionario();
        static linkAtencionAlCliente oMostrarCliente = new linkAtencionAlCliente();
        static LinkGastosDelMes oMostrarGastosDelMes = new LinkGastosDelMes();
        static LinkAgendaTelefonica oAgendaTelefonica = new LinkAgendaTelefonica();
        static void Main(string[] args)
        {
            //oMostrarPro.llamadaPromedioEstudiantes();
            //oMostrarDic.LLamadaDiccionario();
            oMostrarCliente.llenandoListaClientes();
            /*oMostrarGastosDelMes.llenandooListaGastoMes();
            oMostrarGastosDelMes.OrgnizandoYmostrandoGastosPorDia();
            oMostrarGastosDelMes.Organizando_MostrandoGastosPorMonto();
            oMostrarGastosDelMes.MostrarSuma();*/
            //oAgendaTelefonica.llenarAgendaTelefononica();
            //oAgendaTelefonica.VerificarAgendaTelefonica();

            



        }               
    }
}
