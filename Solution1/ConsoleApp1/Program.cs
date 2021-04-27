using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static LinkMostrarPromedios oMostrarPro = new LinkMostrarPromedios();
        static LinkMostrarDiccionario oMostrarDic = new LinkMostrarDiccionario();
        static linkAtencionAlCliente oMostrarCliente = new linkAtencionAlCliente();
        static void Main(string[] args)
        {
            //oMostrarPro.llamadaPromedioEstudiantes();
            //oMostrarDic.LLamadaDiccionario();
            oMostrarCliente.llenandoListaClientes();
        }               
    }
}
